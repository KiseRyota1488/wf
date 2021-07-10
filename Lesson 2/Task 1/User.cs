using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public List<string> Hobbies { get; set; } = new List<string>();
    }
}
