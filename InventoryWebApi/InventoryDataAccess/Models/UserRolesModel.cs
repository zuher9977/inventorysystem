﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryDataAccess.Models
{
    public class UserRolesModel
    {
        public string UserId { set; get; }
        public string RoleId { set; get; }
        public bool isSelected { set; get; }
        public string RoleName { set; get; }
    }
}
