using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAysnc(RequestDto requestDto, bool withBearer = true);
    }
}
