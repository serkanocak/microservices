using Ocak.Services.RewardAPI.Message;

namespace Ocak.Services.RewardAPI.Services
{
    public interface IRewardService
    {
        Task UpdateRewards(RewardsMessage rewardsMessage);
    }
}
