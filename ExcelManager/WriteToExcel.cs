using System.Collections.Generic;
using System.IO;
using OfficeOpenXml;
using MapCGLToRemote.OutputModels;

namespace MapCGLToRemote.ExcelManager
{
    public class WriteToExcel
    {
        public void WriteExcel(List<CGL> cglConfigs, List<CGLTemplateDef> cglTemplates, List<RemoteCGL> remoteCGLTemplates, 
            List<RemoteRunDevice> efmdata, List<RemoteRunDevice> egmdata, List<CGLTemplateDef> prodcgl, 
            List<CGLTemplateDef> testcgl, List<RemoteCGL> WrongCGLs, List<GQTemplateDef> GQConfigs, string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using ExcelPackage excel = new ExcelPackage();
            excel.Workbook.Worksheets.Add("RemoteCGLConfig");
            excel.Workbook.Worksheets.Add("CGLConfigs");
            excel.Workbook.Worksheets.Add("RemoteCGLTemplates");
            //excel.Workbook.Worksheets.Add("WrongRemoteCGL");
            excel.Workbook.Worksheets.Add("EFMRunDevice");
            excel.Workbook.Worksheets.Add("EGMRunDevice");
            excel.Workbook.Worksheets.Add("ProdCGL");
            excel.Workbook.Worksheets.Add("TestCGL");
            excel.Workbook.Worksheets.Add("WrongCGLConfigs");
            excel.Workbook.Worksheets.Add("GQConfigs");

            var RemoteCGLConfig = excel.Workbook.Worksheets["RemoteCGLConfig"];
            var CGLConfig = excel.Workbook.Worksheets["CGLConfigs"];
            var RemoteCGLTemplates = excel.Workbook.Worksheets["RemoteCGLTemplates"];
            //var WrongRemoteCGL = excel.Workbook.Worksheets["WrongRemoteCGL"];
            var EFMRunDevices = excel.Workbook.Worksheets["EFMRunDevice"];
            var EGMRunDevices = excel.Workbook.Worksheets["EGMRunDevice"];
            var ProdCGL = excel.Workbook.Worksheets["ProdCGL"];
            var TestCGL = excel.Workbook.Worksheets["TestCGL"];
            var WrongCGLConfigs = excel.Workbook.Worksheets["WrongCGLConfigs"];
            var GQTemplates = excel.Workbook.Worksheets["GQConfigs"];

            RemoteCGLConfig.Cells.LoadFromCollection(cglConfigs, true);
            CGLConfig.Cells.LoadFromCollection(cglTemplates, true);
            RemoteCGLTemplates.Cells.LoadFromCollection(remoteCGLTemplates, true);
            //WrongRemoteCGL.Cells.LoadFromCollection(remoteCGLs, true);
            EFMRunDevices.Cells.LoadFromCollection(efmdata, true);
            EGMRunDevices.Cells.LoadFromCollection(egmdata, true);
            ProdCGL.Cells.LoadFromCollection(prodcgl, true);
            TestCGL.Cells.LoadFromCollection(testcgl, true);
            WrongCGLConfigs.Cells.LoadFromCollection(WrongCGLs, true);
            GQTemplates.Cells.LoadFromCollection(GQConfigs, true);

            FileInfo excelFile = new FileInfo(filePath + @"RemoteMeasurementInfo.xlsx");
            excel.SaveAs(excelFile);
        }
    }
}
