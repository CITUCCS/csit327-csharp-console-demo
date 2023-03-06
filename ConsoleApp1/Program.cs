namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var champList = new List<Champion>();
            var champMap = new Dictionary<string, Champion>();

            var newChamp = new Champion(Role.Support);
            
            newChamp.Name = "Milio";
            newChamp.Level = 1;
            newChamp.UpdateStats("AP: 25, Haste: 10");
            
            champList.Add(newChamp);

            var newChamp2 = new Champion(Role.Bot);

            newChamp2.Name = "Twitch";
            newChamp2.Level = 2;
            newChamp2.UpdateStats("AD: 25, Haste: 5");

            champList.Add(newChamp2);

            foreach(var champ in champList)
            {
                Console.WriteLine(champ);
            }
        }
    }
}