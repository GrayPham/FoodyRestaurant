using Food.Web.Models;

namespace Food.Web.Services.IServices
{
    public interface IBaseService:IDisposable
    {
        ResponseDto responseModel { get; set; }
        Task<T> SendAsync<T>(APIRequest apiRequest);
        
    }
}
