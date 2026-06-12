using Shop_Kilunina.Data.Models;

namespace Shop_Kilunina.Data.ViewModell
{
    public class VMUpdate
    {
        public Items Item { get; set; }
        public IEnumerable<Categories> Categories { get; set; }
    }
}
