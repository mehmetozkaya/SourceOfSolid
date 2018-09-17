using ClientPatientManagement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPatientManagement.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly CrudContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public Repository()
        {

        }
        public Repository(CrudContext context)
        {
            this._context = context;
            this._dbSet = context.Set<TEntity>();
        }


    }
}
