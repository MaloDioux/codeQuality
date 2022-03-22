using System;
using System.Collections.Generic;

public interface IService<T>
{
    int Create(T applicationModel);

    bool Delete(Guid guid);

    List<T> GetListAsync();

    T GetByIdAsync(Guid guid);

    T GetByNameAsync(string name);

    bool UpdateAsync(T applicationModel);
}
