using FileHelpers;
using MapCGLToRemote.InputModels;
using System.Collections.Generic;

namespace MapCGLToRemote.Parsing
{
    public class RTUCGLTemplateParser
    {
        public Dictionary<string, string> ParseTemplateRtu(string FilePath)
        {
            var RTUCGLEngine = new FileHelperEngine<RemoteCGLTemplate>();

            var RTUCGLList = RTUCGLEngine.ReadFile(FilePath + "RemoteCGLMap.csv");

            return PopulateDictionaryWithNames(RTUCGLList);
        }

        public Dictionary<string, string> PopulateDictionaryWithNames(RemoteCGLTemplate[] names)
        {
            var DeviceDictionary = new Dictionary<string, string>();

            foreach (var name in names)
            {
                DeviceDictionary.Add(name.RemoteName, name.CGLTemplate);
            }
            return DeviceDictionary;
        }
    }
}
