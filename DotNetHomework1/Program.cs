//Ethan Cala Homework 1 for .Net Programming CPSC-23000

// a C# program that will calculate the volume of a cube and of a sphere, and total combined volume

// https://github.com/ethancala

//I decided to use functions for this program because it is a natural habit for me, I hope this isn't an issue.
//No LLMs were used in this assignment.

//This is a test comment
namespace DotNetHomework1

{
    internal class Program
    {

        //function to calculate volume of sphere using radius
        public static double CalculateVolumeSphere(double radius)
        {
            double volume;

            // forumula to calculate sphere uisng Math library
            volume = (double)(4.0 / 3 * Math.PI * radius * radius * radius);

            //return volume as double
            return volume;
        }

        //function to calculate volume of cube using lwh
        public static double CalculateVolumeCube(double length, double width, double height)
        {
            double volume;

            //formula to calculate volume of a sphere
            volume = length * width * height;
            
            //return volume as double
            return volume;
        }

        //function to calulate total volume between sphere and cube
        public static double TotalVolume(double cVolume, double sVolume)
        {
            double totalVolume = cVolume + sVolume;

            //return total as double
            return totalVolume;
        }


            //main method
            static void Main(string[] args)
        {

            //say hello to user!
            Console.WriteLine("Welcome to the Shape Calculator!");
            //blank line
            Console.WriteLine();


            //Prompt user for cube input
            Console.WriteLine("Lets start with the cube.");


            //store input of length and parse to double
            Console.WriteLine("Please enter the length of the cube: ");
            double length = double.Parse(Console.ReadLine());


            //store input of width and parse to double
            Console.WriteLine("Please enter the Width of the cube: ");
            double width =  double.Parse(Console.ReadLine());

            //store input of height and parse to double
            Console.WriteLine("Please enter the Height of the cube: ");
            double height = double.Parse(Console.ReadLine());

            //call function to calculate volume and output result
            double cVolume = CalculateVolumeCube(length, width, height);
            //use formatted output to display 3 decimals places without rounding
            Console.WriteLine($"The cube's volume is:  {cVolume:F3}");


            //Now we prompt user for sphere 
            Console.WriteLine();
            Console.WriteLine("Now lets calculate the Sphere");

            //Prompt user for radius of sphere
            Console.WriteLine("Please enter the radius of the sphere: ");
            double radius = double.Parse(Console.ReadLine());

            //calculate volume of sphere using function
            double sVolume = CalculateVolumeSphere(radius);
            ////use formatted output to display 3 decimals places without rounding
            Console.WriteLine($"The volume of the sphere is: {sVolume:F3} ");


            //blank line
            Console.WriteLine();


            //now calculate total volume using function and output for user
            double totalVolume = TotalVolume(cVolume, sVolume);
            //use formatted output to disply 3 decimals places without rounding
            Console.WriteLine($"The total volume of the cube and the sphere is: {totalVolume:F3}");

            //blank line
            Console.WriteLine();

            //Thank you message
            Console.WriteLine("Thank you for using this program, have a great day!");
        }
    }
}
