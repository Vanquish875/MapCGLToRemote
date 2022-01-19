using MapCGLToRemote.InputModels;
using MapCGLToRemote.OutputModels;
using System.Collections.Generic;
using System.Linq;

namespace MapCGLToRemote.Mapping
{
    public class MapRunDef
    {
        public List<RemoteRunDevice> MapEGMMeters(RunDef[] rundef, Dictionary<string, string> RTUName)
        {
            var EGMMeterList = new List<RemoteRunDevice>();

            foreach (var rtu in RTUName)
            {
                var egmList = rundef.Where(i => i.LegacyDeviceName.Trim() == rtu.Key).ToList();

                var egmdevice = new RemoteRunDevice();

                egmdevice.RemoteName = rtu.Value;

                foreach (var run in egmList)
                {
                    var tubeID = "";
                    if (run.TubeID.Equals("1") || run.TubeID.Equals("2") || run.TubeID.Equals("3") || run.TubeID.Equals("4"))
                    {
                        tubeID = "-0" + run.TubeID.Trim();
                    }
                    else
                    {
                        tubeID = "-" + run.TubeID.Trim();
                    }
                    switch (run.RunNumber)
                    {
                        case "1":
                            egmdevice.MeterRun1 = run.MeterID + tubeID;
                            egmdevice.GQRun1 = run.MeterID + tubeID;
                            break;
                        case "2":
                            egmdevice.MeterRun2 = run.MeterID + tubeID;
                            egmdevice.GQRun2 = run.MeterID + tubeID;
                            break;
                        case "3":
                            egmdevice.MeterRun3 = run.MeterID + tubeID;
                            egmdevice.GQRun3 = run.MeterID + tubeID;
                            break;
                        case "4":
                            egmdevice.MeterRun4 = run.MeterID + tubeID;
                            egmdevice.GQRun4 = run.MeterID + tubeID;
                            break;
                        case "5":
                            egmdevice.MeterRun5 = run.MeterID + tubeID;
                            egmdevice.GQRun5 = run.MeterID + tubeID;
                            break;
                        case "6":
                            egmdevice.MeterRun6 = run.MeterID + tubeID;
                            egmdevice.GQRun6 = run.MeterID + tubeID;
                            break;
                        case "7":
                            egmdevice.MeterRun7 = run.MeterID + tubeID;
                            egmdevice.GQRun7 = run.MeterID + tubeID;
                            break;
                        case "8":
                            egmdevice.MeterRun8 = run.MeterID + tubeID;
                            egmdevice.GQRun8 = run.MeterID + tubeID;
                            break;
                        case "9":
                            egmdevice.MeterRun9 = run.MeterID + tubeID;
                            egmdevice.GQRun9 = run.MeterID + tubeID;
                            break;
                    }
                }
                if (egmdevice.IsRemoteDeviceNotEmpty())
                {
                    EGMMeterList.Add(egmdevice);
                }
            }
            return EGMMeterList;
        }
    }
}
