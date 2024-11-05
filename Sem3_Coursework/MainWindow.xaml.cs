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
using Sem3_Coursework.Products;

namespace Sem3_Coursework
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product("Паста Карбонара", ProductGroup.SecondCourse, 320.0, "Лапша с беконом и пастой", new Uri("D:\\Programming\\C#\\University\\Sem3\\Sem3_Coursework\\Images\\"),
                new List<Ingredient> { 
                    new Ingredient("Лапша", 300, 300),
                    new Ingredient("Бекон", 100, 100)
                });
            textBlock1.Text = product.ToString();
        }
    }
}
