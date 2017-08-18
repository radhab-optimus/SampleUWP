using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using LoginSample.BusinessLogic;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSample.ModelView
{

    public class LoginViewModel : ViewModelBase
    {
        private string _username;
        private string _password;

        public string UserName
        {
            get { return _username; }
            set { Set(nameof(UserName), ref _username, value); }
        }

        public string Password
        {
            get { return _password; }
            set { Set(nameof(Password), ref _password, value); }
        }

        public RelayCommand LoginUserCommand { get; set; }

        public LoginViewModel()
        {
            InitializeCommand();
        }

        private void InitializeCommand()
        {
            LoginUserCommand = new RelayCommand(LoginUser);
        }

        private void LoginUser()
        {
            
        }
    }
}
