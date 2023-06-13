using Investments.Infrastructure.Enum;

namespace Investments.Domain.Models;

public record Share
{
	public decimal PurchasePrice { get; set; }
	public decimal SellPrice { get; set; }
	public DateTime? PurchaseDate { get; set; }
	public DateTime? SellDate { get; set; }
	public bool Sold { get; set; }

	public ShareCompanyTypes ShareCompanyType { get; set; }
}
