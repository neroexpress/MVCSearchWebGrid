using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MVCSimpleWebgrid.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult List(string search)
        {
            var students = new List<Student>();
            //here  MyDatabaseEntities is the dbcontext
            using (MyDatabaseEntities dc = new MyDatabaseEntities())
            {
               students = dc.Students.Where(x => x.StdFirstName.Contains(search) || search == null).ToList();
            }
            return View(students);
        }

    }
}
