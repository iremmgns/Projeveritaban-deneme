using Projeveritabanıdeneme.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Projeveritabanıdeneme.ViewModels;
using System.Data.SqlClient;

namespace Projeveritabanıdeneme.Controllers
{
    public class AdminController : Controller
    {
        deneme3Entities db=new deneme3Entities();
        // GET: Admin
        public ActionResult Index(string searching)
        {
            //Danisman_UzmanlıkViewModel model2 = new Danisman_UzmanlıkViewModel();
            var model1 = db.Danışman.Include(s => s.Kullanıcı);
            model1 = db.Danışman.Include(s => s.Akademik_Ders);
            //model2 = (Danisman_UzmanlıkViewModel)db.Akademik_Ders.Include(s => s.Uzmanlık_Alanı);
            //model1= (IQueryable<Danışman>)db.Akademik_Ders.Include(s=>s.Uzmanlık_Alanı);
            //model1 = from s in db.Danışman
            //          join st in db.Akademik_Ders
            //          on s.Danışman_Id equals st.Danışman_Id
            //          join u in db.Uzmanlık_Alanı
            //          on st.Uzmanlık_Id equals u.Uzmanlık_Id
            //          select new
            //          {
            //              u.Uzmanlık_Ad
            //          };
            model1 = from s in db.Danışman
                     select s;
                        if(!String.IsNullOrEmpty(searching))
            {
                model1=model1.Where(s=>s.Danışman_Ad.Contains(searching));
            }
          
            return View(model1.ToList());
        }

        public ActionResult Index3(string searching)
        {
            var model1 = db.Akademik_Ders.Include(s => s.Uzmanlık_Alanı);
            model1 = db.Akademik_Ders.Include(s => s.Danışman);

            model1 = from s in db.Akademik_Ders
                         select s;
            if (!String.IsNullOrEmpty(searching))
            {
                model1 = model1.Where(s => s.Ders_Tanımı.Contains(searching));
            }
            return View(model1.ToList());
        }

        public ActionResult Index2(string searching)
        {
            var model1 = db.Öğrenci.Include(s => s.Uzmanlık_Alanı);
            model1 = db.Öğrenci.Include(s => s.Kullanıcı);
            model1 = from s in db.Öğrenci
                         select s;
            if (!String.IsNullOrEmpty(searching))
            {
                model1 = model1.Where(s => s.Öğrenci_Ad.Contains(searching));
            }
            return View(model1.ToList());
        }

        public ActionResult danismanListele()
        {
            List<SelectListItem> isimler = (from i  in db.Danışman.ToList()
                                             select new SelectListItem
                                             {
                                                 Text=i.Danışman_Ad,
                                                 Value=i.Danışman_Id.ToString()
                                             }).ToList();
            ViewBag.isim = isimler;

            List<SelectListItem> soyisimler = (from j in db.Danışman.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = j.Danışman_Soyad,
                                                 Value = j.Danışman_Id.ToString()
                                             }).ToList();
            ViewBag.soyisim = soyisimler;

            
            return View();
        }

        [HttpPost]
        public ActionResult Kaydet(Danışman danışman)
        {

            if (danışman.Danışman_Id == 0)
            {
                db.Danışman.Add(danışman);
            }
            else
            {
                var guncellenecekDanışman = db.Danışman.Find(danışman.Danışman_Id);
                if (guncellenecekDanışman == null)
                {
                    return HttpNotFound();
                }
                guncellenecekDanışman.Danışman_Ad = danışman.Danışman_Ad;
            }
            db.SaveChanges();
            return RedirectToAction("Kaydet", "Admin");
        }
        public ActionResult Yeni()
        {
            var model = new Danisman_UzmanlıkViewModel()
            {
                UzmanlıkAlanı = db.Uzmanlık_Alanı.ToList()
            };
            return View("ÖğrenciForm", model);
        }

        [HttpPost]
        public ActionResult Kaydet2(Öğrenci öğrenci)
        {

            if (öğrenci.Öğrenci_Id == 0)
            {
                db.Öğrenci.Add(öğrenci);
            }
            else
            {
                var guncelleneceköğrenci = db.Öğrenci.Find(öğrenci.Öğrenci_Id);
                if (guncelleneceköğrenci == null)
                {
                    return HttpNotFound();
                }
                guncelleneceköğrenci.Öğrenci_Ad = öğrenci.Öğrenci_Ad;
            }
            db.SaveChanges();
            return RedirectToAction("Index2");
        }
        public ActionResult Index4()
        {
            SqlParameter[] Danışman_Id = new SqlParameter[] {
           
                new SqlParameter("@Danışman_Id",4)
          };
         var model1 = db.Database.SqlQuery<Danışman>("danismannameeee @Danışman_Id", Danışman_Id).ToList();
            return View(model1);
        }
    }
}