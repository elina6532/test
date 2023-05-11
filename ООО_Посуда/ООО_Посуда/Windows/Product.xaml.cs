using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ООО_Посуда.Models;
using System.Linq;

namespace ООО_Посуда.Windows
{
    /// <summary>
    /// Логика взаимодействия для Product.xaml
    /// </summary>
    public partial class Product : Window
    {
        public Product()
        {
            InitializeComponent();
            LoadData();
            Classes.ConstantData.con.Open();
        }
        private void Desc_Checked(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void Asc_Checked(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void Filtration_DropDownClosed(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            ProductView.Children.Clear();
            List<Models.Products> list = App.context.Products.ToList();
            if (Filtration.SelectedItem != null)
            {
                switch (Filtration.SelectedIndex)
                {
                    case 0:
                        list = App.context.Products.ToList();
                        break;
                    case 1:
                        list = list.Where(p => p.ProductDiscountAmount > 0 && p.ProductDiscountAmount < Convert.ToDecimal(9.99)).ToList();
                        break;
                    case 2:
                        list = list.Where(p => p.ProductDiscountAmount > 10 && p.ProductDiscountAmount < Convert.ToDecimal(14.99)).ToList();
                        break;
                    case 3:
                        list = list.Where(p => p.ProductDiscountAmount > 15 && p.ProductDiscountAmount < 100).ToList();
                        break;
                }
            }
            if (Search.Text.Length != 0)
                list = list.Where(p => p.ProductName.Contains(Search.Text)).ToList();
            if (Asc.IsChecked == true)
                list = list.OrderBy(p => p.ProductCost).ToList();
            else if (Desc.IsChecked == true)
                list = list.OrderByDescending(p => p.ProductCost).ToList();

            foreach (var item in list)
                ProductView.Children.Add(new UserControls.ProductCard(item.ProductArticleNumber, item.ProductName, item.ProductDescription, item.ProductManufacturer.ToString(), item.ProductCost.ToString(), item.ProductQuantityInStock.ToString(), Convert.ToDecimal(item.ProductDiscountAmount), item.ProductPhoto));
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Classes.ConstantData.auth.Show();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand("DELETE FROM Products WHERE ProductArticleNumber = '" + Classes.ConstantData.Article + "'", Classes.ConstantData.con);
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Невозможно удалить этот продукт!");
            }
            LoadData();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }



    }
}
