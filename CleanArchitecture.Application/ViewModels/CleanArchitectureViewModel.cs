using CleanArchitecture.Domain.Models;
using System.Collections.Generic;

namespace CleanArchitecture.Application.ViewModels
{
    public class CleanArchitectureViewModel
    {
        public IEnumerable<CleanArch> CleanArchitectures { get; set; }
    }
}
