using MapCGLToRemote.InputModels;
using MapCGLToRemote.OutputModels;
using System.Collections.Generic;
using System.Linq;

namespace MapCGLToRemote.Mapping
{
    public class MapEGMMeter
    {
        public List<RemoteRunDevice> MapMetersToRuns(EGMConfig[] egmdata, Dictionary<string, string> RTUName)
        {
            var EGMMeterList = new List<RemoteRunDevice>();

            foreach(var rtu in RTUName)
            {
                var egmList = egmdata.Where(i => i.LegacyDeviceName.Trim() == rtu.Key).ToList();

                var egmdevice = new RemoteRunDevice();

                egmdevice.RemoteName = rtu.Value;

                foreach(var egm in egmList)
                {
                    var tubeID = "";
                    if(egm.TubeID.Equals("1") || egm.TubeID.Equals("2") || egm.TubeID.Equals("3") || egm.TubeID.Equals("4"))
                    {
                        tubeID = "-0" + egm.TubeID.Trim();
                    }
                    else
                    {
                        tubeID = "-" + egm.TubeID.Trim();
                    }
                    switch (egm.RunNumber)
                    {
                        case "1":
                            if(egm.TranPeriod.Equals("H"))
                            {
                                egmdevice.MeterRun1 = egm.ACMeterID + tubeID;
                                egmdevice.GQRun1 = egm.ACMeterID + tubeID;
                            }
                            break;
                        case "2":
                            if(egm.TranPeriod.Equals("H"))
                            {
                                egmdevice.MeterRun2 = egm.ACMeterID + tubeID;
                                egmdevice.GQRun2 = egm.ACMeterID + tubeID;
                            }
                            break;
                        case "3":
                            if(egm.TranPeriod.Equals("H"))
                            {
                                egmdevice.MeterRun3 = egm.ACMeterID + tubeID;
                                egmdevice.GQRun3 = egm.ACMeterID + tubeID;
                            }
                            break;
                        case "4":
                            if(egm.TranPeriod.Equals("H"))
                            {
                                egmdevice.MeterRun4 = egm.ACMeterID + tubeID;
                                egmdevice.GQRun4 = egm.ACMeterID + tubeID;
                            }
                            break;
                        case "5":
                            if(egm.TranPeriod.Equals("H"))
                            {
                                egmdevice.MeterRun5 = egm.ACMeterID + tubeID;
                                egmdevice.GQRun5 = egm.ACMeterID + tubeID;
                            }
                            break;
                        case "6":
                            if(egm.TranPeriod.Equals("H"))
                            {
                                egmdevice.MeterRun6 = egm.ACMeterID + tubeID;
                                egmdevice.GQRun6 = egm.ACMeterID + tubeID;
                            }
                            break;
                        case "7":
                            if(egm.TranPeriod.Equals("H"))
                            {
                                egmdevice.MeterRun7 = egm.ACMeterID + tubeID;
                                egmdevice.GQRun7 = egm.ACMeterID + tubeID;
                            }
                            break;
                        case "8": 
                            if(egm.TranPeriod.Equals("H"))
                            {
                                egmdevice.MeterRun8 = egm.ACMeterID + tubeID;
                                egmdevice.GQRun8 = egm.ACMeterID + tubeID;
                            }
                            break;
                        case "9":
                            if (egm.TranPeriod.Equals("H"))
                            {
                                egmdevice.MeterRun9 = egm.ACMeterID + tubeID;
                                egmdevice.GQRun9 = egm.ACMeterID + tubeID;
                            }
                            break;
                    }
                }
                if(egmdevice.IsRemoteDeviceNotEmpty())
                {
                    EGMMeterList.Add(egmdevice);
                }
            }
            return EGMMeterList;
        }
    }
}
