//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MasterPolIlyasov
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Partner_Product = new HashSet<Partner_Product>();
            this.Suplly = new HashSet<Suplly>();
        }
    
        public int ID_employees { get; set; }
        public string Employees_Surname { get; set; }
        public string Employees_Firstname { get; set; }
        public string Employees_Patronymic { get; set; }
        public System.DateTime Employees_Birthday { get; set; }
        public string Employess_PassportSeries { get; set; }
        public string Employess_PassportNumber { get; set; }
        public string Employees_WhoIssued { get; set; }
        public System.DateTime Employees_DateOfIssue { get; set; }
        public string Employees_DepartamentCode { get; set; }
        public string Employess_BankAccountNumber { get; set; }
        public string Employess_INN { get; set; }
        public string Employess_CoresspAccountNumber { get; set; }
        public string Employess_BIK { get; set; }
        public string Employess_BankName { get; set; }
        public string Employess_Family { get; set; }
        public string Employess_Health { get; set; }
        public int Employe_Role { get; set; }
    
        public virtual Role Role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Partner_Product> Partner_Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Suplly> Suplly { get; set; }
    }
}
