using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MVCSimpleWebgrid.Controllers
{
    public class UserController : Controller
    {
        private List<Student> _students = new List<Student>();
        //
        // GET: /User/

        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult List(string search)
        {
            //here  MyDatabaseEntities is the dbcontext
            using (var dc = new MyDatabaseEntities())
            {
               _students = dc.Students.Where(x => x.StdFirstName.Contains(search) || search == null).ToList();
            }
            return View(_students);
        }

    }
}
