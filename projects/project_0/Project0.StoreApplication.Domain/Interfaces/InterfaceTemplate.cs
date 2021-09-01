using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Interfaces 
{

    public interface InterfaceTemplate<T> where T : class 
    {

    bool Insert(T entry);
    bool Drop();
    List<T> Select();
    T Update();

    }
}
