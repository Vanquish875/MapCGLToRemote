namespace MapCGLToRemote.OutputModels
{
    public class CGL
    {
        public string OASySName { get; set; }
        public string RTUName { get; set; }
        public string DeviceType { get; set; }
        public string Hourly1AGA { get; set; } = "";
        public string Hourly1Array { get; set; } = "";
        public string Hourly1Register { get; set; } = "";
        public string Hourly1Size { get; set; } = "";
        public string Daily1AGA { get; set; } = "";
        public string Daily1Array { get; set; } = "";
        public string Daily1Register { get; set; } = "";
        public string Daily1Size { get; set; } = "";
        public string Hourly2AGA { get; set; } = "";
        public string Hourly2Array { get; set; } = "";
        public string Hourly2Register { get; set; } = "";
        public string Hourly2Size { get; set; } = "";
        public string Daily2AGA { get; set; } = "";
        public string Daily2Array { get; set; } = "";
        public string Daily2Register { get; set; } = "";
        public string Daily2Size { get; set; } = "";
        public string Hourly3AGA { get; set; } = "";
        public string Hourly3Array { get; set; } = "";
        public string Hourly3Register { get; set; } = "";
        public string Hourly3Size { get; set; } = "";
        public string Daily3AGA { get; set; } = "";
        public string Daily3Array { get; set; } = "";
        public string Daily3Register { get; set; } = "";
        public string Daily3Size { get; set; } = "";
        public string Hourly4AGA { get; set; } = "";
        public string Hourly4Array { get; set; } = "";
        public string Hourly4Register { get; set; } = "";
        public string Hourly4Size { get; set; } = "";
        public string Daily4AGA { get; set; } = "";
        public string Daily4Array { get; set; } = "";
        public string Daily4Register { get; set; } = "";
        public string Daily4Size { get; set; } = "";
        public string Hourly5AGA { get; set; } = "";
        public string Hourly5Array { get; set; } = "";
        public string Hourly5Register { get; set; } = "";
        public string Hourly5Size { get; set; } = "";
        public string Daily5AGA { get; set; } = "";
        public string Daily5Array { get; set; } = "";
        public string Daily5Register { get; set; } = "";
        public string Daily5Size { get; set; } = "";
        public string Hourly6AGA { get; set; } = "";
        public string Hourly6Array { get; set; } = "";
        public string Hourly6Register { get; set; } = "";
        public string Hourly6Size { get; set; } = "";
        public string Daily6AGA { get; set; } = "";
        public string Daily6Array { get; set; } = "";
        public string Daily6Register { get; set; } = "";
        public string Daily6Size { get; set; } = "";
        public string Hourly7AGA { get; set; } = "";
        public string Hourly7Array { get; set; } = "";
        public string Hourly7Register { get; set; } = "";
        public string Hourly7Size { get; set; } = "";
        public string Daily7AGA { get; set; } = "";
        public string Daily7Array { get; set; } = "";
        public string Daily7Register { get; set; } = "";
        public string Daily7Size { get; set; } = "";
        public string Hourly8AGA { get; set; } = "";
        public string Hourly8Array { get; set; } = "";
        public string Hourly8Register { get; set; } = "";
        public string Hourly8Size { get; set; } = "";
        public string Daily8AGA { get; set; } = "";
        public string Daily8Array { get; set; } = "";
        public string Daily8Register { get; set; } = "";
        public string Daily8Size { get; set; } = "";
        public string Hourly9AGA { get; set; } = "";
        public string Hourly9Array { get; set; } = "";
        public string Hourly9Register { get; set; } = "";
        public string Hourly9Size { get; set; } = "";
        public string Daily9AGA { get; set; } = "";
        public string Daily9Array { get; set; } = "";
        public string Daily9Register { get; set; } = "";
        public string Daily9Size { get; set; } = "";

        public override string ToString()
        {
            return $"{OASySName} {RTUName} {Hourly1AGA} {Hourly1Array} {Hourly1Register} {Hourly1Size} " +
                $"{Daily1AGA} {Daily1Array} {Daily1Register} {Daily1Size} " +
                $"{Hourly2AGA} {Hourly2Array} {Hourly2Register} {Hourly2Size} " +
                $"{Daily2AGA} {Daily2Array} {Daily2Register} {Daily2Size} " +
                $"{Hourly3AGA} {Hourly3Array} {Hourly3Register} {Hourly3Size} " +
                $"{Daily3AGA} {Daily3Array} {Daily3Register} {Daily3Size} " +
                $"{Hourly4AGA} {Hourly4Array} {Hourly4Register} {Hourly4Size} " +
                $"{Daily4AGA} {Daily4Array} {Daily4Register} {Daily4Size} " +
                $"{Hourly5AGA} {Hourly5Array} {Hourly5Register} {Hourly5Size} " +
                $"{Daily5AGA} {Daily5Array} {Daily5Register} {Daily5Size} " +
                $"{Hourly6AGA} {Hourly6Array} {Hourly6Register} {Hourly6Size} " +
                $"{Daily6AGA} {Daily6Array} {Daily6Register} {Daily6Size} " +
                $"{Hourly7AGA} {Hourly7Array} {Hourly7Register} {Hourly7Size} " +
                $"{Daily7AGA} {Daily7Array} {Daily7Register} {Daily7Size} " +
                $"{Hourly8AGA} {Hourly8Array} {Hourly8Register} {Hourly8Size} " +
                $"{Daily8AGA} {Daily8Array} {Daily8Register} {Daily8Size} ";
        }

        public bool CheckIfRemoteHasMeasurementData()
        {
            if (Hourly1Array == "" && Hourly2Array == "" && Hourly3Array == "" &&
                Hourly4Array == "" && Hourly5Array == "" && Hourly6Array == "" &&
                Hourly7Array == "" && Hourly8Array == "" && Hourly9Array == "")
                return false;

            return true;
        }
    }
}
