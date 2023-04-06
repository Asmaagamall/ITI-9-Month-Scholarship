using MVC_CoreIdentity.Models;

namespace MVC_CoreIdentity.RepoServices
{
    public interface ICourse
    {
        public List<Course> GetAll();
        public Course GetDetails(int id);
        public void Insert(Course crs);
        public void UpdateCrs(int id, Course crs);
        public void DeleteCrs(int id);
    }
}
