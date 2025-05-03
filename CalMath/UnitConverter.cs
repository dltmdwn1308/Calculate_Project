using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Project.CalMath
{
    using System;

    namespace Calculate_Project
    {
        public class UnitConverter
        {
            // 킬로그램(kg) → 파운드(lb)
            public double ConvertKgToLb(double kg)
            {
                double lb = kg * 2.20462;
                return lb;
            }

            // 파운드(lb) → 킬로그램(kg)
            public double ConvertLbToKg(double lb)
            {
                double kg = lb / 2.20462;
                return kg;
            }

            // 센티미터(cm) → 인치(inch)
            public double ConvertCmToInch(double cm)
            {
                double inch = cm / 2.54;
                return inch;
            }

            // 인치(inch) → 센티미터(cm)
            public double ConvertInchToCm(double inch)
            {
                double cm = inch * 2.54;
                return cm;
            }
        }
    }

}
