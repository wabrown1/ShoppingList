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

namespace ShopList
{
    /// <summary>
    /// Interaction logic for AddToShopListControl.xaml
    /// </summary>
    public partial class AddToShopListControl : UserControl
    {
        public AddToShopListControl()
        {
            InitializeComponent();
            AddButton.Click += OnAddButtonClicked;
            ItemToAdd.KeyDown += OnTBKeyDown;
        }

        public void OnAddButtonClicked(object sender, RoutedEventArgs e)
        {
            //var data = (ShopListData)DataContext; //throws error if not possible
            //var data = DataContext as ShopListData; //assigns null if not possible
            if(DataContext is ShopListData data)
            {
                data.Add(ItemToAdd.Text);
                ItemToAdd.Text = "";
            }
        }

        public void OnTBKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Return)
            {
                var data = DataContext as ShopListData;
                data.Add(ItemToAdd.Text);
                ItemToAdd.Text = "";
            }
        }
    }
}
