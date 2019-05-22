using System.Collections;
using System.Collections.Generic;

namespace BasketManagment
{
    public interface ISerializer
    {
        bool SaveToFile(string fileName, Basket basket);
        Basket ReadFromFile(string fileName);
    }
}
