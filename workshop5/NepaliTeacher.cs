using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop5
{
    public class NepaliTeacher : Teacher
    {
        // Must inherit from Teacher
        public NepaliTeacher(string name) : base(name)
        {
        }

        // Override method
        public override void Teaching()
        {
            Console.WriteLine("Teacher teaches in Nepali");
        }
    }

}
