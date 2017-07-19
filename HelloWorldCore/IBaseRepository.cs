using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCore
{

        public interface IBaseRepository
        {
            int SaveChanges();


        }

        public interface IBaseRepository<TEntity> : IBaseRepository where TEntity : class
        {
            int Create(TEntity entity);
            IList<TEntity> GetAll();
            int Delete(TEntity entity);

        }
   
}
