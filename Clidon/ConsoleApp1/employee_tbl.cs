//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class employee_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public employee_tbl()
        {
            this.employee_tbl1 = new HashSet<employee_tbl>();
        }
    
        public string empid { get; set; }
        public string lastname { get; set; }
        public string firstname { get; set; }
        public Nullable<System.DateTime> brithdate { get; set; }
        public Nullable<int> position { get; set; }
        public string phone { get; set; }
        public string adress { get; set; }
        public string city { get; set; }
        public string managerid { get; set; }
        public Nullable<System.DateTime> datehire { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<employee_tbl> employee_tbl1 { get; set; }
        public virtual employee_tbl employee_tbl2 { get; set; }
    }
}