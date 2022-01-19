using FileHelpers;

namespace MapCGLToRemote.InputModels
{
    [DelimitedRecord(",")]
    public class EGMConfig
    {
        public string LegacyDeviceName;
        public string TableNumber;
        public string ConfigNumber;
        //public string TranType;
        public string TranPeriod;
        //public string FlowTimeUnits;
        public string ContractTime;
        public string Org;
        public string ACMeterID;
        public string TubeID;
        //public string StreamID;
        public string RunNumber;
        public string AliasName;
        //public string DateFormat;
        //public string TimeFormat;
        //public string PMTagName;
        public string PMRegister;
        public string MaxRowNumber;
        //public string IsEnabled;
        //public string IsStack;
        //public string IsSubday;
        //public string IsTopOfPeriod;
    }
}
