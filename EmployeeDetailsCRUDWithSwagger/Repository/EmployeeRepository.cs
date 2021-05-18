using EmployeeDetailsCRUDWithSwagger.Data;
using EmployeeDetailsCRUDWithSwagger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetailsCRUDWithSwagger.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly APIDbContext _context;
        public EmployeeRepository(APIDbContext context)
        {
            _context = context;
        }
        public void Create(MEmployee item)
        {
            _context.Emp.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var entity = _context.Emp.Find(Id);
            if (entity == null)
            {
                return;
            }
            _context.Emp.Remove(entity);
            _context.SaveChanges();
        }

        public List<MEmployee> GetAll()
        {
            return _context.Emp.ToList();
        }

        public MEmployee GetById(int Id)
        {
            return _context.Emp.FirstOrDefault(t => t.EmpID == Id);
        }

        public void Update(int id, MEmployee item)
        {
            var entity = _context.Emp.Find(id);
            if (entity == null)
            {
                return;
            }
            _context.Entry(entity).CurrentValues.SetValues(item);
            _context.SaveChanges();
        }
    }
}
