using System;
namespace shoppinglist.Shared
{
    public class ShoppingItem
    {
        private string _title;
        private Boolean _isBought;
        public ShoppingItem(string t, bool b = false)
        {
            _title = t;
        }
        public string titlex
        {
            get { return _title; }
            set { _title = value; }
        }

        public bool isBought
        {
            get { return _isBought; }
            set { _isBought = value; }
        }
    }
}
