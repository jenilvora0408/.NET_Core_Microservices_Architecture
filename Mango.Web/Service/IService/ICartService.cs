using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    public interface ICartService
    {
        Task<ResponseDto?> GetCartByUserIdAsync(string userId);

        Task<ResponseDto?> UpsertCartAsync(CartDto cartDto);

        Task<ResponseDto?> RemoveFromCartAsync(int CartDetailsId);

        Task<ResponseDto?> ApplyCoupon(CartDto cartDto);
    }
}
