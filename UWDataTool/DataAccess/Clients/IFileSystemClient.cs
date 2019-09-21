using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataAccess.Clients
{
    interface IFileSystemClient
    {

        void Add(FileStream file, string path);

        void createFolder(string path, string name);

        void Delete(string path);


        FileStream read(string path);

    }
}
