using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jayStudyGroup.Controllers
{
    public class GroupController : Controller
    {
        // GET: group
        public ActionResult listMembers()
        {
            List<Models.memberModel> members = new List<Models.memberModel>();

            members.Add(new Models.memberModel { stuNumber = "u20467207", fName = "Raelene", lName = "Dookkoo", email = "raelene.d@tuks.co.za" });
            members.Add(new Models.memberModel { stuNumber = "u23854830", fName = "Dakalo", lName = "Nemamilwe", email = "u23854830@tuks.co.za" });
            members.Add(new Models.memberModel { stuNumber = "u22563742", fName = "Boikgantsho", lName = "More", email = "22563742@tuks.co.za" });
            members.Add(new Models.memberModel { stuNumber = "u22500333", fName = "Jay", lName = "Mashele", email = "njl.mashele@tuks.co.za" });
            members.Add(new Models.memberModel { stuNumber = "u24596385", fName = "Ryan", lName = "van Wyk", email = "r.vanwyk@tuks.co.za" });

            return View(members);
        }
    }
}