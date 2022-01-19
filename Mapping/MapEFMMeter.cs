using MapCGLToRemote.InputModels;
using MapCGLToRemote.OutputModels;
using System.Collections.Generic;
using System.Linq;

namespace MapCGLToRemote.Mapping
{
    public class MapEFMMeter
    {
        public List<RemoteRunDevice> MapMetersToRuns(EFMDeviceRefer[] efmdata, List<RemoteRunDevice> egmdata)
        {
            var EFMRemoteDeviceList = new List<RemoteRunDevice>();

            foreach (var rtu in egmdata)
            {
                var efmList = efmdata.Where(i => i.RemoteName == rtu.RemoteName).ToList();

                var remoteRunDevice = new RemoteRunDevice();

                remoteRunDevice.RemoteName = rtu.RemoteName;
                
                foreach(var efm in efmList)
                {
                    switch(efm.DeviceLocation)
                    {
                        case "1":
                            if(efm.ObjectType.Equals("Meter"))
                            {
                                remoteRunDevice.MeterRun1 = efm.ObjectName;
                            }
                            if(efm.ObjectType.Equals("Gas Quality"))
                            {
                                remoteRunDevice.GQRun1 = efm.ObjectName;
                            }
                            break;
                        case "2":
                            if (efm.ObjectType.Equals("Meter"))
                            {
                                remoteRunDevice.MeterRun2 = efm.ObjectName;
                            }
                            if (efm.ObjectType.Equals("Gas Quality"))
                            {
                                remoteRunDevice.GQRun2 = efm.ObjectName;
                            }
                            break;
                        case "3":
                            if (efm.ObjectType.Equals("Meter"))
                            {
                                remoteRunDevice.MeterRun3 = efm.ObjectName;
                            }
                            if (efm.ObjectType.Equals("Gas Quality"))
                            {
                                remoteRunDevice.GQRun3 = efm.ObjectName;
                            }
                            break;
                        case "4":
                            if (efm.ObjectType.Equals("Meter"))
                            {
                                remoteRunDevice.MeterRun4 = efm.ObjectName;
                            }
                            if (efm.ObjectType.Equals("Gas Quality"))
                            {
                                remoteRunDevice.GQRun4 = efm.ObjectName;
                            }
                            break;
                        case "5":
                            if (efm.ObjectType.Equals("Meter"))
                            {
                                remoteRunDevice.MeterRun5 = efm.ObjectName;
                            }
                            if (efm.ObjectType.Equals("Gas Quality"))
                            {
                                remoteRunDevice.GQRun5 = efm.ObjectName;
                            }
                            break;
                        case "6":
                            if (efm.ObjectType.Equals("Meter"))
                            {
                                remoteRunDevice.MeterRun6 = efm.ObjectName;
                            }
                            if (efm.ObjectType.Equals("Gas Quality"))
                            {
                                remoteRunDevice.GQRun6 = efm.ObjectName;
                            }
                            break;
                        case "7":
                            if (efm.ObjectType.Equals("Meter"))
                            {
                                remoteRunDevice.MeterRun7 = efm.ObjectName;
                            }
                            if (efm.ObjectType.Equals("Gas Quality"))
                            {
                                remoteRunDevice.GQRun7 = efm.ObjectName;
                            }
                            break;
                        case "8":
                            if (efm.ObjectType.Equals("Meter"))
                            {
                                remoteRunDevice.MeterRun8 = efm.ObjectName;
                            }
                            if (efm.ObjectType.Equals("Gas Quality"))
                            {
                                remoteRunDevice.GQRun8 = efm.ObjectName;
                            }
                            break;
                        case "9":
                            if (efm.ObjectType.Equals("Meter"))
                            {
                                remoteRunDevice.MeterRun9 = efm.ObjectName;
                            }
                            if (efm.ObjectType.Equals("Gas Quality"))
                            {
                                remoteRunDevice.GQRun9 = efm.ObjectName;
                            }
                            break;
                    }
                }
                EFMRemoteDeviceList.Add(remoteRunDevice);
            }

            return EFMRemoteDeviceList;
        }
    }
}
