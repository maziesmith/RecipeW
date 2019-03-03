using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeRepository
{
    public interface IRecipeDOA<T>
    {
        T Add(T obj);
        T getByName(String Name);
        T getById(double Id);
        List<T> GetListOf(T obj);
        int Remove(T obj);

    }
}
