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
using ООО_Посуда.Models;

namespace ООО_Посуда.Windows
{
    /// <summary>
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        public Autorization()
        {
            InitializeComponent();
            Classes.ConstantData.auth = this;
        }
        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text.Length != 0 && Password.Text.Length != 0)
            {
                Users users = App.context.Users.ToList().Find(u => u.UserLogin == Login.Text && u.UserPassword == Password.Text);
                if (users != null)
                {
                    Product product = new Product();
                    product.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("неверный");
            }
            else
                MessageBox.Show("Заполните поля");
        }

        private void GuestEnter_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product.Show();
            this.Hide();
        }
    }
}
