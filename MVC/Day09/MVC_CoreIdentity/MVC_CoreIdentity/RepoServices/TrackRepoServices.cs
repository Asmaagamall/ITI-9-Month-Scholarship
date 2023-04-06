using MVC_CoreIdentity.Models;

namespace MVC_CoreIdentity.RepoServices
{
    public class TrackRepoServices : ITrackRepo
    {
        public TrackRepoServices(MainDbContext context)
        {
            Context = context;
        }

        public MainDbContext Context { get; }

        public void DeleteTrack(int id)
        {
            Context.Tracks.Remove(Context.Tracks.Find(id));
            Context.SaveChanges();
        }

        public List<Track> GetAll()
        {
            return Context.Tracks.ToList();
        }

        public Track GetDetails(int id)
        {
            return Context.Tracks.Find(id);
        }

        public void Insert(Track track)
        {
            Context.Tracks.Add(track);
            Context.SaveChanges();
        }

        public void UpdateTrack(int id, Track track)
        {
            var trk = Context.Tracks.Find(id);
            trk.Name = track.Name;
            trk.Description = track.Description;
            Context.SaveChanges();
        }
    }
}
