using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sxediasilogismikoy
{
    class DoctorLogUsername
    {
        static string DoctorUsername;
        public static string doctorUsername
        {
            get
            {
                return DoctorUsername;
            }
            set
            {
                DoctorUsername = value;
            }
        }
    }
}
