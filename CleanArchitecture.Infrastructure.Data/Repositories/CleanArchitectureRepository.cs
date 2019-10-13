using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class CleanArchitectureRepository : ICleanArchitectureRepository
    {
        private readonly IBaseRepository _baseRepository;
        private readonly ILogger<CleanArchitectureRepository> _logger;

        public CleanArchitectureRepository(IBaseRepository baseRepository, 
            ILogger<CleanArchitectureRepository> logger)
        {
            _logger = logger;
            _baseRepository = baseRepository;
        }

        public IEnumerable<CleanArch> GetCleanArchitectures()
        {
            using(var conn = _baseRepository.GetConnection())
            {
                conn.Open();
            }
            return new List<CleanArch>();
        }
    }
}
