using System;

namespace Slides
{
    class Ball
    {
        public int BallWidth { get; set; }
        public int BallHeight { get; set; }
        public int BallDepth { get; set; }
        public Ball(Ball ball)
        {
            this.BallWidth = ball.BallWidth;
            this.BallHeight = ball.BallHeight;
            this.BallDepth = ball.BallDepth;
        }
        public Ball(int ballWidth, int ballHeight, int ballDepth)
        {
            this.BallWidth = ballWidth;
            this.BallHeight = ballHeight;
            this.BallDepth = ballDepth;
        }
    }

    class Slides
    {
        private static int width, depth, height;
        private static string[, ,] cube;
        private static Ball startCoordinates;
        static void Main(string[] args)
        {
            Input();
            BallCommands();
        }
        private static void Input()
        {
            string[] cubeSize = Console.ReadLine().Split();
            width = int.Parse(cubeSize[0]);
            height = int.Parse(cubeSize[1]);
            depth = int.Parse(cubeSize[2]);
            cube = new string[width, height, depth];
            for (int h = 0; h < height; h++)
            {
                string[] line = Console.ReadLine().Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                for (int d = 0; d < depth; d++)
                {
                    string[] cells = line[d].Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int w = 0; w < width; w++)
                    {
                        cube[w, h, d] = cells[w];
                    }
                }
            }
            string[] ballCoordinates = Console.ReadLine().Split();
            int ballWidth = int.Parse(ballCoordinates[0]);
            int ballDepth = int.Parse(ballCoordinates[1]);
            startCoordinates = new Ball(ballWidth, 0, ballDepth);
        }
        private static void BallCommands()
        {
            while (true)
            {
                string currentCell = cube[startCoordinates.BallWidth, startCoordinates.BallHeight, startCoordinates.BallDepth];
                string[] cellCommands = currentCell.Split();
                string firstCommand = cellCommands[0];
                switch (firstCommand)
                {
                    case "S":
                        SlideBall(cellCommands[1]);
                        break;
                    case "T":
                        startCoordinates.BallWidth = int.Parse(cellCommands[1]);
                        startCoordinates.BallDepth = int.Parse(cellCommands[2]);
                        break;
                    case "B":
                        Output();
                        return;
                    case "E":
                        if (startCoordinates.BallHeight == height - 1)
                        {
                            Output();
                            return;
                        }
                        else
                        {
                            startCoordinates.BallHeight++;
                        }
                        break;
                    default: 
                        throw new ArgumentException("Invalid command");
                }
            }
        }
        private static void SlideBall(string command)
        {
            Ball movedBall = new Ball(startCoordinates);
            switch (command)
            {
                case "R":
                    movedBall.BallHeight++;
                    movedBall.BallWidth++;
                    break;
                case "L":
                    movedBall.BallWidth--;
                    movedBall.BallHeight++;
                    break;
                case "F":
                    movedBall.BallDepth--;
                    movedBall.BallHeight++;
                    break;
                case "B":
                    movedBall.BallDepth++;
                    movedBall.BallHeight++;
                    break;
                case "FL":
                    movedBall.BallDepth--;
                    movedBall.BallWidth--;
                    movedBall.BallHeight++;
                    break;
                case "FR":
                    movedBall.BallDepth--;
                    movedBall.BallWidth++;
                    movedBall.BallHeight++;
                    break;
                case "BL":
                    movedBall.BallDepth++;
                    movedBall.BallWidth--;
                    movedBall.BallHeight++;
                    break;
                case "BR":
                    movedBall.BallDepth++;
                    movedBall.BallWidth++;
                    movedBall.BallHeight++;
                    break;
                default:
                    throw new ArgumentException("Ivalid slide command");
            }
            if (AbleToPass(movedBall))
            {
                startCoordinates = new Ball(movedBall);
            }
            else
            {
                Output();
                Environment.Exit(0);
            }
        }
        static bool AbleToPass(Ball ball)
        {
            if (ball.BallWidth >= 0 && ball.BallHeight >= 0 && ball.BallDepth >= 0 && ball.BallWidth < width && ball.BallHeight < height && ball.BallDepth < depth)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static void Output()
        {
            string currentCell = cube[startCoordinates.BallWidth, startCoordinates.BallHeight, startCoordinates.BallDepth];
            if (currentCell == "B" || startCoordinates.BallHeight != height - 1)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
            Console.WriteLine("{0} {1} {2}", startCoordinates.BallWidth, startCoordinates.BallHeight, startCoordinates.BallDepth);
        }
    }
}
