using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8.Models
{
    public class ShoppingCartView : BindableObject
    {
        private ObservableCollection<ShoppingCart> _cartItems = new ObservableCollection<ShoppingCart>();
        public ObservableCollection<ShoppingCart> CartItems
        {
            get => _cartItems;
            set { _cartItems = value; OnPropertyChanged(); }
        }
    }
}
