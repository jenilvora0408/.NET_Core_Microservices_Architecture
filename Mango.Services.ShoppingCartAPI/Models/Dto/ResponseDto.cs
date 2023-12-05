namespace Mango.Services.ShoppingCartAPI.Models.Dto
{
    public class ResponseDto
    {
        public dynamic Result { get; set; }

        public bool IsSuccess { get; set; } = true;

        public string Message { get; set; } = "";
    }
}
