using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSample.Models
{
    public class CoffeeShopModel : ObservableObject
    {
        
        private string _name;
        private string _type;
        private float _price;

        public int Id { get; set; }
        public string Name {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged(nameof(Name));
            }
        }

        public string Type {
            get { return _type; }
            set
            {
                _type = value;
                RaisePropertyChanged(nameof(Type));
            }
        }

        public float Price {
            get { return _price; }
            set
            {
                _price = value;
                RaisePropertyChanged(nameof(Price));
            }
        }

        //public override string ToString()
        //{
        //    return string.Format("{0} {1} {2}", Name, Type, Price);
        //}
    }
}
