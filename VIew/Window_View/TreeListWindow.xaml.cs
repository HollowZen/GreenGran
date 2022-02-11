using System.Windows;
using System.Windows.Input;

namespace GreenGrad.VIew.Window_View;

public partial class TreeListWindow : Window
{
    public TreeListWindow()
    {
        InitializeComponent();
    }

    private void UIElement_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        if (MessageBox.Show("Ваше предложение направленно в Администрацию Города.") == MessageBoxResult.OK)
        {
            TreeListWindow t = this;
            t.Close();
        }
    }
}