//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo.WindowsForms
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_access
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User_access()
        {
            this.Employees = new HashSet<Employees>();
        }
    
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string type { get; set; }
        public Nullable<int> id_subsidiary_companies_region { get; set; }
        public Nullable<System.DateTime> date_up { get; set; }
        public string status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employees> Employees { get; set; }
    }
}
