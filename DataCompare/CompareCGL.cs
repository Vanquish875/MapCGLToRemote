using MapCGLToRemote.OutputModels;
using System.Collections.Generic;
using System.Linq;

namespace MapCGLToRemote.DataCompare
{
    public class CompareCGL
    {
        public List<CGLTemplateDef> CompareProdToTestCGL(List<CGLTemplateDef> prodCGL, List<CGLTemplateDef> testCGL)
        {
            var ProdCGLs = new List<CGLTemplateDef>();

            foreach(var cgl in prodCGL)
            {
                var ProdConfig = prodCGL.Where(i => i.TemplateName == cgl.TemplateName).FirstOrDefault();
                ProdCGLs.Add(ProdConfig);
            }

            return ProdCGLs;
        }

        public List<CGLTemplateDef> CompareTestToProdCGL(List<CGLTemplateDef> prodCGL, List<CGLTemplateDef> testCGL)
        {
            var TestCGLs = new List<CGLTemplateDef>();

            foreach (var cgl in prodCGL)
            {
                var testConfig = testCGL.Where(i => i.TemplateName == cgl.TemplateName).FirstOrDefault();
                TestCGLs.Add(testConfig);
            }

            return TestCGLs;
        }
    }
}
