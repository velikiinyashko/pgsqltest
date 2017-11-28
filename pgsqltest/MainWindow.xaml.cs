using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using pgsqltest.Models;

namespace pgsqltest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Context _db = new Context();

        public List<Users> Users;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void WindowLoads(object sender, RoutedEventArgs e)
        {
            Users = _db.Users.ToList();
        }
    }
}
