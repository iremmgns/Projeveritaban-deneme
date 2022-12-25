using Projeveritabanıdeneme.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeveritabanıdeneme.ViewModels
{
    public class Danisman_UzmanlıkViewModel : Controller
    {
        // GET: Danisman_Uzmanlık
        public IEnumerable<Danışman> Danışman { get; set; }
        public IEnumerable<Uzmanlık_Alanı> UzmanlıkAlanı { get; set; }
        public Kullanıcı Kullanıcı { get; set; }
        public Öğrenci Öğrenci { get; set; }
    }
}