using MangoWeb.Models;

namespace MangoWeb.Services.IServices
{
    public interface IBaseService : IDisposable
    {
        Task<ResponseDto> SendAsync(ApiRequest apiRequest);
    }
}
