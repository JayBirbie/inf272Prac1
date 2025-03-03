using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jayStudyGroup.Controllers
{
    public class groupController : Controller
    {
        // GET: group
        public ActionResult Index()
        {
            List<Models.memberModel> members = new List<Models.memberModel>();

            members.Add(new Models.memberModel { stuNumber = "u", fName = "Raelene", lName = "Dokkoo", email = "raelene.d@gmail.com" });
            members.Add(new Models.memberModel { stuNumber = "u23854830", fName = "Dakalo", lName = "Nemamilwe", email = "u23854830@tuks.co.za" });
            members.Add(new Models.memberModel { stuNumber = "Name 3", fName = "Boikgantsho", lName = "More", email = "true" });
            members.Add(new Models.memberModel { stuNumber = "Name 4", fName = "Surname 4", lName = "4", email = "false" });
            members.Add(new Models.memberModel { stuNumber = "Name 5", fName = "Raelene", lName = "Dokkoo", email = "true" });

            return View(members);
        }
    }
}