using Domain;
using MySqlConnector;
using System;
using System.Collections.Generic;
namespace Server.Repository
{
    public class GenericRepository : Repository<Entity>
    {
        private Broker _broker = new MySQLBroker();

        public List<Entity> GetAll(Entity entity)
        {
            List<Entity> list = new List<Entity>();
            MySqlCommand command = _broker.CreateCommand();
            command.CommandText = $"SELECT * FROM {entity.TableName}";
            Console.WriteLine(command.CommandText); 
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (_broker.IsConnected() && reader.Read())
                {
                    Entity entityRow = entity.ReadRow(reader);
                    list.Add(entityRow);
                }
            }
            return list;
        }

        public Entity GetSpecific(Entity entity)
        {
            MySqlCommand command = _broker.CreateCommand();
            command.CommandText = $"SELECT * FROM {entity.TableName} WHERE {entity.WhereCondition}";
            Entity specificEntity = null;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (_broker.IsConnected() && reader.Read())
                {
                    specificEntity = entity.ReadRow(reader);
                }
            }
            return specificEntity;
        }

        public List<Entity> ExecuteNative(Entity entity, string query)
        {
            List<Entity> list = new List<Entity>();
            MySqlCommand command = _broker.CreateCommand();
            command.CommandText = query;
            try
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (_broker.IsConnected() && reader.Read())
                    {
                        Entity entityRow = entity.ReadRow(reader);
                        list.Add(entityRow);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine (e.Message);
            }

            return list;
        }

        public void Save(Entity entity)
        {
            MySqlCommand command = _broker.CreateCommand();
            command.CommandText = $"INSERT INTO {entity.TableName} {entity.InsertValues}";
            command.ExecuteNonQuery();
        }

        public void OpenConnection()
        {
            _broker.OpenConnection();
        }

        public void BeginTransaction()
        {
            _broker.BeginTransaction();
        }

        public void CloseConnection()
        {
            _broker.CloseConnection();
        }

        public void Commit()
        {
            _broker.Commit();
        }

        public void Rollback()
        {
            _broker.Rollback();
        }
    }
}
