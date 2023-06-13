namespace Investments.Domain.Dto
{
	public record ShareDto
	{
		public long Id { get; set; }
		public decimal PurchasePrice { get; set; }
		public decimal SellPrice { get; set; }
		public DateTime? PurchaseDate { get; set; }
		public DateTime? SellDate { get; set; }
		public bool Sold { get; set; }

		public DateTime Created { get; set; }
		public DateTime Updated { get; set; }
	}
}
