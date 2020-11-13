/* 
Josh Bartlett
6July2019
Assignment 3.3
Enter daily temps and then calculates the average of those temps
*/

using System;
using static System.Console;

class DailyTemps
{
    static void Main(string[] args)
    {
        // Declaring all variables to be used in the program
        int count = 0;
        string stringTemp;
        int inputTemp;
        int tempTotal = 0;
        char continueLoop = 'Y';
        int average;
        // while loop that continues until the letter E is entered
        while (continueLoop == 'Y')
        {
            // Prompts user to input temperatures and stores user input in stringTemp variable
            Write("Enter High Temperature (Between -20 and 130 degrees Fahrenheit) or enter E to end entery and finish program: ");
            stringTemp = ReadLine();
            // if statement that checks if user has entered the letter E, if user enters the letter E then the loop ends
            if (stringTemp == "E" || stringTemp == "e")
            {
                continueLoop = 'N';
            }
            // else part of if statement above if user doesn't enter the letter E
            else
            {
                // Converts stringTemp to an integer
                inputTemp = Convert.ToInt16(stringTemp);
                // if statement that checks if the temperature entered is within paramaters
                if (inputTemp > -21 && inputTemp < 131)
                {
                    // keeps count of number of temperatures entered 
                    ++count;
                    // keeps a running total of the temperatures entered
                    tempTotal = tempTotal + inputTemp;
                }
                // else if part of if statement if user enters a temperature out of the parameters and displays a message
                else if (inputTemp < -20 || inputTemp > 130)
                {
                    WriteLine("Temperature entered out of bounds. Please enter temperatures between -20 and 130 degrees Fahrenheit");
                }
            }
        }
        // calculates the average temperature and displays how many temperatures entered and the average temperature
        average = tempTotal / count;
        WriteLine("You entered {0} temperatures.", count);
        WriteLine("The average temperature is {0} degrees Fahrenheit.", average);
        // keeps console open until a key is pressed
        ReadKey(true);
    }
}
