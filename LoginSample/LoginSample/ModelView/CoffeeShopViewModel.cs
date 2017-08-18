using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using LoginSample.BusinessLogic;
using LoginSample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSample.ModelView
{
    class CoffeeShopViewModel : ViewModelBase
    {
        private ObservableCollection<CoffeeShopModel> _coffeeList;
        public ObservableCollection<CoffeeShopModel> CoffeeList
        {
            get { return _coffeeList; }
            set
            {
                _coffeeList = value;
                RaisePropertyChanged(nameof(CoffeeList));
            }
        }

        CoffeeShopBL coffeeShop = new CoffeeShopBL();

        public CoffeeShopViewModel()
        {
            CoffeeList = coffeeShop.GetCoffeeList();
            RegisterMessages();
            InitializeCommand();
        }

        private void RegisterMessages()
        {
            MessengerInstance.Register<CoffeeShopModel>(this, "NewCoffeeItem", SaveNewCoffee);
            MessengerInstance.Register<CoffeeShopModel>(this, "UpdatedCoffee", UpdateCoffee);

        }

        public RelayCommand<int> DeleteCoffeeCommand { get; set; }
        public RelayCommand<int> EditCoffeeCommand { get; set; }
        
        private void InitializeCommand()
        {
            DeleteCoffeeCommand = new RelayCommand<int>(DeleteCoffee);
            EditCoffeeCommand = new RelayCommand<int>(EditCoffee);
        }

        private void SaveNewCoffee(CoffeeShopModel coffeeObj)
        {
            CoffeeList.Add(coffeeObj);
        }

        private void DeleteCoffee(int id)
        {
            CoffeeList.RemoveAt(id);
        }

        private void EditCoffee(int id)
        {
            var Coffee = CoffeeList[id];
            MessengerInstance.Send<CoffeeShopModel>(Coffee, "EditCoffeeItem");
        }
        

        private void UpdateCoffee(CoffeeShopModel coffeeObj)
        {
            CoffeeList[coffeeObj.Id] = coffeeObj;
        }
        
    }
}
