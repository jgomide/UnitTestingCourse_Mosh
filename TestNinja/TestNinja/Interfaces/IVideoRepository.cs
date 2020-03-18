using System.Collections.Generic;
using TestNinja.Mocking;

namespace TestNinja.Repository
{
    public interface IVideoRepository
    {
        IEnumerable<Video> GetUnprocessedVideos();
    }
}