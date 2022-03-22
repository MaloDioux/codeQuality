using ConsoleApp1.entities;
using ConsoleApp1.interfaces;
using System;
using System.Collections.Generic;


namespace ConsoleApp1.services
{
    public class contratService : IService<contrat>
    {
        public contratService()
        {
        }

        public int Create(contrat applicationModel)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid guid)
        {
            throw new NotImplementedException();
        }

        public contrat GetByIdAsync(Guid guid)
        {
            throw new NotImplementedException();
        }

        public contrat GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public List<contrat> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public bool UpdateAsync(contrat applicationModel)
        {
            throw new NotImplementedException();
        }
    }
}