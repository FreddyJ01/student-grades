using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic; // This is to import the dictionary class.

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        // Array to hold student grades.
        int[] sophiaGrade = { 93, 87, 98, 95, 100 };
        int[] andrewGrade = { 80, 83, 82, 88, 85 };
        int[] emmaGrade = { 84, 96, 73, 85, 79 };
        int[] loganGrade = { 90, 92, 98, 100, 97 };

        // Student Grade Sum Calculation
        int sophiaSum = sophiaGrade.Sum();
        int andrewSum = andrewGrade.Sum();
        int emmaSum = emmaGrade.Sum();
        int loganSum = loganGrade.Sum();

        // System.Console.WriteLine($"{sophiaSum} {andrewSum} {emmaSum} {loganSum}");

        // Student Grade Avg Calculation
        decimal sophiaAvg = (decimal)sophiaGrade.Average();
        decimal andrewAvg = (decimal)andrewGrade.Average();
        decimal emmaAvg = (decimal)emmaGrade.Average();
        decimal loganAvg = (decimal)loganGrade.Average();

        // System.Console.WriteLine($"{sophiaAvg:f1} {andrewAvg:f1} {emmaAvg:f1} {loganAvg:f1}");

        // Cumulative Grade Avg Array
        decimal[] collectiveAvg = [sophiaAvg, andrewAvg, emmaAvg, loganAvg];

        // Command Line Display
        System.Console.WriteLine($@"
        Student        Grade
        Sophia         {sophiaAvg:f1} {letterGrade(collectiveAvg[0])}
        Andrew         {andrewAvg:f1} {letterGrade(collectiveAvg[1])}
        Emma           {emmaAvg:f1} {letterGrade(collectiveAvg[2])}
        Logan          {loganAvg:f1} {letterGrade(collectiveAvg[3])}
        ");

        System.Console.WriteLine();
        GPACalculator();
    }
   
    // Letter Grade Output Method
    public static char letterGrade(decimal individualAvg)
    {
        if (individualAvg >= 90)
        {
            return 'A';
        }
        else if (individualAvg >= 80)
        {
            return 'B';
        }
        else if (individualAvg >= 70)
        {
            return 'C';
        }
        else if (individualAvg >= 60)
        {
            return 'D';
        }
        else
        {
            return 'F';
        }
    }
    public static void GPACalculator()
    {
        // Creates my dictionary with key values pairs of course and the associated credit hours.
        Dictionary<string, decimal> courseCreditHours = new Dictionary<string, decimal>();
        courseCreditHours.Add("English 101", 3.0m);
        courseCreditHours.Add("Algebra 101", 3.0m);
        courseCreditHours.Add("Biology 101", 4.0m);
        courseCreditHours.Add("Computer Science I", 4.0m);
        courseCreditHours.Add("Psychology 101", 3.0m);


        // Creates my dictionary with key value pairs of sophias course grades.
        Dictionary<string, decimal> sophiaCourseGrade = new Dictionary<string, decimal>();
        sophiaCourseGrade.Add("English 101", 4.0m);
        sophiaCourseGrade.Add("Algebra 101", 3.0m);
        sophiaCourseGrade.Add("Biology 101", 3.0m);
        sophiaCourseGrade.Add("Computer Science I", 3.0m);
        sophiaCourseGrade.Add("Psychology 101", 4.0m);

        decimal GPACalculator = (
            ((courseCreditHours["English 101"] * sophiaCourseGrade["English 101"]) +
            (courseCreditHours["Algebra 101"] * sophiaCourseGrade["Algebra 101"]) +
            (courseCreditHours["Biology 101"] * sophiaCourseGrade["Biology 101"]) +
            (courseCreditHours["Computer Science I"] * sophiaCourseGrade["Computer Science I"]) +
            (courseCreditHours["Psychology 101"] * sophiaCourseGrade["Psychology 101"])) /
            ((courseCreditHours["English 101"] + courseCreditHours["Algebra 101"] + courseCreditHours["Biology 101"] + courseCreditHours["Computer Science I"] + courseCreditHours["Psychology 101"]))
            );
        
        
        System.Console.WriteLine(@$"
        Student: Sophia Johnson

        Course               Grade            Credit Hours
        English 101          {sophiaCourseGrade["English 101"]:f0}                {courseCreditHours["English 101"]:f0}
        Algebra 101          {sophiaCourseGrade["Algebra 101"]:f0}                {courseCreditHours["Algebra 101"]:f0}
        Biology 101          {sophiaCourseGrade["Biology 101"]:f0}                {courseCreditHours["Biology 101"]:f0}
        Computer Science I   {sophiaCourseGrade["Computer Science I"]:f0}                {courseCreditHours["Computer Science I"]:f0}
        Psychology 101       {courseCreditHours["Psychology 101"]:f0}                {courseCreditHours["Psychology 101"]:f0}
        
        Final GPA:           {GPACalculator:f2}
        ");
    }

}
