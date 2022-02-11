using System.Windows;
using System.Windows.Input;
using GreenGrad.VIew.Window_View;

namespace GreenGrad.VIew;

public partial class AuthWindow : Window
{
    public AuthWindow()
    {
        InitializeComponent();
    }

    private void Signup_OnClick(object sender, RoutedEventArgs e)
    {
        RegWindow r = new RegWindow();
        r.Show();
        AuthWindow a = this;
        a.Close();
    }

    private void Login_OnClick(object sender, RoutedEventArgs e)
    {
        MapWindow m = new MapWindow();
        m.Show();
        AuthWindow a = this;
        a.Close();
    }
}