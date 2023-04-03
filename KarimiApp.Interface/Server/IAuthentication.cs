using KarimiApp.Model;

namespace KarimiApp.Interface.Server
{
    public interface IAuthentication
    {
        UserModel Login(UserModel user);
        UserSettingsModel GetUserSettings(UserRoleModel userRole);
    }
}
