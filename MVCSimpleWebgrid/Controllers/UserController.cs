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
                if (search != null)
                {
                    students = dc.Students.Where(x => x.StdFirstName.Contains(search)).ToList();
                }
                else
                {
                    students = dc.Students.ToList();
                }
            }
            return View(students);
        }

    }
}
