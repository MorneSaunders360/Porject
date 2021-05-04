﻿using System;
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
        public Baselogic()
        {
                
        }

    }
}
