using MvcCRUD.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MvcCRUD.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        db_testEntities dbobj = new db_testEntities();
        public ActionResult Student(tbl_student obj)
        {
            return View(obj);
        }
        [HttpPost]
        public ActionResult AddStudent(tbl_student model)
        {
            tbl_student obj = new tbl_student();
            if (ModelState.IsValid)
            {
                obj.ID = model.ID;
                obj.Name = model.Name;
                obj.Fname = model.Fname;
                obj.Email = model.Email;
                obj.Mobile = model.Mobile;
                obj.Description = model.Description;
                if (model.ID == 0)
                {
                    dbobj.tbl_student.Add(obj);
                    dbobj.SaveChanges();
                }
                else
                {
                    dbobj.Entry(obj).State=EntityState.Modified;
                    dbobj.SaveChanges();
                }
                ModelState.Clear();
            }
            
            return View("Student");
        }
        public ActionResult StudentList()
        {
            var res = dbobj.tbl_student.ToList();
            return View(res);
        }
        public ActionResult Delete(int id)
        {
            var res = dbobj.tbl_student.Where(x => x.ID == id).First();
            dbobj.tbl_student.Remove(res);
            dbobj.SaveChanges();
            var list = dbobj.tbl_student.ToList();
            return View("StudentList",list);
        }
    }
}