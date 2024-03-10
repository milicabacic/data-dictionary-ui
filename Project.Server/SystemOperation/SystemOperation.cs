using Common.Exceptions;
using Domain;
using Server.Repository;
using System;
namespace Server
{
    public abstract class SystemOperation
    {
        protected Repository<Entity> _repository = new GenericRepository();

        public void ExecuteTemplate(Entity entity)
        {
            try
            {
                _repository.OpenConnection();
                _repository.BeginTransaction();
                Execute(entity);
                _repository.Commit();
            }
            catch (Exception e)
            {
                _repository.Rollback();
                if (e is EntityDuplicateException) throw e;
            }
            finally
            {
                _repository.CloseConnection();
            }
        }

        protected abstract void Execute(Entity entity);
    }
}
