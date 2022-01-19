namespace MapCGLToRemote.OutputModels
{
    public class RemoteRunDevice
    {
        public string RemoteName { get; set; } = "";
        public string MeterRun1 { get; set; } = "";
        public string GQRun1 { get; set; } = "";
        public string MeterRun2 { get; set; } = "";
        public string GQRun2 { get; set; } = "";
        public string MeterRun3 { get; set; } = "";
        public string GQRun3 { get; set; } = "";
        public string MeterRun4 { get; set; } = "";
        public string GQRun4 { get; set; } = "";
        public string MeterRun5 { get; set; } = "";
        public string GQRun5 { get; set; } = "";
        public string MeterRun6 { get; set; } = "";
        public string GQRun6 { get; set; } = "";
        public string MeterRun7 { get; set; } = "";
        public string GQRun7 { get; set; } = "";
        public string MeterRun8 { get; set; } = "";
        public string GQRun8 { get; set; } = "";
        public string MeterRun9 { get; set; } = "";
        public string GQRun9 { get; set; } = "";

        public bool IsRemoteDeviceNotEmpty()
        {
            if(MeterRun1.Equals("") && GQRun1.Equals("") && MeterRun2.Equals("") && GQRun2.Equals("") && MeterRun3.Equals("") && GQRun3.Equals("") &&
                MeterRun4.Equals("") && GQRun4.Equals("") && MeterRun5.Equals("") && GQRun5.Equals("") && MeterRun6.Equals("") && GQRun6.Equals("") &&
                MeterRun7.Equals("") && GQRun7.Equals("") && MeterRun8.Equals("") && GQRun8.Equals("") && MeterRun9.Equals("") && GQRun9.Equals(""))
            {
                return false;
            }

            return true;
        }
    }
}
