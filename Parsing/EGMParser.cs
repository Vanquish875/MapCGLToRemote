using FileHelpers;
using MapCGLToRemote.InputModels;

namespace MapCGLToRemote.Parsing
{
    public class EGMParser
    {
        public EGMConfig[] Parse(string FilePath)
        {
            var EGMEngine = new FileHelperEngine<EGMConfig>();

            var EGMList = EGMEngine.ReadFile(FilePath + "NMAEGMConfig.csv");

            return EGMList;
        }
    }
}
