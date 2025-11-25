using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop5
{
    // EnglishTeacher inherits but does NOT override Teaching()
    public class EnglishTeacher : Teacher
    {
        public EnglishTeacher(string name) : base(name)
        {
        }
    }
}
