﻿using CafeManagement.Services.VModels;

namespace CafeManagement.Services.Services
{
    public interface IRoleServices
    {
        public IEnumerable<RoleVM> GetRoles();
        public IEnumerable<RoleVM> GetRolesByName(string name);
        public RoleVM GetRoleById(int id);
        public RoleVM CreateRole(RoleM Role);
        public RoleVM UpdateRole(RoleVM Role, int id);
        public bool DeleteRole(int id);
    }
}
