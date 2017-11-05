namespace WorkingDemo.Data
{
    public interface IFile
    {
        void SaveText(string filename, string text);
        string LoadText(string filename);
        void ClearText(string filename);
        bool FileExists(string filename);
    }
}
