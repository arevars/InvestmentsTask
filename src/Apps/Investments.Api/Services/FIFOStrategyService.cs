using Investments.Domain.Models;

namespace Investments.Api.Services
{
	public class FIFOStrategyService : IFIFOStrategyService
	{
		public async Task<int> GetRemainingCountOfSharesAsync()
		{
			// Get all my shares from repository asynchronously
			//@TODO implement this
			//List<Share> shares = await repository.GetAllSharesAsync();

			List<Share> shares = new List<Share>();

			// Perform calculations asynchronously
			int count = await Task.Run(() => shares.Count(x => x.Sold));

			return count;
		}

		public Task<int> GetCostBasisOfSoldShares()
		{
			throw new NotImplementedException();
		}

		public Task<int> GetCostBasisOfRemainingShares()
		{
			throw new NotImplementedException();
		}

		public Task<int> GetNet()
		{
			throw new NotImplementedException();
		}
	}
}
