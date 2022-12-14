using Humanizer;

public class Program
{

    private static void Main(string[] args)
    {
        //Created List of All Elves that are on the trip
        List<Elf> allElves = new();

        //Readling all elves input from .txt file
        using (StreamReader file = new StreamReader(@"elfInput.txt"))
        {
            int totalCalories = 0;
            int item = 0;
            int elfNameInINTForm = 1;
            string line;


            while (file.EndOfStream == false)
            {
                totalCalories = 0;
                Elf elf = new Elf();

                line = file.ReadLine();

                //Checks if the line is null or contains nothing like ""
                while (!string.IsNullOrWhiteSpace(line))
                {

                    item = Convert.ToInt32(line);
                    totalCalories += item;

                    line = file.ReadLine();

                    //If line contains nothing - add info to Elf object
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        elf.Name = $"{elfNameInINTForm.ToOrdinalWords()} elf";
                        elf.TotalCalories = totalCalories;
                        elfNameInINTForm++;
                        allElves.Add(elf);
                    }

                }

            }


            //Sort the list in desending order by total calories they carry
            var sortedList = allElves.OrderByDescending(x => x.TotalCalories).ToList();

            //Print the top elves information from the list
            Console.WriteLine($" The {sortedList[0].Name} carries the most calories. The total of {sortedList[0].TotalCalories} cal.");

            //========================== Part two ==============================================

            //Taking the top 3 elves calories of the list and adding it to top3TotalCalories
            int top3TotalCalories = 0;
            for (int i = 0; i <= 2; i++)
            {
                top3TotalCalories += sortedList[i].TotalCalories;
            }

            Console.WriteLine($" The top 3 elfs have a total of {top3TotalCalories} calories.");



        }
    }

    public class Elf
    {
        public string Name { get; set; }
        public int TotalCalories { get; set; }
    }
}