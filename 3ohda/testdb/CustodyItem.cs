
namespace _3ohda.testdb;

public partial class CustodyItem
{
    public int Id { get; set; }

    public int? ItemId { get; set; }

    public int? CustodyId { get; set; }

    public int? CustodyItemStatusId { get; set; }

    public DateTime? DateReturned { get; set; }

    public virtual Custody? Custody { get; set; }

    public virtual CustodyItemStatus? CustodyItemStatus { get; set; }

    public virtual Item? Item { get; set; }
}
