using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class GentleSmartphone
    {
        public int SerialNumber { get; set; }
        public TactileSensor Sensor { get; set; }

        public GentleSmartphone()
        {
            Sensor = new TactileSensor();
        }
    }
}
