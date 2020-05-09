using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Company:ICloneable

    {
        public int Phone { get; set; }
        public string Name { get; set; }
        public Company(string name,int phone)
        {
            Name = name;
            Phone = phone;
        }

        public object Clone()
        {
            return (object)this.MemberwiseClone();
        }
    }
}
