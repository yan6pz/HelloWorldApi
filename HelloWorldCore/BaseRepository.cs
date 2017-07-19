using HelloWorldData;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCore
{
    public abstract class BaseRepository : IBaseRepository
    {
        private HelloWorldContext _context;

        public HelloWorldContext Context
        {
            get { return _context; }
            set { _context = value; }
        }

        public BaseRepository(HelloWorldContext context)
        {
            _context = context;
        }

        public virtual int SaveChanges()
        {
            return this.Context.SaveChanges();
        }

    }

    public abstract class BaseRepository<TEntity> : BaseRepository, IBaseRepository<TEntity> where TEntity : class
    {
        public BaseRepository(HelloWorldContext context)
            : base(context)
        { }

        private DbSet<TEntity> objectSet;

        private DbSet<TEntity> ObjectSet
        {
            get
            {
                if (this.objectSet == null)
                {
                    this.objectSet = this.Context.Set<TEntity>();
                }

                return this.objectSet;
            }
        }


        public virtual int Create(TEntity entity)
        {
            this.ObjectSet.Add(entity);

            return this.SaveChanges();
        }

        public IList<TEntity> GetAll()
        {
            return this.ObjectSet.ToList();
        }

        public int Delete(TEntity entity)
        {
            DeleteWithoutSave(entity);
            return this.SaveChanges();
        }


        private void DeleteWithoutSave(TEntity entity)
        {
            this.ObjectSet.Remove(entity);
        }
    }
}
