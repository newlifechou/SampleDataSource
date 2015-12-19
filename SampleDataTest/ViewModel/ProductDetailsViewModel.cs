using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SampleDataSource.Store;
using System.Windows;

namespace SampleDataTest.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class ProductDetailsViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the ProductDetailsViewModel class.
        /// </summary>
        public ProductDetailsViewModel()
        {
            SaveCommand = new RelayCommand<Product>(p =>
              {
                  string result = string.Format("Save Successful={0}", p.ProductName);
                  MessageBox.Show(result);
              });
        }
        public RelayCommand<Product> SaveCommand { get; set; }
        public Product CurrentProduct { get; set; }
    }

}