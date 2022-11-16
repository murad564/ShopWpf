using ShopProgramWpf.FakeDatas;
using ShopProgramWpf.UserControls;
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

namespace ShopWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Uc_Control product;
        public MainWindow()
        {
            InitializeComponent();


            DataContext = this;

            FakeProducts Products = new();

            int count = 0;
            float cost;
            foreach (var item in Products.products)
            {
                count = item.Count;
                cost = item.Cost;
                Uc_Control uc_Control = new(count,cost);
                uc_Control.product = item;
                firstrow.Children.Add(uc_Control);
                
            }

        }

        private void Total_Click(object sender, RoutedEventArgs e)
        {
            float sum = 0.0f;
            //float Sum=0.0f;
            foreach (var item in firstrow.Children)
            {
                product = item as Uc_Control;
                if (product is null)
                    return;
                sum += product.Sum;
            }
                MessageBox.Show(sum.ToString());
           
        }
    }
}
//