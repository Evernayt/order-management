using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order_Management.Database;

namespace Order_Management.Database
{
    class Synchronization
    {
        DataTable dtStatusesFilter;
        DataTable dtStatuses;
        DataTable dtShops;
        string[] services;

        public void SynchronizationRun()
        {
            dtStatusesFilter = Statuses.LoadStatusesFilter();
            dtStatuses = Statuses.LoadStatuses();
            dtShops = Shops.LoadShopsFilter();
            services = AllServices.LoadAllServices().Rows.OfType<DataRow>().Select(dr => dr.Field<string>("service")).ToArray();
        }
    }
}
