using System;
using System.Collections.Generic;

namespace Nothwind.Common.DTO
{
    public class EmployeesDTO
    {
        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime DoB { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public byte[] Photo { get; set; }
        public string Notes { get; set; }
        public int? ReportsTo { get; set; }
        public string PhotoPath { get; set; }
        public string ReportsToNavigation { get; set; }
        //TODO Work out the collection of employee territories
        //public virtual ICollection<EmployeeTerritories> EmployeeTerritories { get; set; }
        public ICollection<string> InverseReportsToNavigation { get; set; }
        public ICollection<string> Orders { get; set; }
    }
}
