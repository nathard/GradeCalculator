using System;
public class GradeCalculator
{
    public static void Main()
    {
        const int FINISH = -999;
        float total = 0F; // initialise total to zero

        int grade = 0; // initialise grade to zero

        int counter = 0; // initialise counter to zero

        int highest = 0, lowest = 100; // initialise highest and lowest in the revert value

        while (grade != -999) // while the user had not as yet entered the sentinel (grade >= 0)
        {
            Console.Write("Enter grade " + (counter + 1) + " (0-100 inclusive) OR " + FINISH + " to finish: "); // add the prompt to instruct for input
            grade = Convert.ToInt32(Console.ReadLine()); // input the first grade

            if (grade > -1 && grade < 101)
            {
                total += grade; // ADD this grade into the running total

                counter++;	// ADD one to the grade counter
                if (counter == 1) highest = lowest = grade; // set 1st value
                else
                    if (grade < lowest) lowest = grade; // change lowest
                    else if (grade > highest) highest = grade; // update highest
                // if (grade > highest) highest = grade;
                // if ( grade < lowest ) lowest = grade;
            }
            //else if(grade != FINISH) Console.WriteLine("invalid grade.. Re-enter the correct one");

        }
        if (counter == 0) Console.WriteLine("No valid grade to process.");
        else
        {
            Console.WriteLine("The average score is " + (total / counter)); // print the average
            Console.WriteLine("The highest grade is " + highest + " and lowest is " + lowest);
        }
    }
}

