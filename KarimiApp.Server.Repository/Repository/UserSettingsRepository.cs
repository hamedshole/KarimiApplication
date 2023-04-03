using KarimiApp.Interface.Server;
using KarimiApp.Model;

namespace KarimiApp.Server.Repository.Repository
{
    internal class UserSettingsRepository : IUserSettings
    {
        private readonly IUserSettings repository;

        public UserSettingsRepository(IUserSettings repository)
        {
            this.repository = repository;
        }

        UserSettingsModel IUserSettings.Get(UserSettingsModel model)
        {
            var res = repository.Get(model);
            return res;
        }

        string IUserSettings.Insert(UserSettingsModel model)
        {
            var res = repository.Insert(model);
            return res;
        }
    }
}
