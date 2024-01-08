namespace ConsoleStarategyGame;

class Program
{

    public static string menu = @"[1] Start The Game
[2] Load Campaign
[3] Settings
[4] About The Game
[5] Exit
Option: ";
    
    public static bool gameRunning = true;

    public static About ab = new About();
    public static CreateNecessaries cn = new CreateNecessaries();
    public static Game game;
    
    public static void GameMainScene(string menu)
    {
        while (gameRunning)
        {
            try
            {
                Console.Clear();
                Console.Write(menu);
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    cn.Create();
                    Console.Write("Game is starting...");
                    Console.Write("Press any key to start!");
                    Console.ReadLine();
                    Console.Clear();
                    game = new Game();
                }
                else if (option == 2)
                {
                    Console.Write("Campaign is starting");
                }
                else if (option == 3)
                {
                    Console.Write("Settings");
                }
                else if (option == 4)
                {
                    Console.Write("About");
                    string about = ab.AboutGame();
                    Console.Write(about + "\n");
                }
                else if (option == 5)
                {
                    break;
                }

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.Write("You have entered the option wrong. Please try again!");
            }
        }
    }
    
    static void Main(string[] args)
    {
        GameMainScene(menu);
    }
}