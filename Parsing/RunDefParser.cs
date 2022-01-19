using FileHelpers;
using MapCGLToRemote.InputModels;

namespace MapCGLToRemote.Parsing
{
    public class RunDefParser
    {
        public RunDef[] Parse(string FilePath)
        {
            var RunEngine = new FileHelperEngine<RunDef>();

            var RunDefList = RunEngine.ReadFile(FilePath + "RunDefConfig.csv");

            return RunDefList;
        }
    }
}
