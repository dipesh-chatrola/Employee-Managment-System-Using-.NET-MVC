//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeManagementSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_EmpPersonalInformations
    {
        public int Id { get; set; }
        public int Employee_ID { get; set; }
        public string PassportNo { get; set; }
        public Nullable<System.DateTime> Passport_Exp_Date { get; set; }
        public string Tel { get; set; }
        public string Nationality { get; set; }
        public string Religion { get; set; }
        public string Maritalstatus { get; set; }
    
        public virtual t_Employees t_Employees { get; set; }
    }
}
