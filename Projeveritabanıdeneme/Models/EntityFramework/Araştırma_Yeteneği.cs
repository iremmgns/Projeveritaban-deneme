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
    
    public partial class Araştırma_Yeteneği
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Araştırma_Yeteneği()
        {
            this.Kanaat_Formu = new HashSet<Kanaat_Formu>();
        }
    
        public int Araştırma_Yeteneği_Id { get; set; }
        public Nullable<int> Araştırma_İsteği { get; set; }
        public Nullable<int> Yürütme_Sonuç { get; set; }
        public Nullable<int> Kaynak_Verimli_Kullanma { get; set; }
        public Nullable<int> Yayın_Yapma_Becerisi { get; set; }
        public Nullable<double> Araştırma_Yetenek_Ort { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kanaat_Formu> Kanaat_Formu { get; set; }
    }
}
