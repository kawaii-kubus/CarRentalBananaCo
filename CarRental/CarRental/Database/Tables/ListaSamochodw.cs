using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Database.Tables
{
    public class ListaSamochodw
    {
        public int ID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Nadwozie { get; set; }
        public string MocSilnika { get; set; }
        public int StatusID { get; set; }
    }
}
