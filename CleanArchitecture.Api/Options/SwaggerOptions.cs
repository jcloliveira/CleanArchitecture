using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Api.Options
{
    public sealed class SwaggerOptions
    {
        public string DocumentName { get; set; }
        public string JsonRoute { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
    }
}
