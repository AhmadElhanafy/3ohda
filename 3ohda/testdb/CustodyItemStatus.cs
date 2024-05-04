
namespace _3ohda.testdb;

public partial class CustodyItemStatus
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<CustodyItem> CustodyItems { get; set; } = new List<CustodyItem>();
}
