using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DelegatePractice
{
    public class PropertyeventArgs
    {
        private People people;

        public string Name { get; set; }
        public PropertyeventArgs(string _name)
        {
            Name = _name;
        }
    }
}
