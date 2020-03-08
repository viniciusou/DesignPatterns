using System.IO;

namespace SingleResponsibility
{
    public class Persistence
    {
        public void SaveToFile(Journal journal, string filename, bool ovewrite = false)
        {
            if (ovewrite || !File.Exists(filename))
                File.WriteAllText(filename, journal.ToString());
        }
    }
}
