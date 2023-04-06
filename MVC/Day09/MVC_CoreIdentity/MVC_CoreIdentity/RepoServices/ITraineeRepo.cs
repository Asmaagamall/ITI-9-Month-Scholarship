using MVC_CoreIdentity.Models;

namespace MVC_CoreIdentity.RepoServices
{
    public interface ITraineeRepo
    {
        public List<Trainee> GetAll();
        public Trainee GetDetails(int id);
        public void Insert(Trainee trainee);
        public void UpdateTrainee(int id, Trainee trainee);
        public void DeleteTrainee(int id);
    }
}
