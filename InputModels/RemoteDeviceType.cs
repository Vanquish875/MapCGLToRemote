using FileHelpers;

namespace MapCGLToRemote.InputModels
{
    [DelimitedRecord(",")]
    public class RemoteDeviceType
    {
        public string RemoteName;
        public string DeviceType;
    }
}
