public class Program
{

    private static void Main(string[] args)
    {
        List<Elf> allEfls = new();

        using (StreamReader file = new StreamReader(@"elfInput.txt"))
        {
            int totalCalories = 0;
            int item = 0;
            int elfNameinINT = 1;
            string line;


            while (file.EndOfStream == false)
            {
                totalCalories = 0;
                Elf elf = new Elf();


                line = file.ReadLine();

                while (!string.IsNullOrWhiteSpace(line))
                {

                    item = Convert.ToInt32(line);
                    totalCalories += item;

                    line = file.ReadLine();

                    if (string.IsNullOrWhiteSpace(line))
                    {
                        elf.Name = elfNameinINT;
                        elf.TotalCalories = totalCalories;
                        elfNameinINT++;
                        allEfls.Add(elf);
                    }

                }

            }



            var sortedList = allEfls.OrderByDescending(x => x.TotalCalories).ToList();
            Console.WriteLine(sortedList[0].TotalCalories);


        }
    }

    public class Elf
    {
        public int Name { get; set; }
        public int TotalCalories { get; set; }
    }
}