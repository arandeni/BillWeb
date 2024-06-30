using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourse.BillWeb.Services
{
    public interface IDbInitial
    {
        Task SeedData();
    }
}
