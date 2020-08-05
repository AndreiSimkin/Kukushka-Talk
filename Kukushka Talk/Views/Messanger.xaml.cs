using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kukushka_Talk.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Messanger : Window
    {

        public Messanger()
        {
            InitializeComponent();
            Network.STUNSupport.Get();
            void disfocus(UIElementCollection collection)
            {
                foreach (UIElement child in collection)
                {
                    if (child is Panel container)
                        if (container.Children != null)
                            disfocus(container.Children);
                    if (child is Control control)
                    {
                        control.IsTabStop = false;
                        control.FocusVisualStyle = null;
                    }
                    if (child is ContentControl contentcontrol)
                    {
                        if (contentcontrol.Content != null)
                        {
                            if (contentcontrol.Content is Panel content)
                                disfocus(content.Children);
                        }
                    }
                }
            }
            disfocus(Window.Children);
        }


        private void MenuButton_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }
    }

}
