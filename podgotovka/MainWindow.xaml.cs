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
using System.IO;

namespace podgotovka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void in_click(object sender, RoutedEventArgs e)
        {
            User user = DataBaseContext.GetContext().User.FirstOrDefault(p => p.UserLogin == loginTextBox.Text && p.UserPassword == passwordTextBox.Password);
            if (user != null)
            {
                Window1 window1 = new Window1();
                window1.Show();
                window1.Owner = this;
                this.Hide();
            }
            else MessageBox.Show("Net");


        }
    }
}
