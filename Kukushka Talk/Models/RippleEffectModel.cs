using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using DevExpress.Mvvm;
using Kukushka_Talk.Views;

namespace Kukushka_Talk.Models
{
    public class RippleEffectModel : BindableBase
    {
        public Point EllipseStartPos { get; set; } = new Point(0, 0);
        public Point EllipseEndPos { get; set; } = new Point(0, 0);
        public double TargetWidth { get; set; }
        public string CurrentElipse { get; set; }

        public void Activate(object args)
        {
            MouseEventArgs mouse = args as MouseEventArgs;
            Mouse.Capture(mouse.Source as IInputElement);
            Point position = mouse.GetPosition(mouse.Source as UIElement);
            TargetWidth = Math.Max((mouse.Source as FrameworkElement).ActualWidth, (mouse.Source as FrameworkElement).ActualHeight) * 2;
            EllipseStartPos = new Point(position.X, position.Y);
            EllipseEndPos = new Point(position.X - TargetWidth / 2, position.Y - TargetWidth / 2);
            CurrentElipse = CurrentElipse == "ellipse1" ? "ellipse2" : "ellipse1";
            RaisePropertiesChanged(new string[] { "EllipseStartPos", "EllipseEndPos", "TargetWidth", "CurrentElipse" });
        }

        public void Decativate(object args)
        {
            Mouse.Capture(null);
        }
    }
}
