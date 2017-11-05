using System;
using System.IO;
using WorkingDemo.Data;
using WorkingDemo.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileImplementation))]
namespace WorkingDemo.Droid
{
    public class FileImplementation : IFile
    {
        public void ClearText(string filename)
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentsPath, filename);

            File.Delete(filePath);
        }

        public bool FileExists(string filename)
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentsPath, filename);

            return File.Exists(filePath);
        }

        public string LoadText(string filename)
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentsPath, filename);

            return File.ReadAllText(filePath);
        }

        public void SaveText(string filename, string text)
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentsPath, filename);
            File.Delete(filePath);
            File.WriteAllText(filePath, text);
        }
    }
}