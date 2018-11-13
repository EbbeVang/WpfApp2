using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class Elephant
    {
        private String name;
        private int _weight;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
    }
}
