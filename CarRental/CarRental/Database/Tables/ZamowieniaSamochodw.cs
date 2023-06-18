using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Database.Tables
{
    public class ZamowieniaSamochodw
    {
        public int ID { get; set; }
        public int SamochodID { get; set; }
        public DateTime DataZamowienia { get; set; }
        public int StatusID { get; set; }
    }
}
