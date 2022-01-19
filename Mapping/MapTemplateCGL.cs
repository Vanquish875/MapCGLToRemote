using MapCGLToRemote.OutputModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MapCGLToRemote.Mapping
{
    public class MapTemplateCGL
    {
        public List<CGLTemplateDef> MapCGLTemplate(List<TemplateDef> data)
        {
            var templates = new List<CGLTemplateDef>();

            try
            {
                var names = data.Select(i => i.TemplateName).Distinct();

                foreach(var name in names)
                {
                    var configs = data.Where(i => i.TemplateName == name);

                    var template = new CGLTemplateDef();
                    template.TemplateName = name;
                    foreach(var config in configs)
                    {
                        switch(config.FieldName)
                        {
                            case "Upload.METER.Periodic.HOURLY.Run[01].DPPLoadType":
                                template.Hourly1AGA = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[01].Data.RecordLast":
                                template.Hourly1Size = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[01].Data.RegRW":
                                template.Hourly1Array = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[01].Index.RegRW":
                                template.Hourly1Register = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[01].Data.NumRegs":
                                template.Hourly1NumRegisters = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[01].PointNum":
                                template.Hourly1PointNumbers = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[01].RTU.Index":
                                template.Hourly1Index = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[01].RTU.HasSplitHours":
                                template.Hourly1HasSplitHours = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[01].DPPLoadType":
                                template.Daily1AGA = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[01].Data.RecordLast":
                                template.Daily1Size = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[01].Data.RegRW":
                                template.Daily1Array = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[01].Index.RegRW":
                                template.Daily1Register = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[01].Data.NumRegs":
                                template.Daily1NumRegisters = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[01].PointNum":
                                template.Daily1PointNumbers = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[01].RTU.Index":
                                template.Daily1Index = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[01].RTU.HasSplitHours":
                                template.Daily1HasSplitHours = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[02].DPPLoadType":
                                template.Hourly2AGA = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[02].Data.RecordLast":
                                template.Hourly2Size = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[02].Data.RegRW":
                                template.Hourly2Array = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[02].Index.RegRW":
                                template.Hourly2Register = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[02].Data.NumRegs":
                                template.Hourly2NumRegisters = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[02].PointNum":
                                template.Hourly2PointNumbers = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[02].RTU.Index":
                                template.Hourly2Index = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[02].RTU.HasSplitHours":
                                template.Hourly2HasSplitHours = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[02].DPPLoadType":
                                template.Daily2AGA = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[02].Data.RecordLast":
                                template.Daily2Size = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[02].Data.RegRW":
                                template.Daily2Array = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[02].Index.RegRW":
                                template.Daily2Register = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[02].Data.NumRegs":
                                template.Daily2NumRegisters = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[02].PointNum":
                                template.Daily2PointNumbers = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[02].RTU.Index":
                                template.Daily2Index = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[02].RTU.HasSplitHours":
                                template.Daily2HasSplitHours = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[03].DPPLoadType":
                                template.Hourly3AGA = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[03].Data.RecordLast":
                                template.Hourly3Size = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[03].Data.RegRW":
                                template.Hourly3Array = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[03].Index.RegRW":
                                template.Hourly3Register = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[03].Data.NumRegs":
                                template.Hourly3NumRegisters = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[03].PointNum":
                                template.Hourly3PointNumbers = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[03].RTU.Index":
                                template.Hourly3Index = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[03].RTU.HasSplitHours":
                                template.Hourly3HasSplitHours = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[03].DPPLoadType":
                                template.Daily3AGA = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[03].Data.RecordLast":
                                template.Daily3Size = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[03].Data.RegRW":
                                template.Daily3Array = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[03].Index.RegRW":
                                template.Daily3Register = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[03].Data.NumRegs":
                                template.Daily3NumRegisters = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[03].PointNum":
                                template.Daily3PointNumbers = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[03].RTU.Index":
                                template.Daily3Index = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[03].RTU.HasSplitHours":
                                template.Daily3HasSplitHours = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[04].DPPLoadType":
                                template.Hourly4AGA = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[04].Data.RecordLast":
                                template.Hourly4Size = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[04].Data.RegRW":
                                template.Hourly4Array = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[04].Index.RegRW":
                                template.Hourly4Register = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[04].Data.NumRegs":
                                template.Hourly4NumRegisters = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[04].PointNum":
                                template.Hourly4PointNumbers = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[04].RTU.Index":
                                template.Hourly4Index = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[04].RTU.HasSplitHours":
                                template.Hourly4HasSplitHours = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[04].DPPLoadType":
                                template.Daily4AGA = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[04].Data.RecordLast":
                                template.Daily4Size = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[04].Data.RegRW":
                                template.Daily4Array = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[04].Index.RegRW":
                                template.Daily4Register = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[04].Data.NumRegs":
                                template.Daily4NumRegisters = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[04].PointNum":
                                template.Daily4PointNumbers = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[04].RTU.Index":
                                template.Daily4Index = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[04].RTU.HasSplitHours":
                                template.Daily4HasSplitHours = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[05].DPPLoadType":
                                template.Hourly5AGA = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[05].Data.RecordLast":
                                template.Hourly5Size = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[05].Data.RegRW":
                                template.Hourly5Array = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[05].Index.RegRW":
                                template.Hourly5Register = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[05].Data.NumRegs":
                                template.Hourly5NumRegisters = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[05].PointNum":
                                template.Hourly5PointNumbers = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[05].RTU.Index":
                                template.Hourly5Index = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[05].RTU.HasSplitHours":
                                template.Hourly5HasSplitHours = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[05].DPPLoadType":
                                template.Daily5AGA = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[05].Data.RecordLast":
                                template.Daily5Size = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[05].Data.RegRW":
                                template.Daily5Array = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[05].Index.RegRW":
                                template.Daily5Register = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[05].Data.NumRegs":
                                template.Daily5NumRegisters = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[05].PointNum":
                                template.Daily5PointNumbers = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[05].RTU.Index":
                                template.Daily5Index = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[05].RTU.HasSplitHours":
                                template.Daily5HasSplitHours = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[06].DPPLoadType":
                                template.Hourly6AGA = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[06].Data.RecordLast":
                                template.Hourly6Size = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[06].Data.RegRW":
                                template.Hourly6Array = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[06].Index.RegRW":
                                template.Hourly6Register = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[06].Data.NumRegs":
                                template.Hourly6NumRegisters = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[06].PointNum":
                                template.Hourly6PointNumbers = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[06].RTU.Index":
                                template.Hourly6Index = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[06].RTU.HasSplitHours":
                                template.Hourly6HasSplitHours = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[06].DPPLoadType":
                                template.Daily6AGA = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[06].Data.RecordLast":
                                template.Daily6Size = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[06].Data.RegRW":
                                template.Daily6Array = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[06].Index.RegRW":
                                template.Daily6Register = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[06].Data.NumRegs":
                                template.Daily6NumRegisters = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[06].PointNum":
                                template.Daily6PointNumbers = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[06].RTU.Index":
                                template.Daily6Index = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[06].RTU.HasSplitHours":
                                template.Daily6HasSplitHours = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[07].DPPLoadType":
                                template.Hourly7AGA = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[07].Data.RecordLast":
                                template.Hourly7Size = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[07].Data.RegRW":
                                template.Hourly7Array = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[07].Index.RegRW":
                                template.Hourly7Register = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[07].Data.NumRegs":
                                template.Hourly7NumRegisters = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[07].PointNum":
                                template.Hourly7PointNumbers = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[07].RTU.Index":
                                template.Hourly7Index = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[07].RTU.HasSplitHours":
                                template.Hourly7HasSplitHours = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[07].DPPLoadType":
                                template.Daily7AGA = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[07].Data.RecordLast":
                                template.Daily7Size = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[07].Data.RegRW":
                                template.Daily7Array = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[07].Index.RegRW":
                                template.Daily7Register = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[07].Data.NumRegs":
                                template.Daily7NumRegisters = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[07].PointNum":
                                template.Daily7PointNumbers = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[07].RTU.Index":
                                template.Daily7Index = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[07].RTU.HasSplitHours":
                                template.Daily7HasSplitHours = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[08].DPPLoadType":
                                template.Hourly8AGA = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[08].Data.RecordLast":
                                template.Hourly8Size = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[08].Data.RegRW":
                                template.Hourly8Array = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[08].Index.RegRW":
                                template.Hourly8Register = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[08].Data.NumRegs":
                                template.Hourly8NumRegisters = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[08].PointNum":
                                template.Hourly8PointNumbers = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[08].RTU.Index":
                                template.Hourly8Index = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[08].RTU.HasSplitHours":
                                template.Hourly8HasSplitHours = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[08].DPPLoadType":
                                template.Daily8AGA = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[08].Data.RecordLast":
                                template.Daily8Size = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[08].Data.RegRW":
                                template.Daily8Array = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[08].Index.RegRW":
                                template.Daily8Register = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[08].Data.NumRegs":
                                template.Daily8NumRegisters = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[08].PointNum":
                                template.Daily8PointNumbers = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[08].RTU.Index":
                                template.Daily8Index = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[08].RTU.HasSplitHours":
                                template.Daily8HasSplitHours = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[09].DPPLoadType":
                                template.Hourly9AGA = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[09].Data.RecordLast":
                                template.Hourly9Size = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[09].Data.RegRW":
                                template.Hourly9Array = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[09].Index.RegRW":
                                template.Hourly9Register = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[09].Data.NumRegs":
                                template.Hourly9NumRegisters = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[09].PointNum":
                                template.Hourly9PointNumbers = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[09].RTU.Index":
                                template.Hourly9Index = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.HOURLY.Run[09].RTU.HasSplitHours":
                                template.Hourly9HasSplitHours = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[09].DPPLoadType":
                                template.Daily9AGA = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[09].Data.RecordLast":
                                template.Daily9Size = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[09].Data.RegRW":
                                template.Daily9Array = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[09].Index.RegRW":
                                template.Daily9Register = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[09].Data.NumRegs":
                                template.Daily9NumRegisters = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[09].PointNum":
                                template.Daily9PointNumbers = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[09].RTU.Index":
                                template.Daily9Index = config.FieldValue;
                                break;
                            case "Upload.METER.Periodic.DAILY.Run[09].RTU.HasSplitHours":
                                template.Daily9HasSplitHours = config.FieldValue;
                                break;
                            default:
                                break;
                        }
                    }
                    templates.Add(template);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return templates;
        }
    }
}
