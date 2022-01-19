using FileHelpers;
using MapCGLToRemote.InputModels;
using System.Collections.Generic;

namespace MapCGLToRemote.Parsing
{
    public class RTUDeviceTypeParser
    {
        public Dictionary<string, string> ParseDeviceRtu(string FilePath)
        {
            var RTUNameEngine = new FileHelperEngine<RemoteDeviceType>();

            var RTUNameList = RTUNameEngine.ReadFile(FilePath + "RemoteDeviceType.csv");

            return PopulateDictionaryWithNames(RTUNameList);
        }

        public Dictionary<string, string> PopulateDictionaryWithNames(RemoteDeviceType[] names)
        {
            var DeviceDictionary = new Dictionary<string, string>();

            foreach (var name in names)
            {
                DeviceDictionary.Add(name.RemoteName, name.DeviceType);
            }
            return DeviceDictionary;
        }
    }
}
