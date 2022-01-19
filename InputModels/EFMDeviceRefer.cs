using FileHelpers;

namespace MapCGLToRemote.InputModels
{
    [DelimitedRecord(",")]
    public class EFMDeviceRefer
    {
        public string RemoteName;
        public string ObjectName;
        public string ObjectType;
        public string ObjectID;
        public string DeviceLocation;
    }
}
