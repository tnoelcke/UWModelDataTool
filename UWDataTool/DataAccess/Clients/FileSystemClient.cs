using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataAccess.Clients
{
    class FileSystemClient : IFileSystemClient
    {
        public void Add(FileStream file, string path)
        {
            throw new NotImplementedException();
        }

        public void createFolder(string path, string name)
        {
            throw new NotImplementedException();
        }

        public void Delete(string path)
        {
            throw new NotImplementedException();
        }

        public FileStream read(string path)
        {
            throw new NotImplementedException();
        }
    }
}
