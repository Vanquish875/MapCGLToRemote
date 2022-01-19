using MapCGLToRemote.OutputModels;
using System.Collections.Generic;
using System.Linq;

namespace MapCGLToRemote.Mapping
{
    public class MapCGLToRemotes
    {
        public List<RemoteCGL> MapRemoteCGLTemplates(List<CGL> remotes, List<CGLTemplateDef> templates)
        {
            var MappedRemoteCGL = new List<RemoteCGL>();

            foreach(var remote in remotes)
            {
                var CGLtemplates = new List<CGLTemplateDef>();
                
                CGLtemplates = templates.Where(i => i.Hourly1AGA == remote.Hourly1AGA)
                    .Where(i => i.Hourly1Array == remote.Hourly1Array)
                    .Where(i => i.Hourly1Register == remote.Hourly1Register)
                    .Where(i => i.Hourly1Size == remote.Hourly1Size)
                    .Where(i => i.Hourly2AGA == remote.Hourly2AGA || remote.Hourly2AGA == "")
                    .Where(i => i.Hourly2Array == remote.Hourly2Array || remote.Hourly2Array == "")
                    .Where(i => i.Hourly2Register == remote.Hourly2Register || remote.Hourly2Register == "")
                    .Where(i => i.Hourly2Size == remote.Hourly2Size || remote.Hourly2Size == "")
                    .Where(i => i.Hourly3AGA == remote.Hourly3AGA || remote.Hourly3AGA == "")
                    .Where(i => i.Hourly3Array == remote.Hourly3Array || remote.Hourly3Array == "")
                    .Where(i => i.Hourly3Register == remote.Hourly3Register || remote.Hourly3Register == "")
                    .Where(i => i.Hourly3Size == remote.Hourly3Size || remote.Hourly3Size == "")
                    .Where(i => i.Hourly4AGA == remote.Hourly4AGA || remote.Hourly4AGA == "")
                    .Where(i => i.Hourly4Array == remote.Hourly4Array || remote.Hourly4Array == "")
                    .Where(i => i.Hourly4Register == remote.Hourly4Register || remote.Hourly4Register == "")
                    .Where(i => i.Hourly4Size == remote.Hourly4Size || remote.Hourly4Size == "")
                    .Where(i => i.Hourly5AGA == remote.Hourly5AGA || remote.Hourly5AGA == "")
                    .Where(i => i.Hourly5Array == remote.Hourly5Array || remote.Hourly5Array == "")
                    .Where(i => i.Hourly5Register == remote.Hourly5Register || remote.Hourly5Register == "")
                    .Where(i => i.Hourly5Size == remote.Hourly5Size || remote.Hourly5Size == "")
                    .Where(i => i.Hourly6AGA == remote.Hourly6AGA || remote.Hourly6AGA == "")
                    .Where(i => i.Hourly6Array == remote.Hourly6Array || remote.Hourly6Array == "")
                    .Where(i => i.Hourly6Register == remote.Hourly6Register || remote.Hourly6Register == "")
                    .Where(i => i.Hourly6Size == remote.Hourly6Size || remote.Hourly6Size == "")
                    .Where(i => i.Hourly7AGA == remote.Hourly7AGA || remote.Hourly7AGA == "")
                    .Where(i => i.Hourly7Array == remote.Hourly7Array || remote.Hourly7Array == "")
                    .Where(i => i.Hourly7Register == remote.Hourly7Register || remote.Hourly7Register == "")
                    .Where(i => i.Hourly7Size == remote.Hourly7Size || remote.Hourly7Size == "")
                    .Where(i => i.Hourly8AGA == remote.Hourly8AGA || remote.Hourly8AGA == "")
                    .Where(i => i.Hourly8Array == remote.Hourly8Array || remote.Hourly8Array == "")
                    .Where(i => i.Hourly8Register == remote.Hourly8Register || remote.Hourly8Register == "")
                    .Where(i => i.Hourly8Size == remote.Hourly8Size || remote.Hourly8Size == "")
                    .Where(i => i.Hourly9AGA == remote.Hourly9AGA || remote.Hourly9AGA == "")
                    .Where(i => i.Hourly9Array == remote.Hourly9Array || remote.Hourly9Array == "")
                    .Where(i => i.Hourly9Register == remote.Hourly9Register || remote.Hourly9Register == "")
                    .Where(i => i.Hourly9Size == remote.Hourly9Size || remote.Hourly9Size == "")
                    .Where(i => i.Daily1AGA == remote.Daily1AGA)
                    .Where(i => i.Daily1Array == remote.Daily1Array)
                    .Where(i => i.Daily1Register == remote.Daily1Register)
                    .Where(i => i.Daily1Size == remote.Daily1Size)
                    .Where(i => i.Daily2AGA == remote.Daily2AGA || remote.Daily2AGA == "")
                    .Where(i => i.Daily2Array == remote.Daily2Array || remote.Daily2Array == "")
                    .Where(i => i.Daily2Register == remote.Daily2Register || remote.Daily2Register == "")
                    .Where(i => i.Daily2Size == remote.Daily2Size || remote.Daily2Size == "")
                    .Where(i => i.Daily3AGA == remote.Daily3AGA || remote.Daily3AGA == "")
                    .Where(i => i.Daily3Array == remote.Daily3Array || remote.Daily3Array == "")
                    .Where(i => i.Daily3Register == remote.Daily3Register || remote.Daily3Register == "")
                    .Where(i => i.Daily3Size == remote.Daily3Size || remote.Daily3Size == "")
                    .Where(i => i.Daily4AGA == remote.Daily4AGA || remote.Daily4AGA == "")
                    .Where(i => i.Daily4Array == remote.Daily4Array || remote.Daily4Array == "")
                    .Where(i => i.Daily4Register == remote.Daily4Register || remote.Daily4Register == "")
                    .Where(i => i.Daily4Size == remote.Daily4Size || remote.Daily4Size == "")
                    .Where(i => i.Daily5AGA == remote.Daily5AGA || remote.Daily5AGA == "")
                    .Where(i => i.Daily5Array == remote.Daily5Array || remote.Daily5Array == "")
                    .Where(i => i.Daily5Register == remote.Daily5Register || remote.Daily5Register == "")
                    .Where(i => i.Daily5Size == remote.Daily5Size || remote.Daily5Size == "")
                    .Where(i => i.Daily6AGA == remote.Daily6AGA || remote.Daily6AGA == "")
                    .Where(i => i.Daily6Array == remote.Daily6Array || remote.Daily6Array == "")
                    .Where(i => i.Daily6Register == remote.Daily6Register || remote.Daily6Register == "")
                    .Where(i => i.Daily6Size == remote.Daily6Size || remote.Daily6Size == "")
                    .Where(i => i.Daily7AGA == remote.Daily7AGA || remote.Daily7AGA == "")
                    .Where(i => i.Daily7Array == remote.Daily7Array || remote.Daily7Array == "")
                    .Where(i => i.Daily7Register == remote.Daily7Register || remote.Daily7Register == "")
                    .Where(i => i.Daily7Size == remote.Daily7Size || remote.Daily7Size == "")
                    .Where(i => i.Daily8AGA == remote.Daily8AGA || remote.Daily8AGA == "")
                    .Where(i => i.Daily8Array == remote.Daily8Array || remote.Daily8Array == "")
                    .Where(i => i.Daily8Register == remote.Daily8Register || remote.Daily8Register == "")
                    .Where(i => i.Daily8Size == remote.Daily8Size || remote.Daily8Size == "")
                    .Where(i => i.Daily9AGA == remote.Daily9AGA || remote.Daily9AGA == "")
                    .Where(i => i.Daily9Array == remote.Daily9Array || remote.Daily9Array == "")
                    .Where(i => i.Daily9Register == remote.Daily9Register || remote.Daily9Register == "")
                    .Where(i => i.Daily9Size == remote.Daily9Size || remote.Daily9Size == "")
                    .Where(i => i.TemplateName.Contains(remote.DeviceType))
                    .Where(i => i.TemplateName != "APP_O" && i.TemplateName != "XMOD_CWM_GC_L" && i.TemplateName != "XMOD_CWM_Stanfield" && i.TemplateName != "XMOD_CWM_Calpine_AGA11" &&
                    i.TemplateName != "XMOD_CWM_ThreeMiles" && i.TemplateName != "XMOD_CWM_Carty" && i.TemplateName != "XMOD_CWM_Calpine" &&
                    i.TemplateName != "XMOD_CWM_Ogilby" && i.TemplateName != "XMOD_CWM_Spokane").ToList();

                foreach(var temp in CGLtemplates)
                {
                    var remoteCGL = new RemoteCGL();
                    remoteCGL.RemoteName = remote.OASySName;
                    remoteCGL.CGLTemplateName = temp.TemplateName;
                    MappedRemoteCGL.Add(remoteCGL);
                }
            }

            return MappedRemoteCGL;
        }
    }
}
