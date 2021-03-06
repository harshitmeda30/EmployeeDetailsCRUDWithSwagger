using EmployeeDetailsCRUDWithSwagger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetailsCRUDWithSwagger.Repository
{
    public interface IEmployeeRepository
    {
        void Create(MEmployee item);
        MEmployee GetById(int Id);
        List<MEmployee> GetAll();
        void Update(int id, MEmployee item);
        void Delete(int Id);
    }
}
