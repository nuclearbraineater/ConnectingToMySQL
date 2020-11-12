using System.Collections.Generic;
using System.ComponentModel;

namespace WpfSpiceShelf
{
    public class SpiceModel : INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private int _quantity;

        public int Id
        {
            get { return _id; }
            set
            {
                if (value != _id)
                {
                    _id = value;
                    NotifyPropertyChanged(nameof(Id));
                }
            }
        }
        public string Name 
        {
            get { return _name; }
            set 
            {
                if(value != _name)
                {
                    _name = value;
                    NotifyPropertyChanged(nameof(Name));
                }
            }
        }
        public int Quantity
        {
            get { return _quantity; }
            set 
            {
                if (value != _quantity)
                {
                    _quantity = value;
                    NotifyPropertyChanged(nameof(Quantity));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

    }
}
