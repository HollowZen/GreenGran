using System.Windows;

namespace GreenGrad.VIew.Window_View;

public partial class MapWindow : Window
{
    public MapWindow()
    {
        InitializeComponent();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        TreeListWindow t = new TreeListWindow();
        t.Show();
    }
}