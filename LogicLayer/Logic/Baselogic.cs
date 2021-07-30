using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Logic
{
    public class Baselogic<T>
    {
        public RepoLayer.Repo.PortalDeviceRepo<T> PortalDeviceRepo = new RepoLayer.Repo.PortalDeviceRepo<T>();
        public RepoLayer.Repo.PortalUserDeviceRepo<T> PortalUserDeviceRepo = new RepoLayer.Repo.PortalUserDeviceRepo<T>();
        public RepoLayer.Repo.PortalUserRepo<T> PortalUserRepo = new RepoLayer.Repo.PortalUserRepo<T>();
        public RepoLayer.Repo.PortalUserOrganizationRepo<T> PortalUserOrganizationRepo = new RepoLayer.Repo.PortalUserOrganizationRepo<T>();
        public RepoLayer.Repo.PortalNotificationRepo<T> PortalNotificationRepo = new RepoLayer.Repo.PortalNotificationRepo<T>();
        public RepoLayer.Repo.PortalSettingsRepo<T> PortalSettingsRepo = new RepoLayer.Repo.PortalSettingsRepo<T>();
        public RepoLayer.Repo.PortalDeviceUsageRepo<T> PortalDeviceUsageRepo = new RepoLayer.Repo.PortalDeviceUsageRepo<T>();
        public RepoLayer.Repo.PortalWalletRepo<T> PortalWalletRepo = new RepoLayer.Repo.PortalWalletRepo<T>();
        public RepoLayer.Repo.PortalUserWalletRepo<T> PortalUserWalletRepo = new RepoLayer.Repo.PortalUserWalletRepo<T>();
        public RepoLayer.Repo.PortalUserWalletDetailsRepo<T> PortalUserWalletDetailsRepo = new RepoLayer.Repo.PortalUserWalletDetailsRepo<T>();
        public Baselogic()
        {
                
        }

    }
}
