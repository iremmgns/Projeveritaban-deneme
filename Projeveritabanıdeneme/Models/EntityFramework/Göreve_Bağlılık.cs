//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projeveritabanıdeneme.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Göreve_Bağlılık
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Göreve_Bağlılık()
        {
            this.Kanaat_Formu = new HashSet<Kanaat_Formu>();
        }
    
        public int Göreve_Bağlılık_Id { get; set; }
        public Nullable<int> Mesai_Saat_Uyum { get; set; }
        public Nullable<int> Görev_Sorumluluğu { get; set; }
        public Nullable<int> Görev_Yürütme { get; set; }
        public Nullable<int> Görev_Sonuç { get; set; }
        public Nullable<double> Görev_Bağlılık_Ort { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kanaat_Formu> Kanaat_Formu { get; set; }
    }
}
