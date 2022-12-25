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
    
    public partial class Öğrenci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Öğrenci()
        {
            this.Akademik_Ders_Öğrenci = new HashSet<Akademik_Ders_Öğrenci>();
            this.Kanaat_Formu = new HashSet<Kanaat_Formu>();
            this.Yorum = new HashSet<Yorum>();
        }
    
        public int Öğrenci_Id { get; set; }
        public Nullable<int> Kullanıcı_Id { get; set; }
        public Nullable<int> Uzmanlık_Id { get; set; }
        public Nullable<int> Danışman_Id { get; set; }
        public string Öğrenci_Ad { get; set; }
        public string Öğrenci_Soyad { get; set; }
        public Nullable<System.DateTime> Öğrenci_Doğum_Tarihi { get; set; }
        public string Öğrenci_Doğum_Yeri { get; set; }
        public string Öğrenci_Uyruğu { get; set; }
        public Nullable<float> Öğrenci_DUS_Puanı { get; set; }
        public Nullable<System.DateTime> Uzmanlık_Eğitimi_Başlama_Tarihi { get; set; }
        public Nullable<System.DateTime> Uzmanlık_Eğitimi_Tamamlama_Tarihi { get; set; }
        public Nullable<int> Psf_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Akademik_Ders_Öğrenci> Akademik_Ders_Öğrenci { get; set; }
        public virtual Danışman Danışman { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kanaat_Formu> Kanaat_Formu { get; set; }
        public virtual Kullanıcı Kullanıcı { get; set; }
        public virtual Uzmanlık_Alanı Uzmanlık_Alanı { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yorum> Yorum { get; set; }
    }
}
