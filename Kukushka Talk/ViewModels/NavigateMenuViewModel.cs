using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using DevExpress.Mvvm.DataAnnotations;

namespace Kukushka_Talk.ViewModels
{
    class NavigateMenuViewModel : ViewModelBase
    {
        public string State { get; set; }

        public ICommand CloseMenuCommand
        {
           get
            {
                return new DelegateCommand<MouseButtonEventArgs>((MouseButtonEventArgs e) =>
                {
                    State = "CloseMenu";
                    Point point = e.GetPosition((UIElement)e.Source);
                });
            }
        }

        public ICommand OpenMenuCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    State = "OpenMenu";
                });
            }
        }
    }
}
