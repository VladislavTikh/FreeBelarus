using FreeBelarus.Shared.Models.Authorization;
using System.Threading.Tasks;

namespace FreeBelarus.Client.Services
{
    public interface IAuthService
    {
        public Task<RegisterResult> Register(RegisterModel registerModel);

        public Task<LoginResult> Login(LoginModel loginModel);

        public Task Logout();
    }
}
