using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using PagedList;


namespace Model.DAO
{
    public class StudentDao
    {
        DbContextSchool db = null;

        public StudentDao()
        {
            db = new DbContextSchool();
        }
        public IEnumerable<Student> getAll()
        {
            return db.Students.ToList();
        }
        public IEnumerable<Student> listStudentsPaging(string searchString,int page, int pageSize)
        {
            IQueryable<Student> students = db.Students;
            if (!string.IsNullOrEmpty(searchString))
            {
                students= students.Where(x => x.name.Contains(searchString));
            }

            return students.OrderBy(x => x.id).ToPagedList(page, pageSize);

        }
        public Student getDetail(string id)
        {
            return db.Students.SingleOrDefault(s => s.id == id);
        }

        public string Insert(Student student)
        {
            var item = db.Students.FirstOrDefault(s => s.id == student.id);
            if (item == null)
            {
                db.Students.Add(student);
                db.SaveChanges();
                return student.id;
            }
            else { return item.id; }

        }
        public bool Update(Student student)
        {
                var item = db.Students.Find(student.id);
                item.name = student.name;
                item.age = student.age;
                db.SaveChanges();
                return true;
        }

        public bool Delete(string id)
        {
            var item = db.Students.Find(id);
            db.Students.Remove(item);
            db.SaveChanges();
            return true;
        }

        public bool Login(string username, string password)
        {
            var result = db.Students.Count(x => x.id == username && x.name == password );
            if (result > 0) { return true; }
            else   return false;
        }
    }
}
