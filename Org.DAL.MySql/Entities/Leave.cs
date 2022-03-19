﻿using System;
using Org.Common.Domain;
using Org.Common.Model;

namespace Org.DAL.MySql.Entities
{
    internal class Leave
    {
        public int Id { get; set; }
        
        public string From { get; set; }
        public string To { get; set;}
        public LeaveStatus Status { get; set; }
        
        public string ApprovedById { get; set; }
        public EmployeePortalUser ApprovedBy { get; set; }
        
        public string LeaveUserId { get; set; }
        public EmployeePortalUser LeaveUser { get; set; }
        
        public string Message { get; set; }
    }
}