using Shop_Kilunina.Data.Models;

namespace Shop_Kilunina.Data.Interfaces
{
    public interface IItems
    {
        public IEnumerable<Items> AllItems { get; }
        public int Add(Items Item);
        public void Update(Items Item);
        public void Delete(int id);
    }
}
