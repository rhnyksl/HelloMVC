using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMVC.Controllers
{
    //Controller/Action
    public class OgrenciController : Controller
    {
        public ViewResult Index()//Action metodlar
        {
            return View();
        }

        public ActionResult OgrenciListesi()
        {
            return View();
        }

        public IActionResult OgrenciDetay(int? ogrenciid, string isim)//Değer tipini nullable yapmak için kullanılır. int? yerine Nullable<int> id 'de yazılabilir.
        {
            string ad = "Orhun";
            string soyad = "Yüksel";
            string numara = "123";

            ViewData["ad"] = ad;
            ViewData["soyad"] = soyad;
            ViewData["numara"] = numara;

            return View();

        }

    }
}
//return "Detayları getirilecek öğrencinin id'si:" + ogrenciid + "İsim:" + isim;
//Querystring yöntemi :URL'de parametre gönderirken ? işareti ile başlar, parametreler arasında & işareti kullanılır.