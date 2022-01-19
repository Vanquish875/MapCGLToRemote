using FileHelpers;

namespace MapCGLToRemote.InputModels
{
    [DelimitedRecord(",")]
    public class RemoteCGLTemplate
    {
        public string RemoteName { get; set; }
        public string CGLTemplate { get; set; }
    }
}
