using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Models;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using Microsoft.Data.SqlClient;

namespace CarRental.Repositories
{
    public abstract class RepositoryBase
    {
        private readonly string _connectionString;
        public RepositoryBase()
        {
            _connectionString = "Server=(local); Database=MVVMLogicDb; Integrated Security=true; Encrypt=True;TrustServerCertificate=True"; 
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }

}
