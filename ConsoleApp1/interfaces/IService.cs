using System;
using System.Collections.Generic;


namespace ConsoleApp1.interfaces
{
    public interface IService<T>
    {
        int Create(T applicationModel);

        bool Delete(Guid guid);

        List<T> GetListAsync();

        T GetByIdAsync(Guid guid);

        T GetByNameAsync(string name);

        bool UpdateAsync(T applicationModel);
    }
}