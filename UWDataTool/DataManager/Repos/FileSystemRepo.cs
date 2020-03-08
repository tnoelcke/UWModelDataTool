using System.Collections.Generic;
using System.IO;

namespace DataManager.Repos
{
    class FileSystemRepo
    {
        private const string BASE_STORAGE_LOCATION = "./App_Data";

        private string storageLocation;

        private static FileSystemRepo _instnace;

        public FileSystemRepo(string directory)
        {
            //TODO: Get this location from configuration.
            storageLocation = Path.Combine(BASE_STORAGE_LOCATION, directory);
        }

        public Stream ReadFile() {
            return null;
        }

        public void WriteFile(Stream file)
        {

        }

        public static void DeleteFile()
        {

        }

        public void writeFilies(IList<Stream> files)
        {
            foreach(Stream file in files)
            {
                this.WriteFile(file);
            }
        }
    }
}
