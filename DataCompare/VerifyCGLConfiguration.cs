using MapCGLToRemote.OutputModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MapCGLToRemote.DataCompare
{
    public class VerifyCGLConfiguration
    {
        public List<RemoteCGL> CompareEGMWithCGL(List<CGL> configs, List<CGLTemplateDef> templates, Dictionary<string, string> rtuCGL)
        {
            var WrongCGLConfigurations = new List<RemoteCGL>();

            foreach(var cgl in configs)
            {
                var currentCGLName = rtuCGL[cgl.OASySName];

                var currentCGL = templates.Where(i => i.TemplateName == currentCGLName).FirstOrDefault();

                if(currentCGL is null)
                {
                    Console.WriteLine($"{cgl.OASySName} is using {currentCGLName}");
                    Console.ReadLine();
                }

                var matchingTemplates = templates.Where(i => i.Hourly1AGA == cgl.Hourly1AGA || cgl.Hourly1AGA.Equals(""))
                    .Where(i => i.Hourly1Array == cgl.Hourly1Array || cgl.Hourly1Array.Equals(""))
                    .Where(i => i.Hourly1Register == cgl.Hourly1Register || cgl.Hourly1Register.Equals(""))
                    .Where(i => i.Hourly1Size == cgl.Hourly1Size || cgl.Hourly1Size.Equals(""))
                    .Where(i => i.Hourly2AGA == cgl.Hourly2AGA || cgl.Hourly2AGA.Equals(""))
                    .Where(i => i.Hourly2Array == cgl.Hourly2Array || cgl.Hourly2Array.Equals(""))
                    .Where(i => i.Hourly2Register == cgl.Hourly2Register || cgl.Hourly2Register.Equals(""))
                    .Where(i => i.Hourly2Size == cgl.Hourly2Size || cgl.Hourly2Size.Equals(""))
                    .Where(i => i.Hourly3AGA == cgl.Hourly3AGA || cgl.Hourly3AGA.Equals(""))
                    .Where(i => i.Hourly3Array == cgl.Hourly3Array || cgl.Hourly3Array.Equals(""))
                    .Where(i => i.Hourly3Register == cgl.Hourly3Register || cgl.Hourly3Register.Equals(""))
                    .Where(i => i.Hourly3Size == cgl.Hourly3Size || cgl.Hourly3Size.Equals(""))
                    .Where(i => i.Hourly4AGA == cgl.Hourly4AGA || cgl.Hourly4AGA.Equals(""))
                    .Where(i => i.Hourly4Array == cgl.Hourly4Array || cgl.Hourly4Array.Equals(""))
                    .Where(i => i.Hourly4Register == cgl.Hourly4Register || cgl.Hourly4Register.Equals(""))
                    .Where(i => i.Hourly4Size == cgl.Hourly4Size || cgl.Hourly4Size.Equals(""))
                    .Where(i => i.Hourly5AGA == cgl.Hourly5AGA || cgl.Hourly5AGA.Equals(""))
                    .Where(i => i.Hourly5Array == cgl.Hourly5Array || cgl.Hourly5Array.Equals(""))
                    .Where(i => i.Hourly5Register == cgl.Hourly5Register || cgl.Hourly5Register.Equals(""))
                    .Where(i => i.Hourly5Size == cgl.Hourly5Size || cgl.Hourly5Size.Equals(""))
                    .Where(i => i.Hourly6AGA == cgl.Hourly6AGA || cgl.Hourly6AGA.Equals(""))
                    .Where(i => i.Hourly6Array == cgl.Hourly6Array || cgl.Hourly6Array.Equals(""))
                    .Where(i => i.Hourly6Register == cgl.Hourly6Register || cgl.Hourly6Register.Equals(""))
                    .Where(i => i.Hourly6Size == cgl.Hourly6Size || cgl.Hourly6Size.Equals(""))
                    .Where(i => i.Hourly7AGA == cgl.Hourly7AGA || cgl.Hourly7AGA.Equals(""))
                    .Where(i => i.Hourly7Array == cgl.Hourly7Array || cgl.Hourly7Array.Equals(""))
                    .Where(i => i.Hourly7Register == cgl.Hourly7Register || cgl.Hourly7Register.Equals(""))
                    .Where(i => i.Hourly7Size == cgl.Hourly7Size || cgl.Hourly7Size.Equals(""))
                    .Where(i => i.Hourly8AGA == cgl.Hourly8AGA || cgl.Hourly8AGA.Equals(""))
                    .Where(i => i.Hourly8Array == cgl.Hourly8Array || cgl.Hourly8Array.Equals(""))
                    .Where(i => i.Hourly8Register == cgl.Hourly8Register || cgl.Hourly8Register.Equals(""))
                    .Where(i => i.Hourly8Size == cgl.Hourly8Size || cgl.Hourly8Size.Equals(""))
                    .Where(i => i.Hourly9AGA == cgl.Hourly9AGA || cgl.Hourly9AGA.Equals(""))
                    .Where(i => i.Hourly9Array == cgl.Hourly9Array || cgl.Hourly9Array.Equals(""))
                    .Where(i => i.Hourly9Register == cgl.Hourly9Register || cgl.Hourly9Register.Equals(""))
                    .Where(i => i.Hourly9Size == cgl.Hourly9Size || cgl.Hourly9Size.Equals(""))
                    .Where(i => i.Daily1AGA == cgl.Daily1AGA || cgl.Daily1AGA.Equals(""))
                    .Where(i => i.Daily1Array == cgl.Daily1Array || cgl.Daily1Array.Equals(""))
                    .Where(i => i.Daily1Register == cgl.Daily1Register || cgl.Daily1Register.Equals(""))
                    .Where(i => i.Daily1Size == cgl.Daily1Size || cgl.Daily1Size.Equals(""))
                    .Where(i => i.Daily2AGA == cgl.Daily2AGA || cgl.Daily2AGA.Equals(""))
                    .Where(i => i.Daily2Array == cgl.Daily2Array || cgl.Daily2Array.Equals(""))
                    .Where(i => i.Daily2Register == cgl.Daily2Register || cgl.Daily2Register.Equals(""))
                    .Where(i => i.Daily2Size == cgl.Daily2Size || cgl.Daily2Size.Equals(""))
                    .Where(i => i.Daily3AGA == cgl.Daily3AGA || cgl.Daily3AGA.Equals(""))
                    .Where(i => i.Daily3Array == cgl.Daily3Array || cgl.Daily3Array.Equals(""))
                    .Where(i => i.Daily3Register == cgl.Daily3Register || cgl.Daily3Register.Equals(""))
                    .Where(i => i.Daily3Size == cgl.Daily3Size || cgl.Daily3Size.Equals(""))
                    .Where(i => i.Daily4AGA == cgl.Daily4AGA || cgl.Daily4AGA.Equals(""))
                    .Where(i => i.Daily4Array == cgl.Daily4Array || cgl.Daily4Array.Equals(""))
                    .Where(i => i.Daily4Register == cgl.Daily4Register || cgl.Daily4Register.Equals(""))
                    .Where(i => i.Daily4Size == cgl.Daily4Size || cgl.Daily4Size.Equals(""))
                    .Where(i => i.Daily5AGA == cgl.Daily5AGA || cgl.Daily5AGA.Equals(""))
                    .Where(i => i.Daily5Array == cgl.Daily5Array || cgl.Daily5Array.Equals(""))
                    .Where(i => i.Daily5Register == cgl.Daily5Register || cgl.Daily5Register.Equals(""))
                    .Where(i => i.Daily5Size == cgl.Daily5Size || cgl.Daily5Size.Equals(""))
                    .Where(i => i.Daily6AGA == cgl.Daily6AGA || cgl.Daily6AGA.Equals(""))
                    .Where(i => i.Daily6Array == cgl.Daily6Array || cgl.Daily6Array.Equals(""))
                    .Where(i => i.Daily6Register == cgl.Daily6Register || cgl.Daily6Register.Equals(""))
                    .Where(i => i.Daily6Size == cgl.Daily6Size || cgl.Daily6Size.Equals(""))
                    .Where(i => i.Daily7AGA == cgl.Daily7AGA || cgl.Daily7AGA.Equals(""))
                    .Where(i => i.Daily7Array == cgl.Daily7Array || cgl.Daily7Array.Equals(""))
                    .Where(i => i.Daily7Register == cgl.Daily7Register || cgl.Daily7Register.Equals(""))
                    .Where(i => i.Daily7Size == cgl.Daily7Size || cgl.Daily7Size.Equals(""))
                    .Where(i => i.Daily8AGA == cgl.Daily8AGA || cgl.Daily8AGA.Equals(""))
                    .Where(i => i.Daily8Array == cgl.Daily8Array || cgl.Daily8Array.Equals(""))
                    .Where(i => i.Daily8Register == cgl.Daily8Register || cgl.Daily8Register.Equals(""))
                    .Where(i => i.Daily8Size == cgl.Daily8Size || cgl.Daily8Size.Equals(""))
                    .Where(i => i.Daily9AGA == cgl.Daily9AGA || cgl.Daily9AGA.Equals(""))
                    .Where(i => i.Daily9Array == cgl.Daily9Array || cgl.Daily9Array.Equals(""))
                    .Where(i => i.Daily9Register == cgl.Daily9Register || cgl.Daily9Register.Equals(""))
                    .Where(i => i.Daily9Size == cgl.Daily9Size || cgl.Daily9Size.Equals("")).ToList();

                if(!matchingTemplates.Contains(currentCGL))
                {
                    var missingcglTemplate = new RemoteCGL()
                    {
                        RemoteName = cgl.OASySName,
                        CGLTemplateName = currentCGL.TemplateName
                    };
                    
                    WrongCGLConfigurations.Add(missingcglTemplate);
                }
            }
            return WrongCGLConfigurations;
        }
    }
}
