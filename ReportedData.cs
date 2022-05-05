using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenu2
{
    internal class ReportedData
    {
        public int MessageId { get; set; }
        public string ArduinoId { get; set; }
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float CO2 { get; set; }
        public float SoilMoisture { get; set; }
    }
}
