using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using SampleDataSource.Store;
using System.Collections.ObjectModel;

namespace SampleDataTest.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            Products = new ObservableCollection<Product>(StoreData.GetProudcts(10));

            ShowDetailCommand = new RelayCommand<Product>(p =>
              {
                  Messenger.Default.Send<Product>(p, "ProductDetailsWindow");
              }, p =>
           {
               bool flag = this.Products.Count > 0;
               return flag;
           });

            AddNewOneCommand = new RelayCommand<Product>(p =>
              {
                  Messenger.Default.Send<Product>(p, "ProductDetailsWindow");
              });

        }
        public RelayCommand<Product> ShowDetailCommand { get; set; }
        public RelayCommand<Product> AddNewOneCommand { get; set; }


        public ObservableCollection<Product> Products { get; set; }

    }
}