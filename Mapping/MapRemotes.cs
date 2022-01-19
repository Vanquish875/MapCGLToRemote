using MapCGLToRemote.InputModels;
using MapCGLToRemote.OutputModels;
using System.Collections.Generic;

namespace MapCGLToRemote.Mapping
{
    public class MapRemotes
    {
        public List<RemoteConfig> LoadRemotes(EGMConfig [] egm, Dictionary<string, string> RTUNames)
        {
            var remoteConfigs = new List<RemoteConfig>();

            foreach(var e in egm)
            {
                if(e.LegacyDeviceName.Contains("GFC"))
                {
                    var remote = new RemoteConfig
                    {
                        OASySName = CheckIfExistsInDictionary(RTUNames, RemoveExtraSpace(e.LegacyDeviceName)),
                        LegacyName = RemoveExtraSpace(e.LegacyDeviceName),
                        HourlyTable = RemoveExtraSpace(e.TableNumber),
                        HourlyRegister = RemoveExtraSpace(e.PMRegister),
                        HourlyRow = RemoveExtraSpace(e.MaxRowNumber),
                        ACMeterID = RemoveExtraSpace(e.ACMeterID),
                        ConfigName = Helper.ReturnAGAFromConfigNumber(RemoveExtraSpace(e.ConfigNumber)),
                        RunNumber = RemoveExtraSpace(e.RunNumber)
                    };
                    remoteConfigs.Add(remote);
                }
            }

            return remoteConfigs;
        }

        public string RemoveExtraSpace(string field)
        {
            return field.Trim();
        }

        public string CheckIfExistsInDictionary(Dictionary<string, string> dictionary, string key)
        {
            bool keyExists = dictionary.ContainsKey(key);
            if(keyExists)
            {
                return dictionary[key];
            }

            return "";
        }
    }
}
