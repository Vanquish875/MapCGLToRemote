using System;
using MapCGLToRemote.Parsing;
using MapCGLToRemote.Mapping;
using System.Collections.Generic;
using MapCGLToRemote.OutputModels;
using MapCGLToRemote.ExcelManager;
using MapCGLToRemote.Fields;
using MapCGLToRemote.DataCompare;

namespace MapCGLToRemote
{
    class Program
    {
        static void Main(string[] args)
        {
            string FilePath = @"E:\TCEnergy\EFM\";

            var EGMParser = new EGMParser();
            var RunParser = new RunDefParser();
            var EFMParser = new DeviceReferParser();
            var RTUNameParser = new NameParser();
            var RTUDeviceTypeParser = new RTUDeviceTypeParser();
            var CGLTemplateDefParser = new DotLParser();
            var RTUCGLParser = new RTUCGLTemplateParser();

            var EGMData = EGMParser.Parse(FilePath);
            var RunData = RunParser.Parse(FilePath);
            var EFMData = EFMParser.Parse(FilePath);
            var RTUNameData = RTUNameParser.Parse(FilePath);
            var DeviceData = RTUDeviceTypeParser.ParseDeviceRtu(FilePath);
            var CGLTemplateDefData = CGLTemplateDefParser.ProcessFile(FilePath + "cgltemplatedef.l", CGLTemplateDefFields.Fields);
            var TestCGLTemplateDefData = CGLTemplateDefParser.ProcessFile(FilePath + @"\test\cgltemplatedef.l", CGLTemplateDefFields.Fields);
            var ProdCGLTemplateDefData = CGLTemplateDefParser.ProcessFile(FilePath + @"\prod\cgltemplatedef.l", CGLTemplateDefFields.Fields);
            var RTUCGLData = RTUCGLParser.ParseTemplateRtu(FilePath);

            var TemplateMapper = new MapTemplate();
            var TemplateData = TemplateMapper.MapTemplateDef(CGLTemplateDefData);
            var TestTemplateData = TemplateMapper.MapTemplateDef(TestCGLTemplateDefData);
            var ProdTemplateData = TemplateMapper.MapTemplateDef(ProdCGLTemplateDefData);
            
            var RemoteMapper = new MapRemotes();
            var CGLMapper = new MapCGL();
            var TemplateCGLMapper = new MapTemplateCGL();
            var RemoteTemplateMapper = new MapCGLToRemotes();
            var EFMDeviceMapper = new MapEFMMeter();
            var EGMDeviceMapper = new MapEGMMeter();
            var RunDefDeviceMapper = new MapRunDef();
            var CGLProdToTestCompare = new CompareCGL();
            var FindWrongTemplates = new VerifyCGLConfiguration();
            var TemplateGQMapper = new MapGQTemplate();

            var TemplateCGLs = TemplateCGLMapper.MapCGLTemplate(TemplateData);
            var TemplateGQs = TemplateGQMapper.MapGQ(TemplateData);
            var TestTemplateCGLs = TemplateCGLMapper.MapCGLTemplate(TestTemplateData);
            var ProdTemplateCGLs = TemplateCGLMapper.MapCGLTemplate(ProdTemplateData);

            var remoteConfigs = RemoteMapper.LoadRemotes(EGMData, RTUNameData);

            var CGLConfigs = CGLMapper.Map(remoteConfigs, RTUNameData, DeviceData);

            var RemoteTemplates = RemoteTemplateMapper.MapRemoteCGLTemplates(CGLConfigs, TemplateCGLs);

            var ProdCGLs = CGLProdToTestCompare.CompareProdToTestCGL(ProdTemplateCGLs, TestTemplateCGLs);
            var TestCGLs = CGLProdToTestCompare.CompareTestToProdCGL(ProdTemplateCGLs, TestTemplateCGLs);

            var WrongTemplates = FindWrongTemplates.CompareEGMWithCGL(CGLConfigs, TemplateCGLs, RTUCGLData);

            //var EGMDevices = EGMDeviceMapper.MapMetersToRuns(EGMData, RTUNameData);
            var RunDefDevices = RunDefDeviceMapper.MapEGMMeters(RunData, RTUNameData);
            var EFMDevices = EFMDeviceMapper.MapMetersToRuns(EFMData, RunDefDevices);
            
            //PrintValues(CGLConfigs);
            PrintToExcel(CGLConfigs, TemplateCGLs, RemoteTemplates, EFMDevices, RunDefDevices, 
                ProdCGLs, TestCGLs, WrongTemplates, TemplateGQs, FilePath);
        }

        public static void PrintValues(List<CGL> cgls)
        {
            foreach(var cgl in cgls)
            {
                Console.WriteLine(cgl.ToString());
            }
        }

        public static void PrintToExcel(List<CGL> cgls, List<CGLTemplateDef> cglTemplates, List<RemoteCGL> remoteTemplates, 
            List<RemoteRunDevice> efmdata, List<RemoteRunDevice> egmdata, List<CGLTemplateDef> prodcgl, 
            List<CGLTemplateDef> testcgl, List<RemoteCGL> wrongConfigs, List<GQTemplateDef> GQConfigs, string filePath)
        {
            var excel = new WriteToExcel();

            excel.WriteExcel(cgls, cglTemplates, remoteTemplates, efmdata, egmdata, prodcgl, testcgl, wrongConfigs, GQConfigs, filePath);
        }
    }
}
