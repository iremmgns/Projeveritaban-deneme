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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class deneme3Entities : DbContext
    {
        public deneme3Entities()
            : base("name=deneme3Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Akademik_Ders> Akademik_Ders { get; set; }
        public virtual DbSet<Akademik_Ders_Öğrenci> Akademik_Ders_Öğrenci { get; set; }
        public virtual DbSet<Akademik_Dönem> Akademik_Dönem { get; set; }
        public virtual DbSet<Araştırma_Yeteneği> Araştırma_Yeteneği { get; set; }
        public virtual DbSet<Çalışma_Yeteneği> Çalışma_Yeteneği { get; set; }
        public virtual DbSet<Danışman> Danışman { get; set; }
        public virtual DbSet<Ders_Ekleme_Çıkarma> Ders_Ekleme_Çıkarma { get; set; }
        public virtual DbSet<Göreve_Bağlılık> Göreve_Bağlılık { get; set; }
        public virtual DbSet<Kanaat_Formu> Kanaat_Formu { get; set; }
        public virtual DbSet<Kullanıcı> Kullanıcı { get; set; }
        public virtual DbSet<Mesleki_Ahlak> Mesleki_Ahlak { get; set; }
        public virtual DbSet<Not_Tablosu> Not_Tablosu { get; set; }
        public virtual DbSet<Öğrenci> Öğrenci { get; set; }
        public virtual DbSet<Uzmanlık_Alanı> Uzmanlık_Alanı { get; set; }
        public virtual DbSet<Yorum> Yorum { get; set; }
        public virtual DbSet<Yönetme_Yeteneği> Yönetme_Yeteneği { get; set; }
    
        public virtual ObjectResult<string> danismannameeee(Nullable<int> danışman_Id)
        {
            var danışman_IdParameter = danışman_Id.HasValue ?
                new ObjectParameter("Danışman_Id", danışman_Id) :
                new ObjectParameter("Danışman_Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("danismannameeee", danışman_IdParameter);
        }
    }
}
