using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Repository
{
    public interface Repository<T> where T : class
    {
        List<T> GetAll(Entity entity);
        List<T> ExecuteNative(Entity entity, String query);
        T GetSpecific(Entity entity);
        void Save(Entity entity);

        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
