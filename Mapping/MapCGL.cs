using MapCGLToRemote.OutputModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MapCGLToRemote.Mapping
{
    public class MapCGL
    {
        public List<string> RemotesWithSameRuns = new List<string>();
        public List<CGL> Map(List<RemoteConfig> remoteConfigs, Dictionary<string, string> rtuNames, Dictionary<string, string> devices)
        {
            var CGLList = new List<CGL>();

            foreach (var rtu in rtuNames)
            {
                var configs = new List<RemoteConfig>();
                configs = remoteConfigs.Where(i => i.LegacyName == rtu.Key)
                          .Where(i => i.ConfigName.Contains("AGA")).ToList();

                var cgl = new CGL();
                cgl.OASySName = rtu.Value;
                cgl.RTUName = rtu.Key;
                cgl.DeviceType = Helper.ShortenDeviceTypeName(devices[rtu.Value]);

                foreach (var c in configs)
                {
                    if (c.HourlyRow == "840")
                    {
                        switch (c.RunNumber)
                        {
                            case "1":
                                if(cgl.Hourly1Register.Equals(""))
                                {
                                    cgl.Hourly1AGA = c.ConfigName;
                                    cgl.Hourly1Array = c.HourlyTable;
                                    cgl.Hourly1Register = c.HourlyRegister;
                                    cgl.Hourly1Size = c.HourlyRow;
                                    break;
                                }
                                else
                                {
                                    if(!RemotesWithSameRuns.Contains(cgl.OASySName))
                                    {
                                        RemotesWithSameRuns.Add(cgl.OASySName);
                                    }
                                    Console.WriteLine($"{cgl.OASySName} already contains a value for {c.RunNumber}!");
                                    break;
                                }
                            case "2":
                                if(cgl.Hourly2Register.Equals(""))
                                {
                                    cgl.Hourly2AGA = c.ConfigName;
                                    cgl.Hourly2Array = c.HourlyTable;
                                    cgl.Hourly2Register = c.HourlyRegister;
                                    cgl.Hourly2Size = c.HourlyRow;
                                    break;
                                }
                                else
                                {
                                    if (!RemotesWithSameRuns.Contains(cgl.OASySName))
                                    {
                                        RemotesWithSameRuns.Add(cgl.OASySName);
                                    }
                                    Console.WriteLine($"{cgl.OASySName} already contains a value for {c.RunNumber}!");
                                    break;
                                }
                            case "3":
                                if(cgl.Hourly3Register.Equals(""))
                                {
                                    cgl.Hourly3AGA = c.ConfigName;
                                    cgl.Hourly3Array = c.HourlyTable;
                                    cgl.Hourly3Register = c.HourlyRegister;
                                    cgl.Hourly3Size = c.HourlyRow;
                                    break;
                                }
                                else
                                {
                                    if (!RemotesWithSameRuns.Contains(cgl.OASySName))
                                    {
                                        RemotesWithSameRuns.Add(cgl.OASySName);
                                    }
                                    Console.WriteLine($"{cgl.OASySName} already contains a value for {c.RunNumber}!");
                                    break;
                                }
                            case "4":
                                if(cgl.Hourly4Register.Equals(""))
                                {
                                    cgl.Hourly4AGA = c.ConfigName;
                                    cgl.Hourly4Array = c.HourlyTable;
                                    cgl.Hourly4Register = c.HourlyRegister;
                                    cgl.Hourly4Size = c.HourlyRow;
                                    break;
                                }
                                else
                                {
                                    if (!RemotesWithSameRuns.Contains(cgl.OASySName))
                                    {
                                        RemotesWithSameRuns.Add(cgl.OASySName);
                                    }
                                    Console.WriteLine($"{cgl.OASySName} already contains a value for {c.RunNumber}!");
                                    break;
                                }
                            case "5":
                                if(cgl.Hourly5Register.Equals(""))
                                {
                                    cgl.Hourly5AGA = c.ConfigName;
                                    cgl.Hourly5Array = c.HourlyTable;
                                    cgl.Hourly5Register = c.HourlyRegister;
                                    cgl.Hourly5Size = c.HourlyRow;
                                    break;
                                }
                                else
                                {
                                    if (!RemotesWithSameRuns.Contains(cgl.OASySName))
                                    {
                                        RemotesWithSameRuns.Add(cgl.OASySName);
                                    }
                                    Console.WriteLine($"{cgl.OASySName} already contains a value for {c.RunNumber}!");
                                    break;
                                }
                            case "6":
                                if(cgl.Hourly6Register.Equals(""))
                                {
                                    cgl.Hourly6AGA = c.ConfigName;
                                    cgl.Hourly6Array = c.HourlyTable;
                                    cgl.Hourly6Register = c.HourlyRegister;
                                    cgl.Hourly6Size = c.HourlyRow;
                                    break;
                                }
                                else
                                {
                                    if (!RemotesWithSameRuns.Contains(cgl.OASySName))
                                    {
                                        RemotesWithSameRuns.Add(cgl.OASySName);
                                    }
                                    Console.WriteLine($"{cgl.OASySName} already contains a value for {c.RunNumber}!");
                                    break;
                                }
                            case "7":
                                if(cgl.Hourly7Register.Equals(""))
                                {
                                    cgl.Hourly7AGA = c.ConfigName;
                                    cgl.Hourly7Array = c.HourlyTable;
                                    cgl.Hourly7Register = c.HourlyRegister;
                                    cgl.Hourly7Size = c.HourlyRow;
                                    break;
                                }
                                else
                                {
                                    if (!RemotesWithSameRuns.Contains(cgl.OASySName))
                                    {
                                        RemotesWithSameRuns.Add(cgl.OASySName);
                                    }
                                    Console.WriteLine($"{cgl.OASySName} already contains a value for {c.RunNumber}!");
                                    break;
                                }
                            case "8":
                                if(cgl.Hourly8Register.Equals(""))
                                {
                                    cgl.Hourly8AGA = c.ConfigName;
                                    cgl.Hourly8Array = c.HourlyTable;
                                    cgl.Hourly8Register = c.HourlyRegister;
                                    cgl.Hourly8Size = c.HourlyRow;
                                    break;
                                }
                                else
                                {
                                    if (!RemotesWithSameRuns.Contains(cgl.OASySName))
                                    {
                                        RemotesWithSameRuns.Add(cgl.OASySName);
                                    }
                                    Console.WriteLine($"{cgl.OASySName} already contains a value for {c.RunNumber}!");
                                    break;
                                }
                            case "9":
                                if (cgl.Hourly9Register.Equals(""))
                                {
                                    cgl.Hourly9AGA = c.ConfigName;
                                    cgl.Hourly9Array = c.HourlyTable;
                                    cgl.Hourly9Register = c.HourlyRegister;
                                    cgl.Hourly9Size = c.HourlyRow;
                                    break;
                                }
                                else
                                {
                                    if (!RemotesWithSameRuns.Contains(cgl.OASySName))
                                    {
                                        RemotesWithSameRuns.Add(cgl.OASySName);
                                    }
                                    Console.WriteLine($"{cgl.OASySName} already contains a value for {c.RunNumber}!");
                                    break;
                                }
                            default:
                                break;
                        }
                    }
                    else
                    {
                        switch (c.RunNumber)
                        {
                            case "1":
                                cgl.Daily1AGA = c.ConfigName;
                                cgl.Daily1Array = c.HourlyTable;
                                cgl.Daily1Register = c.HourlyRegister;
                                cgl.Daily1Size = c.HourlyRow;
                                break;
                            case "2":
                                cgl.Daily2AGA = c.ConfigName;
                                cgl.Daily2Array = c.HourlyTable;
                                cgl.Daily2Register = c.HourlyRegister;
                                cgl.Daily2Size = c.HourlyRow;
                                break;
                            case "3":
                                cgl.Daily3AGA = c.ConfigName;
                                cgl.Daily3Array = c.HourlyTable;
                                cgl.Daily3Register = c.HourlyRegister;
                                cgl.Daily3Size = c.HourlyRow;
                                break;
                            case "4":
                                cgl.Daily4AGA = c.ConfigName;
                                cgl.Daily4Array = c.HourlyTable;
                                cgl.Daily4Register = c.HourlyRegister;
                                cgl.Daily4Size = c.HourlyRow;
                                break;
                            case "5":
                                cgl.Daily5AGA = c.ConfigName;
                                cgl.Daily5Array = c.HourlyTable;
                                cgl.Daily5Register = c.HourlyRegister;
                                cgl.Daily5Size = c.HourlyRow;
                                break;
                            case "6":
                                cgl.Daily6AGA = c.ConfigName;
                                cgl.Daily6Array = c.HourlyTable;
                                cgl.Daily6Register = c.HourlyRegister;
                                cgl.Daily6Size = c.HourlyRow;
                                break;
                            case "7":
                                cgl.Daily7AGA = c.ConfigName;
                                cgl.Daily7Array = c.HourlyTable;
                                cgl.Daily7Register = c.HourlyRegister;
                                cgl.Daily7Size = c.HourlyRow;
                                break;
                            case "8":
                                cgl.Daily8AGA = c.ConfigName;
                                cgl.Daily8Array = c.HourlyTable;
                                cgl.Daily8Register = c.HourlyRegister;
                                cgl.Daily8Size = c.HourlyRow;
                                break;
                            case "9":
                                cgl.Daily9AGA = c.ConfigName;
                                cgl.Daily9Array = c.HourlyTable;
                                cgl.Daily9Register = c.HourlyRegister;
                                cgl.Daily9Size = c.HourlyRow;
                                break;
                            default:
                                break;
                        }
                    }
                }
                if(cgl.CheckIfRemoteHasMeasurementData())
                {
                    CGLList.Add(cgl);
                } 
            }
            return CGLList;
        }
    }
}
