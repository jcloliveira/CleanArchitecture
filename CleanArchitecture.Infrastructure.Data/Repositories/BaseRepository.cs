using CleanArchitecture.Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class BaseRepository : IBaseRepository
    {
        private readonly IConfiguration _configuration;
        public BaseRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection GetConnection()
        {
            try
            {
                return new OracleConnection(_configuration.GetConnectionString("OracleConnectionString"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
