
namespace _3ohda.testdb;

public partial class Custody
{
    public int Id { get; set; }

    public int? PersonelId { get; set; }

    public DateTime? DateTaken { get; set; }

    public string? PlaceTaken { get; set; }

    public virtual ICollection<CustodyItem> CustodyItems { get; set; } = new List<CustodyItem>();

    public virtual Personel? Personel { get; set; }
}
