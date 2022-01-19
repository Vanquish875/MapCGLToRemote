using System.Collections.Generic;

namespace MapCGLToRemote
{
    public class Helper
    {
        public static bool CheckFields(string line, string field)
        {
            if (line.StartsWith(field))
                return true;

            return false;
        }

        public static string CleanFieldString(string line, string field)
        {
            return RemoveWhiteSpace(line.Replace(field, ""));
        }

        public static string RemoveWhiteSpace(string input)
        {
            return input.Trim();
        }

        public static bool CheckIfCorrectTemplateName(string name)
        {
            if (name.Equals("Upload.METER.Periodic.HOURLY.Run[01].DPPLoadType") || name.Equals("Upload.METER.Periodic.HOURLY.Run[01].Data.RecordLast") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[01].Data.RegRW") || name.Equals("Upload.METER.Periodic.HOURLY.Run[01].Index.RegRW") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[01].Data.NumRegs") || name.Equals("Upload.METER.Periodic.HOURLY.Run[01].PointNum") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[01].RTU.Index") || name.Equals("Upload.METER.Periodic.HOURLY.Run[01].RTU.HasSplitHours") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[01].DPPLoadType") || name.Equals("Upload.METER.Periodic.DAILY.Run[01].Data.RecordLast") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[01].Data.RegRW") || name.Equals("Upload.METER.Periodic.DAILY.Run[01].Index.RegRW") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[01].Data.NumRegs") || name.Equals("Upload.METER.Periodic.DAILY.Run[01].PointNum") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[01].RTU.Index") || name.Equals("Upload.METER.Periodic.DAILY.Run[01].RTU.HasSplitHours") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[02].DPPLoadType") || name.Equals("Upload.METER.Periodic.HOURLY.Run[02].Data.RecordLast") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[02].Data.RegRW") || name.Equals("Upload.METER.Periodic.HOURLY.Run[02].Index.RegRW") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[02].Data.NumRegs") || name.Equals("Upload.METER.Periodic.HOURLY.Run[02].PointNum") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[02].RTU.Index") || name.Equals("Upload.METER.Periodic.HOURLY.Run[02].RTU.HasSplitHours") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[02].DPPLoadType") || name.Equals("Upload.METER.Periodic.DAILY.Run[02].Data.RecordLast") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[02].Data.RegRW") || name.Equals("Upload.METER.Periodic.DAILY.Run[02].Index.RegRW") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[02].Data.NumRegs") || name.Equals("Upload.METER.Periodic.DAILY.Run[02].PointNum") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[02].RTU.Index") || name.Equals("Upload.METER.Periodic.DAILY.Run[02].RTU.HasSplitHours") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[03].DPPLoadType") || name.Equals("Upload.METER.Periodic.HOURLY.Run[03].Data.RecordLast") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[03].Data.RegRW") || name.Equals("Upload.METER.Periodic.HOURLY.Run[03].Index.RegRW") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[03].Data.NumRegs") || name.Equals("Upload.METER.Periodic.HOURLY.Run[03].PointNum") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[03].RTU.Index") || name.Equals("Upload.METER.Periodic.HOURLY.Run[03].RTU.HasSplitHours") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[03].DPPLoadType") || name.Equals("Upload.METER.Periodic.DAILY.Run[03].Data.RecordLast") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[03].Data.RegRW") || name.Equals("Upload.METER.Periodic.DAILY.Run[03].Index.RegRW") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[03].Data.NumRegs") || name.Equals("Upload.METER.Periodic.DAILY.Run[03].PointNum") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[03].RTU.Index") || name.Equals("Upload.METER.Periodic.DAILY.Run[03].RTU.HasSplitHours") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[04].DPPLoadType") || name.Equals("Upload.METER.Periodic.HOURLY.Run[04].Data.RecordLast") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[04].Data.RegRW") || name.Equals("Upload.METER.Periodic.HOURLY.Run[04].Index.RegRW") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[04].Data.NumRegs") || name.Equals("Upload.METER.Periodic.HOURLY.Run[04].PointNum") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[04].RTU.Index") || name.Equals("Upload.METER.Periodic.HOURLY.Run[04].RTU.HasSplitHours") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[04].DPPLoadType") || name.Equals("Upload.METER.Periodic.DAILY.Run[04].Data.RecordLast") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[04].Data.RegRW") || name.Equals("Upload.METER.Periodic.DAILY.Run[04].Index.RegRW") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[04].Data.NumRegs") || name.Equals("Upload.METER.Periodic.DAILY.Run[04].PointNum") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[04].RTU.Index") || name.Equals("Upload.METER.Periodic.DAILY.Run[04].RTU.HasSplitHours") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[05].DPPLoadType") || name.Equals("Upload.METER.Periodic.HOURLY.Run[05].Data.RecordLast") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[05].Data.RegRW") || name.Equals("Upload.METER.Periodic.HOURLY.Run[05].Index.RegRW") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[05].Data.NumRegs") || name.Equals("Upload.METER.Periodic.HOURLY.Run[05].PointNum") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[05].RTU.Index") || name.Equals("Upload.METER.Periodic.HOURLY.Run[05].RTU.HasSplitHours") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[05].DPPLoadType") || name.Equals("Upload.METER.Periodic.DAILY.Run[05].Data.RecordLast") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[05].Data.RegRW") || name.Equals("Upload.METER.Periodic.DAILY.Run[05].Index.RegRW") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[05].Data.NumRegs") || name.Equals("Upload.METER.Periodic.DAILY.Run[05].PointNum") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[05].RTU.Index") || name.Equals("Upload.METER.Periodic.DAILY.Run[05].RTU.HasSplitHours") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[06].DPPLoadType") || name.Equals("Upload.METER.Periodic.HOURLY.Run[06].Data.RecordLast") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[06].Data.RegRW") || name.Equals("Upload.METER.Periodic.HOURLY.Run[06].Index.RegRW") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[06].Data.NumRegs") || name.Equals("Upload.METER.Periodic.HOURLY.Run[06].PointNum") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[06].RTU.Index") || name.Equals("Upload.METER.Periodic.HOURLY.Run[06].RTU.HasSplitHours") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[06].DPPLoadType") || name.Equals("Upload.METER.Periodic.DAILY.Run[06].Data.RecordLast") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[06].Data.RegRW") || name.Equals("Upload.METER.Periodic.DAILY.Run[06].Index.RegRW") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[06].Data.NumRegs") || name.Equals("Upload.METER.Periodic.DAILY.Run[06].PointNum") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[06].RTU.Index") || name.Equals("Upload.METER.Periodic.DAILY.Run[06].RTU.HasSplitHours") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[07].DPPLoadType") || name.Equals("Upload.METER.Periodic.HOURLY.Run[07].Data.RecordLast") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[07].Data.RegRW") || name.Equals("Upload.METER.Periodic.HOURLY.Run[07].Index.RegRW") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[07].Data.NumRegs") || name.Equals("Upload.METER.Periodic.HOURLY.Run[07].PointNum") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[07].RTU.Index") || name.Equals("Upload.METER.Periodic.HOURLY.Run[07].RTU.HasSplitHours") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[07].DPPLoadType") || name.Equals("Upload.METER.Periodic.DAILY.Run[07].Data.RecordLast") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[07].Data.RegRW") || name.Equals("Upload.METER.Periodic.DAILY.Run[07].Index.RegRW") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[07].Data.NumRegs") || name.Equals("Upload.METER.Periodic.DAILY.Run[07].PointNum") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[07].RTU.Index") || name.Equals("Upload.METER.Periodic.DAILY.Run[07].RTU.HasSplitHours") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[08].DPPLoadType") || name.Equals("Upload.METER.Periodic.HOURLY.Run[08].Data.RecordLast") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[08].Data.RegRW") || name.Equals("Upload.METER.Periodic.HOURLY.Run[08].Index.RegRW") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[08].Data.NumRegs") || name.Equals("Upload.METER.Periodic.HOURLY.Run[08].PointNum") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[08].RTU.Index") || name.Equals("Upload.METER.Periodic.HOURLY.Run[08].RTU.HasSplitHours") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[08].DPPLoadType") || name.Equals("Upload.METER.Periodic.DAILY.Run[08].Data.RecordLast") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[08].Data.RegRW") || name.Equals("Upload.METER.Periodic.DAILY.Run[08].Index.RegRW") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[08].Data.NumRegs") || name.Equals("Upload.METER.Periodic.DAILY.Run[08].PointNum") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[08].RTU.Index") || name.Equals("Upload.METER.Periodic.DAILY.Run[08].RTU.HasSplitHours") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[09].DPPLoadType") || name.Equals("Upload.METER.Periodic.HOURLY.Run[09].Data.RecordLast") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[09].Data.RegRW") || name.Equals("Upload.METER.Periodic.HOURLY.Run[09].Index.RegRW") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[09].Data.NumRegs") || name.Equals("Upload.METER.Periodic.HOURLY.Run[09].PointNum") ||
                name.Equals("Upload.METER.Periodic.HOURLY.Run[09].RTU.Index") || name.Equals("Upload.METER.Periodic.HOURLY.Run[09].RTU.HasSplitHours") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[09].DPPLoadType") || name.Equals("Upload.METER.Periodic.DAILY.Run[09].Data.RecordLast") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[09].Data.RegRW") || name.Equals("Upload.METER.Periodic.DAILY.Run[09].Index.RegRW") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[09].Data.NumRegs") || name.Equals("Upload.METER.Periodic.DAILY.Run[09].PointNum") ||
                name.Equals("Upload.METER.Periodic.DAILY.Run[09].RTU.Index") || name.Equals("Upload.METER.Periodic.DAILY.Run[09].RTU.HasSplitHours") ||
                name.Equals("Download.METER.Parameter.GQ.Run[01].Set[01].Data.RegRW") || name.Equals("Download.METER.Parameter.GQ.Run[01].Set[02].Data.RegRW") ||
                name.Equals("Download.METER.Parameter.GQ.Run[02].Set[01].Data.RegRW") || name.Equals("Download.METER.Parameter.GQ.Run[02].Set[02].Data.RegRW") ||
                name.Equals("Download.METER.Parameter.GQ.Run[01].Set[01].PointNum") || name.Equals("Download.METER.Parameter.GQ.Run[01].Set[02].PointNum") ||
                name.Equals("Download.METER.Parameter.GQ.Run[02].Set[01].PointNum") || name.Equals("Download.METER.Parameter.GQ.Run[02].Set[02].PointNum") ||
                name.Equals("Download.METER.Parameter.GQ.Run[01].SetNum") || name.Equals("Download.METER.Parameter.GQ.Run[02].SetNum") ||
                name.Equals("Download.METER.Parameter.GQ.Run[01].Set[01].Point[01]") || name.Equals("Download.METER.Parameter.GQ.Run[01].Set[01].Point[02]") ||
                name.Equals("Download.METER.Parameter.GQ.Run[01].Set[01].Point[03]") || name.Equals("Download.METER.Parameter.GQ.Run[01].Set[01].Point[04]") ||
                name.Equals("Download.METER.Parameter.GQ.Run[01].Set[01].Point[05]") || name.Equals("Download.METER.Parameter.GQ.Run[01].Set[01].Point[06]") ||
                name.Equals("Download.METER.Parameter.GQ.Run[01].Set[01].Point[07]") || name.Equals("Download.METER.Parameter.GQ.Run[01].Set[01].Point[08]") ||
                name.Equals("Download.METER.Parameter.GQ.Run[01].Set[01].Point[09]") || name.Equals("Download.METER.Parameter.GQ.Run[01].Set[01].Point[10]") ||
                name.Equals("Download.METER.Parameter.GQ.Run[01].Set[01].Point[11]") || name.Equals("Download.METER.Parameter.GQ.Run[01].Set[01].Point[12]") ||
                name.Equals("Download.METER.Parameter.GQ.Run[01].Set[01].Point[13]") || name.Equals("Download.METER.Parameter.GQ.Run[01].Set[01].Point[14]") ||
                name.Equals("Download.METER.Parameter.GQ.Run[01].Set[01].Point[15]") || name.Equals("Download.METER.Parameter.GQ.Run[01].Set[01].Point[16]") ||
                name.Equals("Download.METER.Parameter.GQ.Run[01].Set[01].Point[17]") || name.Equals("Download.METER.Parameter.GQ.Run[01].Set[01].Point[18]") ||
                name.Equals("Download.METER.Parameter.GQ.Run[01].Set[01].Point[19]") || name.Equals("Download.METER.Parameter.GQ.Run[01].Set[01].Point[20]") ||
                name.Equals("Download.METER.Parameter.GQ.Run[01].Set[01].Point[21]") || name.Equals("Download.METER.Parameter.GQ.Run[01].Set[01].Point[22]") ||
                name.Equals("Download.METER.Parameter.GQ.Run[01].Set[01].Point[23]") || name.Equals("Download.METER.Parameter.GQ.Run[01].Set[01].Point[24]") ||
                name.Equals("Download.METER.Parameter.GQ.Run[01].Set[01].Point[25]") || name.Equals("Download.METER.Parameter.GQ.Run[02].Set[01].Point[01]") ||
                name.Equals("Download.METER.Parameter.GQ.Run[02].Set[01].Point[02]") || name.Equals("Download.METER.Parameter.GQ.Run[02].Set[01].Point[03]") ||
                name.Equals("Download.METER.Parameter.GQ.Run[02].Set[01].Point[04]") || name.Equals("Download.METER.Parameter.GQ.Run[02].Set[01].Point[05]") ||
                name.Equals("Download.METER.Parameter.GQ.Run[02].Set[01].Point[06]") || name.Equals("Download.METER.Parameter.GQ.Run[02].Set[01].Point[07]") ||
                name.Equals("Download.METER.Parameter.GQ.Run[02].Set[01].Point[08]") || name.Equals("Download.METER.Parameter.GQ.Run[02].Set[01].Point[09]") ||
                name.Equals("Download.METER.Parameter.GQ.Run[02].Set[01].Point[10]") || name.Equals("Download.METER.Parameter.GQ.Run[02].Set[01].Point[11]") ||
                name.Equals("Download.METER.Parameter.GQ.Run[02].Set[01].Point[12]") || name.Equals("Download.METER.Parameter.GQ.Run[02].Set[01].Point[13]") ||
                name.Equals("Download.METER.Parameter.GQ.Run[02].Set[01].Point[14]") || name.Equals("Download.METER.Parameter.GQ.Run[02].Set[01].Point[15]") ||
                name.Equals("Download.METER.Parameter.GQ.Run[02].Set[01].Point[16]") || name.Equals("Download.METER.Parameter.GQ.Run[02].Set[01].Point[17]") ||
                name.Equals("Download.METER.Parameter.GQ.Run[02].Set[01].Point[18]") || name.Equals("Download.METER.Parameter.GQ.Run[02].Set[01].Point[19]") ||
                name.Equals("Download.METER.Parameter.GQ.Run[02].Set[01].Point[20]") || name.Equals("Download.METER.Parameter.GQ.Run[02].Set[01].Point[21]") ||
                name.Equals("Download.METER.Parameter.GQ.Run[02].Set[01].Point[22]") || name.Equals("Download.METER.Parameter.GQ.Run[02].Set[01].Point[23]") ||
                name.Equals("Download.METER.Parameter.GQ.Run[02].Set[01].Point[24]") || name.Equals("Download.METER.Parameter.GQ.Run[02].Set[01].Point[25]"))
            {
                return true;
            }

            return false;
        }

        public static string ReturnAGAFromConfigNumber(string configNumber)
        {
            var AGADictionary = new Dictionary<string, string>()
            {
                { "11", "AGA7" },
                { "18", "AGA3" },
                { "19", "AGA11" },
                { "22", "AGA7" }
            };

            return AGADictionary[configNumber];
        }

        public static string ShortenDeviceTypeName(string deviceType)
        {
            if (deviceType.Equals("Bristol ControlWave Micro"))
                return "W";
            if (deviceType.Equals("AutoPILOT"))
                return "P";
            if (deviceType.Equals("AutoPILOT PRO"))
                return "P";

            return "";
        }

        public static string ReturnGQPropertyFromDictionary(string gasmeter)
        {
            var GQDictionary = new Dictionary<string, string>()
            {
                { "<KG::GASMETER><DOUBLE><FLOAT><100>", "Heating value" },
                { "<KG::GASMETER><DOUBLE><FLOAT><101>", "Specific Gravity" },
                { "<KG::GASMETER><DOUBLE><FLOAT><102>", "N2" },
                { "<KG::GASMETER><DOUBLE><FLOAT><103>", "CO2" },
                { "<KG::GASMETER><DOUBLE><FLOAT><104>", "H2" },
                { "<KG::GASMETER><DOUBLE><FLOAT><106>", "H2S" },
                { "<KG::GASMETER><DOUBLE><FLOAT><107>", "H2O" },
                { "<KG::GASMETER><DOUBLE><FLOAT><108>", "He" },
                { "<KG::GASMETER><DOUBLE><FLOAT><109>", "O2" },
                { "<KG::GASMETER><DOUBLE><FLOAT><110>", "C1" },
                { "<KG::GASMETER><DOUBLE><FLOAT><111>", "C2" },
                { "<KG::GASMETER><DOUBLE><FLOAT><112>", "C3" },
                { "<KG::GASMETER><DOUBLE><FLOAT><113>", "NC4" },
                { "<KG::GASMETER><DOUBLE><FLOAT><114>", "IC4" },
                { "<KG::GASMETER><DOUBLE><FLOAT><115>", "NC5" },
                { "<KG::GASMETER><DOUBLE><FLOAT><116>", "IC5" },
                { "<KG::GASMETER><DOUBLE><FLOAT><117>", "C6" },
                { "<KG::GASMETER><DOUBLE><FLOAT><118>", "C7" },
                { "<KG::GASMETER><DOUBLE><FLOAT><119>", "C8" },
                { "<KG::GASMETER><DOUBLE><FLOAT><120>", "C9" },
                { "<KG::GASMETER><DOUBLE><FLOAT><121>", "C10" },
                { "<KG::GASMETER><DOUBLE><FLOAT><122>", "Dewpoint" },
                { "<KG::GASMETER><DOUBLE><FLOAT><124>", "C6 Plus" },
                { "<KG::GASMETER><DOUBLE><FLOAT><126>", "AR" },
                { "<KG::GASMETER><DOUBLE><FLOAT><127>", "CO" },
                { "<KG::GASMETER><DOUBLE><FLOAT><130>", "Viscosity" },
                { "<KG::GASMETER><DOUBLE><FLOAT><0>", "" }
            };

            return GQDictionary[gasmeter];
        }
    }
}
