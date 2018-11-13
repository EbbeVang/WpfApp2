using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace WpfApp2
{
    class ViewModel
    {
        private ObservableCollection<Elephant> _list = new ObservableCollection<Elephant>();
        
        public ViewModel()
        {
            List.Add(new Elephant() {Name = "Adam", Weight = 300});
            List.Add(new Elephant() {Name = "Bob", Weight = 100});
            List = new ObservableCollection<Elephant>(List.OrderBy(elephant => elephant.Name).ToList());


        }

        public ObservableCollection<Elephant> List
        {
            get { return _list; }
            set { _list = value; }
        }
    }
}
