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
    
    public partial class Mesleki_Ahlak
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mesleki_Ahlak()
        {
            this.Kanaat_Formu = new HashSet<Kanaat_Formu>();
        }
    
        public int Mesleki_Ahlak_Id { get; set; }
        public Nullable<int> Öğrenci_İlişkiler { get; set; }
        public Nullable<int> Uzman_İlişkiler { get; set; }
        public Nullable<int> Çalışan_İlişkiler { get; set; }
        public Nullable<int> Hasta_İlişkiler { get; set; }
        public Nullable<int> Diğer_İlişkiler { get; set; }
        public Nullable<double> Mesleki_Ahlak_Ort { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kanaat_Formu> Kanaat_Formu { get; set; }
    }
}
