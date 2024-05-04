
namespace _3ohda.testdb;

public partial class Item
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? CategoryId { get; set; }

    public string? SerialNumber { get; set; }

    public string? Place { get; set; }

    public int? StatusId { get; set; }

    public string? Notes { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<CustodyItem> CustodyItems { get; set; } = new List<CustodyItem>();

    public virtual ItemStatus? Status { get; set; }
}
