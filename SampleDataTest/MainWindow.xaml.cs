using GalaSoft.MvvmLight.Messaging;
using SampleDataSource.Store;
using SampleDataTest.ViewModel;
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

namespace SampleDataTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Messenger.Default.Register<Product>(this,"ProductDetailsWindow", p =>
            {
                ProductDetailsView pdv = new ProductDetailsView();
                pdv.DataContext = new ProductDetailsViewModel() { CurrentProduct = p };
                pdv.Show();
            });

            this.Unloaded += (s, e) =>
            {
                Messenger.Default.Unregister(this);
            };

            if (this.lst.Items.Count>0)
            {
                lst.SelectedIndex = 0;
            }
        }
    }
}
