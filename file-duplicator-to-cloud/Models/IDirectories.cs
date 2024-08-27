namespace file_duplicator_to_cloud.Models
{
    public interface IDirectories
    {
        string? CurrentPath { get; set; }
        string? DestinationPath { get; set; }

        //bool? Recursive { get; set; }

        //void Copy(string CurrentPath, string DestinationPath, bool Recursive);
        void Copy(string CurrentPath, string DestinationPath);
    }
}
