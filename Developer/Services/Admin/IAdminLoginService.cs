using System.Web;
using System.Web.UI.WebControls;
using Developer.Models.ViewModels;

namespace Developer.Services.Admin
{
    public interface IAdminLoginService
    {
        LoginViewModel Login(LoginViewModel loginViewModel);
        void Logout();
        void SetLoginCookies(string userName);
        HttpCookieCollection Cookies();
    }
}