public class Program
{
    private static void Main(string[] args)
    {
        //Readling all elves input from .txt file
        using (StreamReader file = new StreamReader(@"RockPapperSissors.txt"))
        {
            int player = 0;


            string ln;

            while (file.EndOfStream == false)
            {
                ln = file.ReadLine();

                string[] choise = ln.Split(' ');
                string opponentChoice = choise[0].ToString();
                string playerChoice = choise[1].ToString();

                if (opponentChoice == "A")
                {

                    if (playerChoice == "X")
                    {
                        player += (int)ShapePoints.Scissors;
                        player += (int)Result.Lose;

                    }
                    else if (playerChoice == "Y")
                    {
                        player += (int)ShapePoints.Rock;
                        player += (int)Result.Draw;
                    }
                    else
                    {
                        player += (int)ShapePoints.Papper;
                        player += (int)Result.Win;
                    }

                }
                else if (opponentChoice == "B")
                {
                    if (playerChoice == "X")
                    {
                        player += (int)ShapePoints.Rock;
                        player += (int)Result.Lose;

                    }
                    else if (playerChoice == "Y")
                    {
                        player += (int)ShapePoints.Papper;
                        player += (int)Result.Draw;
                    }
                    else
                    {
                        player += (int)ShapePoints.Scissors;
                        player += (int)Result.Win;
                    }
                }
                else if (opponentChoice == "C")
                {
                    if (playerChoice == "X")
                    {
                        player += (int)ShapePoints.Papper;
                        player += (int)Result.Lose;

                    }
                    else if (playerChoice == "Y")
                    {
                        player += (int)ShapePoints.Scissors;
                        player += (int)Result.Draw;
                    }
                    else
                    {
                        player += (int)ShapePoints.Rock;
                        player += (int)Result.Win;
                    }
                }


            }
            //Player total Points
            Console.WriteLine(player);
        }
    }


    public enum ShapePoints
    {
        Rock = 1,
        Papper = 2,
        Scissors = 3

    }
    public enum Result
    {
        Win = 6,
        Draw = 3,
        Lose = 0

    }

    //////////////////////////Part One///////////////////////
    /*
            while (file.EndOfStream == false)
            {
                ln = file.ReadLine();

                string[] choise = ln.Split(' ');
                string opponentChoice = choise[0].ToString();
                string playerChoice = choise[1].ToString();

                if (playerChoice == "X")
                {
                    player += (int)ShapePoints.Rock;

                    if (opponentChoice == "A")
                    {
                        player += 3;

                    }
                    else if (opponentChoice == "B")
                    {
                        player += 0;
                    }
                    else
                    {
                        player += 6;
                    }

                }
                else if (playerChoice == "Y")
                {
                    player += (int)ShapePoints.Papper;

                    if (opponentChoice == "A")
                    {
                        player += 6;
                    }
                    else if (opponentChoice == "B")
                    {
                        player += 3;
                    }
                    else
                    {
                        player += 0;
                    }
                }
                else
                {
                    player += (int)ShapePoints.Scissors;
                    if (opponentChoice == "A")
                    {
                        player += 0;
                    }
                    else if (opponentChoice == "B")
                    {
                        player += 6;
                    }
                    else
                    {
                        player += 3;
                    }*/
}



