using FileHelpers;

namespace MapCGLToRemote.InputModels
{
    [DelimitedRecord(",")]
    public class RunDef
    {
        public string LegacyDeviceName;
        public string RunNumber;
        public string SiteID;
        public string MeterID;
        public string TubeID;
        public string MeterSet;
        public string MSType;
    }
}
