namespace TestNinja.Repository
{
    public interface IFileDownloader
    {
        void DownloadFile(string url, string path);
    }
}