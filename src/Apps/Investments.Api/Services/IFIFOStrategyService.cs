namespace Investments.Api.Services
{
	public interface IFIFOStrategyService
	{
		Task<int> GetRemainingCountOfSharesAsync();
		Task<int> GetCostBasisOfSoldShares();
		Task<int> GetCostBasisOfRemainingShares();
		Task<int> GetNet();
	}
}
