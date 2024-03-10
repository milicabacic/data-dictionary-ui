using Domain;
using Common.Exceptions;
using System;
using MySqlConnector;

namespace Server
{
    public class SaveUserSO : SystemOperation
    {
        protected override void Execute(Entity entity)
        {
            try
            {
                _repository.Save(entity);
            }
            catch (MySqlException e)
            {
                throw new EntityDuplicateException("Korisnik sa datim korisnickim imenom vec postoji!");
            }
        }
    }
}
