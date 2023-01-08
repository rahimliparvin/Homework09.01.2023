using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading___Collections.Models
{
    public class KelvinTemp
    {
        public double Kelvin { get; set; }

        public KelvinTemp(double kelvin)
        {
            Kelvin = kelvin;
        }

        public static implicit operator CelsiusTemp(KelvinTemp kelvin)
        {
            return new CelsiusTemp(kelvin.Kelvin - 273);
        }
    }
    
}