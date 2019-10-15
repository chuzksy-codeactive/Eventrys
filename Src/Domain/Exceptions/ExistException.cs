using System;

namespace Eventrys.Src.Domain.Exceptions
{
    public class EntityExistException : Exception
    {
        public EntityExistException(string name, object key)
            :base ($"Entity \"{name}\" ({key}) already exists in the database")
        {
            
        }
    }
}