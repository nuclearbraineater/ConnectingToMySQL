using DataLibrary;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WpfSpiceShelf
{
    public class SpiceDataAccess
    {
        private readonly IDataAccess _dataAccess;

        public SpiceDataAccess(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess ?? throw new ArgumentNullException($"{nameof(IDataAccess)} not available");
        }

        public async Task<List<SpiceModel>> GetSpices()
        {
            var sql = "select * from spice";
            var spices = await _dataAccess.LoadData<SpiceModel, dynamic>(sql, new { }, "Server=127.0.0.1;Port=3306;database=spice_shelf;user id=sk;password=sk1234");

            return spices;
        }
    }
}
