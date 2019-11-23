﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TaskRegiser.Core
{
    public static class RolesResource
    {
        
        public const string Admin = "Admin";
        public const string Employee = "Member";
        public static class Policy
        {
            public const string AdminOnly = Admin;
            public const string AllUsers = Admin + "," + Employee;
        }

    }
}
