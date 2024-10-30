public class Program
{
    public static void Main(string[] args)
    {
        List<Sport> activities = new List<Sport>
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0),
            new Cycling(new DateTime(2022, 11, 4), 45, 15.0),
            new Swimming(new DateTime(2022, 11, 5), 30, 20) 
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}