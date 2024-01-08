namespace ConsoleStarategyGame;

public class Game
{
    private Khun_City khun_city = new Khun_City();
    private Prez_City prez_city = new Prez_City();
    private Napo_City napo_city = new Napo_City();
    private Player_City player_city = new Player_City();
    
    public string city_name;
    public string empire_name;
    public string options = @"[1] Attack Empir
[2] Make Alliance
[3] Build Options
[4] Your Empire Info
[5] Skip Turn
Option: ";

    public static int turn = 0;

    public bool running = true;
    
    public Game()
    {
        while (true)
        {
            try
            {
                Console.Write("Please enter City Name: ");
                city_name = Console.ReadLine();
                Console.Write("Please enter Empire Name: ");
                empire_name = Console.ReadLine();
                player_city.Name = city_name;
                player_city.EmpireOwns = empire_name;
            }
            catch (Exception ex)
            {
                Console.Write("Please try again!");
            }

            if (city_name != null && empire_name != null)
            {
                Start();
            }
        }
    }

    public void Start()
    {
        while (running)
        {
            turn += 1;
            Console.Write(options);
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                Console.Write("Which empire you want to attack?\n");
                string attackEmpire = Console.ReadLine();
                attackEmpire = attackEmpire.ToLower();
                WhoToAttack(attackEmpire);
            }
            else if (option == 4)
            {
                GetCityInfo(player_city);
            }
        }
    }   
    
    public static void GetCityInfo(Cities city)
    {
        Console.Write(city.InfoCity());
    }

    public void WhoToAttack(string empireName)
    {
        if (empireName == "khun")
        {
            InvadeEmpire(khun_city);
        }
    }

    public void InvadeEmpire(Cities city)
    {
        if (player_city.Power > city.Power)
        {
            Console.Write("You won the battle!");
            player_city.Income += city.Income;
            player_city.Power -= (city.Power/100);
            player_city.Population += (city.Population/20);
            player_city.FoodStock += city.FoodStock;
            player_city.Happiness += city.Happiness;
        }
    }
    
}