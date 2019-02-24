using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using LoginApp.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(LocalFileHelper))]
namespace LoginApp.Droid
{
    public class LocalFileHelper : ILocalFileHelper
    {
        public string GetLocalPath(string path)
        {
            string localPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(localPath, "..", "Library", "Databases");
            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }

            return Path.Combine(libFolder, path);
        }
    }
}