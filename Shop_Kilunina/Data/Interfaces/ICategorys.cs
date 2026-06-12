using Shop_Kilunina.Data.Models;

namespace Shop_Kilunina.Data.Interfaces
{
    public interface ICategorys
    {
        IEnumerable<Categories> AllCategories { get; }
    }
}
