using System.Collections.Generic;
using FileHelpers;
using MapCGLToRemote.InputModels;

namespace MapCGLToRemote.Parsing
{
    public class NameParser
    {
        public Dictionary<string, string> Parse(string FilePath)
        {
            var RTUNameEngine = new FileHelperEngine<RTUOASySName>();

            var RTUNameList = RTUNameEngine.ReadFile(FilePath + "RTUMapLegacyName.csv");

            return PopulateDictionaryWithNames(RTUNameList);
        }

        public Dictionary<string, string> PopulateDictionaryWithNames(RTUOASySName [] names)
        {
            var NameDictionary = new Dictionary<string, string>();

            foreach (var name in names)
            {
                NameDictionary.Add(name.RTUName, name.OASySName);
            }
            return NameDictionary;
        }
    }
}
