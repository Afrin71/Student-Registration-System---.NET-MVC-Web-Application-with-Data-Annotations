namespace DataAnnotation.Controllers
{
    public class EmployeeController : Controller
    {
        UsersContext objUsersContext = new UsersContext();

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(StudentModel objStudentModel)
        {
            if (ModelState.IsValid)
            {
                objUsersContext.StudentDbSet.Add(objStudentModel);
                objUsersContext.SaveChanges(); 
                return RedirectToAction("Create");
            }
            return View(objStudentModel);
        }

        [HttpGet]
        public ActionResult ShowDetails()
        {
            List<StudentModel> objStudentModel = objUsersContext.StudentDbSet.ToList();
            return View(objStudentModel);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            StudentModel objStudentModel = objUsersContext.StudentDbSet.Single(p => p.StudentId == id);
            if (objStudentModel == null)
            {
                return HttpNotFound();
            }
            return View(objStudentModel);
        }

        [HttpPost]
        public ActionResult Edit(StudentModel objStudentModel)
        {
            if (ModelState.IsValid)
            {
                objUsersContext.Entry(objStudentModel).State = EntityState.Modified;
                objUsersContext.SaveChanges(); 
                return RedirectToAction("ShowDetails");
            }
            return View(objStudentModel);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            StudentModel objStudentModel = objUsersContext.StudentDbSet.Single(p => p.StudentId == id);
            if (objStudentModel == null)
            {
                return HttpNotFound();
            }
            return View(objStudentModel);

        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            StudentModel objStudentModel = objUsersContext.StudentDbSet.Single(p => p.StudentId == id);
            if (objStudentModel == null)
            {
                return HttpNotFound();
            }
            return View(objStudentModel);
        }

        [HttpPost]
        public ActionResult Delete(int id, StudentModel objStudentModel)
        {
            StudentModel _objStudent = objUsersContext.StudentDbSet.Single(p => p.StudentId == id);
            objUsersContext.StudentDbSet.Remove(_objStudent);
            objUsersContext.SaveChanges();
            return RedirectToAction("ShowDetails");
        }

    }


}
