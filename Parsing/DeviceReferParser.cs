using FileHelpers;
using MapCGLToRemote.InputModels;

namespace MapCGLToRemote.Parsing
{
    public class DeviceReferParser
    {
        public EFMDeviceRefer[] Parse(string FilePath)
        {
            var EFMEngine = new FileHelperEngine<EFMDeviceRefer>();

            var EFMList = EFMEngine.ReadFile(FilePath + "DeviceRefer.csv");

            return EFMList;
        }
    }
}
