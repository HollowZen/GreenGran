using System.Windows;
using System.Windows.Input;

namespace GreenGrad.VIew;

public partial class RegWindow : Window
{
    public RegWindow()
    {
        InitializeComponent();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        AuthWindow a = new AuthWindow();
        a.Show();
        RegWindow r = this;
        r.Close();
    }
}