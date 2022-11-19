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
    
    public partial class t_Employees
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_Employees()
        {
            this.t_PersonalInformations = new HashSet<t_PersonalInformations>();
            this.t_EmpBankInformations = new HashSet<t_EmpBankInformations>();
            this.t_EmpEmergencyContact = new HashSet<t_EmpEmergencyContact>();
            this.t_EmpPersonalInformations = new HashSet<t_EmpPersonalInformations>();
        }
    
        public int Employee_ID { get; set; }
        public Nullable<int> RefHRID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Mobileno { get; set; }
        public Nullable<System.DateTime> JoiningDate { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public string Password { get; set; }
    
        public virtual HR_SignUp HR_SignUp { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_PersonalInformations> t_PersonalInformations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_EmpBankInformations> t_EmpBankInformations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_EmpEmergencyContact> t_EmpEmergencyContact { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_EmpPersonalInformations> t_EmpPersonalInformations { get; set; }
    }
}
