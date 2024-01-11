using Ocak.Services.EmailAPI.Message;
using Ocak.Services.EmailAPI.Models.Dto;

namespace Ocak.Services.EmailAPI.Services
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
        Task RegisterUserEmailAndLog(string email);
        Task LogOrderPlaced(RewardsMessage rewardsDto);
    }
}
