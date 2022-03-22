using ConsoleApp1.entities;
using ConsoleApp1.interfaces;
using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 
namespace ConsoleApp1.services
{
    public class prospectService : IService<prospect>
    {
        public prospectService()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public int Create(prospect applicationModel)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid guid)
        {
            throw new NotImplementedException();
        }

        public prospect GetByIdAsync(Guid guid)
        {
            throw new NotImplementedException();
        }

        public prospect GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public List<prospect> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public bool UpdateAsync(prospect applicationModel)
        {
            throw new NotImplementedException();
        }
    }
}
