using MVC_CoreIdentity.Models;

namespace MVC_CoreIdentity.RepoServices
{
    public class TraineeRepoServices : ITraineeRepo
    {
        public TraineeRepoServices(MainDbContext context)
        {
            Context = context;
        }

        public MainDbContext Context { get; }

        public void DeleteTrainee(int id)
        {
            Context.Trainee.Remove(Context.Trainee.Find(id));
            Context.SaveChanges();
        }

        public List<Trainee> GetAll()
        {
            return Context.Trainee.ToList();
        }

        public Trainee GetDetails(int id)
        {
            return Context.Trainee.Find(id);
        }

        public void Insert(Trainee trainee)
        {
            Context.Trainee.Add(trainee);
            Context.SaveChanges();
        }

        public void UpdateTrainee(int id, Trainee trainee)
        {
            var TR = Context.Trainee.Find(id);
            TR.Name = trainee.Name;
            TR.Email = trainee.Email;
            TR.Birthdate = trainee.Birthdate;
            TR.Phone = trainee.Phone;
            TR.Gender = trainee.Gender;
            Context.SaveChanges();
        }
    }
}
