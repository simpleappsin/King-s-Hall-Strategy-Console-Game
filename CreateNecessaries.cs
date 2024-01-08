namespace ConsoleStarategyGame;

public class CreateNecessaries
{
    public static string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    public static string gameFolderName = "Kings Hall";
    public static StreamWriter writer;
    
    public void Create()
    {
        string fullPath = pathDesktop + "/" + gameFolderName;
        if (!Directory.Exists(fullPath))
        {
            Directory.CreateDirectory(fullPath);
            Console.Write($"The Necessary folder was created at ({fullPath}).");
        }
        else
        {
            Console.Write("\nGame Files exist!\n");
        }
    }

    public string getFullPath()
    {
        string fullPath = pathDesktop + "/" + gameFolderName;
        return fullPath;
    }
}