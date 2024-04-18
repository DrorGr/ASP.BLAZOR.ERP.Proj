﻿
namespace BaseLibrary.Entities
{
    public class Employee : BaseEntity
    {
        public string? CivilId { get; set; }

        public string? FileNumber { get; set; }

        public string? FullName { get; set; }

        public string? JobName { get; set; }

        public string? TelephoneNumber { get; set; }

        public string? Photo { get; set; }

        public string? Other { get; set; }


        public GeneralDepartment? GeneralDepartment { get; set; }

        public int GeneralDepartmentId { get; set; }

        public int DepartmentId { get; set; }

        public Branch? Branch { get; set; }
        public int? BranchId { get; set; }
        
        public Town? Town { get; set; }
    
        public int TownId { get; set; }


    }
}
    