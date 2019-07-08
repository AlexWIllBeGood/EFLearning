using CodeFirst20190708.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst20190708
{
    class Program
    {
        static void Main(string[] args)
        {
            using (LocalContext db = new LocalContext())
            {
                //db.Teachers.AddRange(new List<Teacher> {
                //    new Teacher(){ Name="Jason",Status=101 },
                //    new Teacher(){ Name="Chandeler",Status=101 }
                //});
                //db.Students.AddRange(new List<Student> {
                //    new Student(){ Name="Alex",Status=101},
                //    new Student(){ Name="Jaremy",Status=101}
                //});
                //db.SaveChanges();
                //List<Teacher> teacherList = db.Teachers.Where(e => e.Status == 101).ToList();
                //List<Student> studentList = db.Students.Where(e => e.Status == 101).ToList();
                //List<ArrangeCourse> acList = new List<ArrangeCourse>();
                //foreach (Teacher t in teacherList)
                //{
                //    foreach (Student s in studentList)
                //    {
                //        acList.Add(new ArrangeCourse()
                //        {
                //            StudentId = s.Id,
                //            TeacherId=t.Id,
                //            Status=101,
                //            CourseId=1
                //        });
                //    }
                //    foreach (Student s in studentList)
                //    {
                //        acList.Add(new ArrangeCourse()
                //        {
                //            StudentId = s.Id,
                //            TeacherId = t.Id,
                //            Status = 101,
                //            CourseId = 2
                //        });
                //    }
                //    foreach (Student s in studentList)
                //    {
                //        acList.Add(new ArrangeCourse()
                //        {
                //            StudentId = s.Id,
                //            TeacherId = t.Id,
                //            Status = 101,
                //            CourseId = 3
                //        });
                //    }
                //}
                //db.ArrangeCourses.AddRange(acList);
                //db.SaveChanges();
                //利用导航属性进行查询
                var arrangeCourse = db.ArrangeCourses.Include(e => e.Student).Include(e => e.Teacher).Where(e => e.Status == 101).ToList();
                var studentNames = arrangeCourse.Select(e => e.Student.Name);
                var teacherNames = arrangeCourse.Select(e => e.Teacher.Name).ToList().Distinct();
                db.ArrangeCourses.Add(new ArrangeCourse() {
                   
                });
            }
            Console.ReadKey();
        }
    }
}
