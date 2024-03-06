using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Transformator
    {
        public int SerialNumber { get; set; }
        public TransformatorType transformatorType {  get; set; }
        public enum TransformatorType
        {
            Multiplier,
            Divider
        }
    }
}
