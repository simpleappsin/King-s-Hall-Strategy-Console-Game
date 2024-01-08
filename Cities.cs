namespace ConsoleStarategyGame;

public class Cities
{
    public string Name { get; set; }
    public string EmpireOwns { get; set; }

    public int Income { get; set; }
    public int Power { get; set; }
    public int FoodStock { get; set; }
    public int Population { get; set; }
    
    public double Happiness { get; set; }
    public double Level { get; set; }
    
    public string InfoCity()
    {
        string info = $"\tCity Name: {Name}\n\tEmpire: {EmpireOwns}\n\tIncome: {Income}\n\t" +
                      $"Power: {Power}\n\tFood Stocks: {FoodStock}\n\tPopulation: {Population}" +
                      $"Happiness: {Happiness}\n\tLevel Of City{Level}";
        return info;
    }
}