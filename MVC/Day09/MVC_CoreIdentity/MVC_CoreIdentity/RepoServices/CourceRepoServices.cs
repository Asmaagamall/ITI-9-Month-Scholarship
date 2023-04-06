using MVC_CoreIdentity.Models;

namespace MVC_CoreIdentity.RepoServices
{
    public class CourceRepoServices :ICourse
    {
        public CourceRepoServices(MainDbContext context)
        {
            Context = context;
        }

        public MainDbContext Context { get; }


        public void DeleteCrs(int id)
        {
            Context.Courses.Remove(Context.Courses.Find(id));
            Context.SaveChanges();
        }

        public List<Course> GetAll()
        {
            return Context.Courses.ToList();
        }

        public Course GetDetails(int id)
        {
            return Context.Courses.Find(id);
        }

        public void Insert(Course course)
        {
            Context.Courses.Add(course);
            Context.SaveChanges();
        }

        public void UpdateCrs(int id, Course crs)
        {
            var course = Context.Courses.Find(id);
            course.Topic = crs.Topic;
            course.TraineeId = crs.TraineeId;
            course.Grade = crs.Grade;
            Context.SaveChanges();
        }
    }
}
