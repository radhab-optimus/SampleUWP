using LoginSample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSample.BusinessLogic
{
    public class CoffeeShopBL
    {
        public ObservableCollection<CoffeeShopModel> GetCoffeeList()
        {
            ObservableCollection<CoffeeShopModel> coffeeList = new ObservableCollection<CoffeeShopModel>();
            coffeeList.Add(new CoffeeShopModel { Id= 0, Name = "Expresso", Type = "strong", Price=100 });
            coffeeList.Add(new CoffeeShopModel { Id = 1, Name = "Macchiato", Type = "light", Price = 150 });
            coffeeList.Add(new CoffeeShopModel { Id = 2, Name = "Americano", Type = "strong", Price = 250 });

            return coffeeList;
        }
    }
}
