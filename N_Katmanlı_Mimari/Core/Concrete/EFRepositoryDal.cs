using Core.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace Core.Concrete
{
    public class EFRepositoryDal<TEntity, TContext> : IRepositoryBase<TEntity>
		where TEntity : class, IEntity, new()
		where TContext : DbContext, new()
	{


		public void Add(TEntity entity)
		{
			using (TContext context = new TContext())
			{ 
				var addedEntity = context.Entry(entity);
				addedEntity.State = EntityState.Added;
				context.SaveChanges();
		    }
		}

		public void Delete(TEntity entity)
		{
			using (TContext context = new TContext())
			{
				var deletedEntity = context.Entry(entity);

				deletedEntity.State = EntityState.Deleted;

				context.SaveChanges();
			}
		}

		public TEntity Get(Expression<Func<TEntity, bool>> filter)
		{
			using (TContext context = new TContext())
			{
				return context.Set<TEntity>().SingleOrDefault(filter);
			}
		}

		public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
		{
			using (TContext context = new TContext())
			{           //filter boş mu     EVET ise bütün datayı döndür           HAYIR ise filtreyi uygula 
				return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
			}

		}

        public TEntity GetById(int id)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public void Update(TEntity entity)
		{
			using (TContext context = new TContext())
			{
				var updatedEntity = context.Entry(entity);

				updatedEntity.State = EntityState.Modified;

				context.SaveChanges();
			}
		}
	}
}
