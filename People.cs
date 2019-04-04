using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    public delegate void PropertyeventHandler(object sender, PropertyeventArgs e);
    public class People : IPropertychanged
    {

        private string _city;
        public string Name { get; set; }
        public string City {
            get
            {
                return _city;
            }
            set
            {
                Propertychanged?.Invoke(Name, new PropertyeventArgs(Convert.ToString(typeof(People))));
                _city = value;
            }
        }
        public event PropertyeventHandler Propertychanged;
    }
}
