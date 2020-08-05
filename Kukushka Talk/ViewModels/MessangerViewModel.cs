using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Kukushka_Talk.ViewModels
{
    class MessangerViewModel : ViewModelBase
    {
        public ICommand TestCommnad
        {
            get
            {
                return new DelegateCommand<MouseButtonEventArgs>((MouseButtonEventArgs e) =>
                {

                });
            }
        }
    }
}
