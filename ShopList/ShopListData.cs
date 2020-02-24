using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ShopList
{
    public class ShopListData : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        List<string> items = new List<string>();

        //Hide items data by creating a copy of the data and storing as a string
        public IEnumerable<string> Items => items.ToArray();

        public void Add(string item)
        {
            items.Add(item);
            //? checks if null(no event listeners) and runs if not null
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        public void Remove(string item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
    }
}
