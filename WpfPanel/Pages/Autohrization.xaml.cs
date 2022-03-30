using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassLibraryAuthorization;

namespace WpfPanel.Pages
{
    /// <summary>
    /// Логика взаимодействия для Autohrization.xaml
    /// </summary>
    public partial class Autohrization : Page
    {
        public Autohrization()
        {
            InitializeComponent();
        }

        private void btnAut(object sender, RoutedEventArgs e)
        {
            bool chek;
            Aut.Authoriz(this.login.Text, this.parol.Text, out chek);
            if(chek == true)
            {
                var b = Window.GetWindow(this) as MainWindow;
                b.OwnerFrame.Navigate(new Pages.Klienty());
            }
        }
    }
}
