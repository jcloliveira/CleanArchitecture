using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IBaseRepository
    {
        IDbConnection GetConnection();
    }
}
