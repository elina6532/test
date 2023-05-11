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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Linq;
using System.IO;
using ООО_Посуда.Models;

namespace ООО_Посуда.UserControls
{
    /// <summary>
    /// Логика взаимодействия для ProductCard.xaml
    /// </summary>
    public partial class ProductCard : UserControl
    {
        string Article;
        public ProductCard(string Article, string Title, string Description, string Manufacture, string Cost, string Stock, decimal Sale, byte[] Img)
        {
            InitializeComponent();
            this.Article = Article; this.Title.Text = Title;
            this.Description.Text = Description; Manufactures manufacturers = App.context.Manufactures.ToList().Find(m => m.ManufactureId.ToString() == Manufacture);
            this.Manufacturer.Text += manufacturers.ManufactureName; this.Cost.Text += Cost.Split(',')[0] + " р.";
            this.Stock.Text = Stock;
            if (Sale > 15)
            {
                BackgroundSale.Background = SaleColor.Background;
            }

            if (Sale > 0)
            { 
            
                CostDiscount.Visibility = Visibility.Visible;
                this.Cost.TextDecorations = Strike.TextDecorations; CostDiscount.Text += (Convert.ToDecimal(Cost) - Convert.ToDecimal(Cost) * Sale / 100).ToString().Split(',')[0] + " р.";
            }
            try
            {
                BitmapImage img = new BitmapImage(); MemoryStream MS = new MemoryStream(Img);
                img.BeginInit(); img.StreamSource = MS;
                img.EndInit(); this.Imgs.Source = img;
            }
            catch
            { }
        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Classes.ConstantData.Article = Article; MessageBox.Show("Продукт с артикулом " + Article + " выбран для работы!");
        }
    }
}

