using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KarimiApp.Model;

namespace KarimiApp.Interface.Server
{
    public interface IUserSettings 
    {
        string Insert(UserSettingsModel model);
        UserSettingsModel Get(UserSettingsModel model = null);
    }
}
