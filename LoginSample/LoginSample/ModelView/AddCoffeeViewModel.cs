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
    public class AddCoffeeViewModel : ViewModelBase
    {
        private CoffeeShopModel _coffee;
        public CoffeeShopModel Coffee
        {
            get { return _coffee; }
            set
            {
                _coffee = value;
                RaisePropertyChanged(nameof(Coffee));
            }
        }

        public RelayCommand SaveCoffeeCommand { get; set; }
        public RelayCommand UpdateCoffeeCommand { get; set; }
        
        
        public AddCoffeeViewModel()
        {
            Coffee = new CoffeeShopModel();
            InitializeCommand();
            RegisterMessages();
        }

        private void InitializeCommand()
        {
            SaveCoffeeCommand = new RelayCommand(SaveCoffee);
            UpdateCoffeeCommand = new RelayCommand(UpdateCoffee);
        }

        private void RegisterMessages()
        {
            MessengerInstance.Register<CoffeeShopModel>(this, "EditCoffeeItem", EditItem);
        }

        private void SaveCoffee()
        {
            MessengerInstance.Send<CoffeeShopModel>(Coffee, "NewCoffeeItem");
        }

        private void UpdateCoffee()
        {
            MessengerInstance.Send<CoffeeShopModel>(Coffee, "UpdatedCoffee");
        }
        

        private void EditItem(CoffeeShopModel coffeeObj)
        {
            Coffee = coffeeObj;
        }
    }
}
