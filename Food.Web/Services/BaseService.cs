using Food.Web.Models;
using Food.Web.Services.IServices;

namespace Food.Web.Services
{
    public class BaseService : IBaseService
    {
        public ReponseDto reponseDto { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<T> SendAsync<T>(APIRequest apiRequest)
        {
            throw new NotImplementedException();
        }
    }
}
