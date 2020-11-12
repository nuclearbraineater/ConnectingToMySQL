using DataLibrary;
using System;
using System.Collections.ObjectModel;

namespace WpfSpiceShelf
{
    public class SpiceViewModel
    {
        private ObservableCollection<SpiceModel> _spices = new ObservableCollection<SpiceModel>();
        SpiceDataAccess _dataAccess;

        public SpiceViewModel()
        {
            _dataAccess = new SpiceDataAccess(new DataAccess());
        }

        public ObservableCollection<SpiceModel> Spices
        {
            get { return _spices; }
            set { _spices = value; }
        }

        internal void GetSpices()
        {
            var spices = _dataAccess.GetSpices().Result;
            
            foreach(var spice in spices)
            {
                Spices.Add(spice);
            }
        }
    }
}
