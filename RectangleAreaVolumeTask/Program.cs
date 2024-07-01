namespace RectangleAreaVolumeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is a partially writen program in C#
            //to calculate the area of a rectangle or the volume of a box
            //from the user inputs
            //Complete the code in both the main program and in the function
            //so the program will take 3 user inputs and output either the area or volume
            // test your program with the following inputs
            //
            //| width   | length    | height |
            //|   5     |    6      |   -1   |
            //|   10    |    4      |    0   |
            //|   3     |    5      |    10  |
            //
            // Show your test evidence in the Readme

            int width, length, height;
            Console.Write("Enter width: ");
            width = Console.ReadLine();
            Console.Write("Enter height (enter -1 to ignore): ");

            int answer = RectangleCalculator(width, length, height);
            if (height == -1)
            {
                Console.WriteLine($"Area = {answer}");
            }
        }
        static int RectangleCalculator(int width, int length,int height) { 
             
            if (height == -1) // if it is area
            {

            }else // if it is volume
            {

            }
            return 0; // should never happen
        
        }
    }
}
