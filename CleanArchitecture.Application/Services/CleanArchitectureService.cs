using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Services
{
    public class CleanArchitectureService : ICleanArchitectureService
    {
        private readonly ICleanArchitectureRepository _cleanArchitectureRepository;
        private readonly ILogger<CleanArchitectureService> _logger;

        public CleanArchitectureService(ICleanArchitectureRepository cleanArchitectureRepository, 
            ILogger<CleanArchitectureService> logger)
        {
            _logger = logger;
            _cleanArchitectureRepository = cleanArchitectureRepository;
        }

        public CleanArchitectureViewModel GetCleanArchitectures()
        {
            return new CleanArchitectureViewModel()
            {
                CleanArchitectures = _cleanArchitectureRepository.GetCleanArchitectures()
            };            
        }
    }
}
