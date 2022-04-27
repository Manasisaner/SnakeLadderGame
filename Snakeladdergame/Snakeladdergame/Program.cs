// See https://aka.ms/new-console-template for more information

//public class program
//{
//    public static void Main(String[] args)
//    {
//        SnakeGame game = new SnakeGame();
//        int start = game.dieRoll();
//        Console.WriteLine("Welcome in the Game, Your Position is: " + "****" + start + "****");
//    }
//}
//public class SnakeGame
//    {
//        const int position = 0;
//        public int dieRoll()
//        { 
//          return position;
//        }

//    }

namespace SnakeLadderGame
{
    public class SnakeGame
    {
        const int position = 0;
        public int dieRoll()
        {
            Random random = new Random();
            int roll = random.Next(1, 7);
            return roll;
        }

    }
    public class program
    {
        public static void Main(String[] args)
        {
            SnakeGame game = new SnakeGame();
            int start = game.dieRoll();
            Console.WriteLine("Welcome in the Game, You got : " + start + "  " + "Position");
        }
    }
}
