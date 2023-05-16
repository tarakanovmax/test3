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

namespace podgotovka
{
    /// <summary>
    /// Логика взаимодействия для UserPge.xaml
    /// </summary>
    public partial class UserPge : Page
    {
        public UserPge()
        {
            InitializeComponent();
            DGridUser.ItemsSource = DataBaseContext.GetContext().User.ToList();
        }

        private void RedUser_click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddUserPage((sender as Button).DataContext as User));
        }

        private void AddUser_click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddUserPage(null));
        }

        private void DelUser_click(object sender, RoutedEventArgs e)
        {
            var UserforRemoving = DGridUser.SelectedItems.Cast<User>().ToList();

            if(MessageBox.Show($"Вы действительно хотите удалить следующие {UserforRemoving.Count()} элементов? ", "Внимание!",
               MessageBoxButton.YesNo, MessageBoxImage.Question ) == MessageBoxResult.Yes)
            {
                try
                {
                    DataBaseContext.GetContext().User.RemoveRange(UserforRemoving);
                    DataBaseContext.GetContext().SaveChanges();
                    MessageBox.Show("Удаление прошло успешно");
                    DGridUser.ItemsSource = DataBaseContext.GetContext().User.ToList();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Search_box(object sender, TextChangedEventArgs e)
        {
            DGridUser.ItemsSource = DataBaseContext.GetContext().User.Where(p => p.UserName == TBoxSearch.Text || p.UserName.Contains(TBoxSearch.Text)).ToList();
        }

        private void UserIsvisiblity(object sender, DependencyPropertyChangedEventArgs e)
        {
            if( Visibility == Visibility.Visible)
            {
                DataBaseContext.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridUser.ItemsSource = DataBaseContext.GetContext().User.ToList();

            }
        }
    }
}
