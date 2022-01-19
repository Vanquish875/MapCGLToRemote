using MapCGLToRemote.OutputModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MapCGLToRemote.Mapping
{
    public class MapGQTemplate
    {
        public List<GQTemplateDef> MapGQ(List<TemplateDef> data)
        {
            var templates = new List<GQTemplateDef>();

            try
            {
                var names = data.Select(i => i.TemplateName).Distinct();

                foreach (var name in names)
                {
                    var configs = data.Where(i => i.TemplateName == name);

                    var template = new GQTemplateDef();
                    template.TemplateName = name;
                    foreach (var config in configs)
                    {
                        switch (config.FieldName)
                        {
                            case "Download.METER.Parameter.GQ.Run[01].Set[01].Data.RegRW":
                                template.Run1Set1RegisterStart = config.FieldValue;
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[02].Data.RegRW":
                                template.Run1Set2RegisterStart = config.FieldValue;
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[01].Data.RegRW":
                                template.Run2Set1RegisterStart = config.FieldValue;
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[02].Data.RegRW":
                                template.Run2Set2RegisterStart = config.FieldValue;
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[01].PointNum":
                                template.Run1Set1PointNumber = config.FieldValue;
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[02].PointNum":
                                template.Run1Set2PointNumber = config.FieldValue;
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[01].PointNum":
                                template.Run2Set1PointNumber = config.FieldValue;
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[02].PointNum":
                                template.Run2Set2PointNumber = config.FieldValue;
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].SetNum":
                                template.Run1SetNumber = config.FieldValue;
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].SetNumt":
                                template.Run2SetNumber = config.FieldValue;
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[01].Point[01]":
                                template.Run1Set1Point1 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[01].Point[02]":
                                template.Run1Set1Point2 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[01].Point[03]":
                                template.Run1Set1Point3 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[01].Point[04]":
                                template.Run1Set1Point4 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[01].Point[05]":
                                template.Run1Set1Point5 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[01].Point[06]":
                                template.Run1Set1Point6 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[01].Point[07]":
                                template.Run1Set1Point7 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[01].Point[08]":
                                template.Run1Set1Point8 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[01].Point[09]":
                                template.Run1Set1Point9 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[01].Point[10]":
                                template.Run1Set1Point10 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[01].Point[11]":
                                template.Run1Set1Point11 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[01].Point[12]":
                                template.Run1Set1Point12 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[01].Point[13]":
                                template.Run1Set1Point13 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[01].Point[14]":
                                template.Run1Set1Point14 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[01].Point[15]":
                                template.Run1Set1Point15 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[01].Point[16]":
                                template.Run1Set1Point16 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[01].Point[17]":
                                template.Run1Set1Point17 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[01].Point[18]":
                                template.Run1Set1Point18 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[01].Point[19]":
                                template.Run1Set1Point19 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[01].Point[20]":
                                template.Run1Set1Point20 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[01].Point[21]":
                                template.Run1Set1Point21 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[01].Point[22]":
                                template.Run1Set1Point22 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[01].Point[23]":
                                template.Run1Set1Point23 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[01].Point[24]":
                                template.Run1Set1Point24 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[01].Set[01].Point[25]":
                                template.Run1Set1Point25 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[01].Point[01]":
                                template.Run2Set1Point1 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[01].Point[02]":
                                template.Run2Set1Point2 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[01].Point[03]":
                                template.Run2Set1Point3 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[01].Point[04]":
                                template.Run2Set1Point4 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[01].Point[05]":
                                template.Run2Set1Point5 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[01].Point[06]":
                                template.Run2Set1Point6 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[01].Point[07]":
                                template.Run2Set1Point7 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[01].Point[08]":
                                template.Run2Set1Point8 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[01].Point[09]":
                                template.Run2Set1Point9 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[01].Point[10]":
                                template.Run2Set1Point10 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[01].Point[11]":
                                template.Run2Set1Point11 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[01].Point[12]":
                                template.Run2Set1Point12 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[01].Point[13]":
                                template.Run2Set1Point13 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[01].Point[14]":
                                template.Run2Set1Point14 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[01].Point[15]":
                                template.Run2Set1Point15 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[01].Point[16]":
                                template.Run2Set1Point16 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[01].Point[17]":
                                template.Run2Set1Point17 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[01].Point[18]":
                                template.Run2Set1Point18 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[01].Point[19]":
                                template.Run2Set1Point19 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[01].Point[20]":
                                template.Run2Set1Point20 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[01].Point[21]":
                                template.Run2Set1Point21 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[01].Point[22]":
                                template.Run2Set1Point22 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[01].Point[23]":
                                template.Run2Set1Point23 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[01].Point[24]":
                                template.Run2Set1Point24 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
                                break;
                            case "Download.METER.Parameter.GQ.Run[02].Set[01].Point[25]":
                                template.Run2Set1Point25 = Helper.ReturnGQPropertyFromDictionary(config.FieldValue);
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
