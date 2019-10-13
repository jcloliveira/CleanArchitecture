using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface ICleanArchitectureRepository
    {
        IEnumerable<CleanArch> GetCleanArchitectures();
    }
}
