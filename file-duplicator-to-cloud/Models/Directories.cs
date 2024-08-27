namespace file_duplicator_to_cloud.Models
{
    public class Directories : IDirectories
    {
        public string? CurrentPath { get; set; }
        public string? DestinationPath { get; set; }

        //public bool? Recursive { get; set; }

        public void Copy(string CurrentPath, string DestinationPath)
        {
            IDate date = new Date();
            DestinationPath = $"{DestinationPath}{date.FormattedDate}";

            // Get information about the source directory
            var dir = new DirectoryInfo(CurrentPath);

            // Check if the source directory exists
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            // Cache directories before we start copying
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Create the destination directory
            Directory.CreateDirectory(DestinationPath);

            // Get the files in the source directory and copy to the destination directory
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(DestinationPath, file.Name);
                file.CopyTo(targetFilePath);
            }

            // If recursive and copying subdirectories, recursively call this method
            //if (Recursive)
            //{
            foreach (DirectoryInfo subDir in dirs)
            {
                string newDestinationDir = Path.Combine(DestinationPath, subDir.Name);
                //Copy(subDir.FullName, newDestinationDir, true);
                Copy(subDir.FullName, newDestinationDir);
            }
            //}
        }
    }
}
