using MVC_CoreIdentity.Models;

namespace MVC_CoreIdentity.RepoServices
{
    public interface ITrackRepo
    {
        public List<Track> GetAll();
        public Track GetDetails(int id);
        public void Insert(Track track);
        public void UpdateTrack(int id, Track track);
        public void DeleteTrack(int id);
    }
}
