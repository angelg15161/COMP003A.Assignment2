/*
    Author: Angel Gomez
    Course: COMP003A
    Faculty: Jonathan Cruz
    Purpose: A program that acts as a discount calculator.
*/
namespace COMP003A.Assignment2;

class Program
{
    static void Main(string[] args)
    {
        // Variable names
        string firstName; 
        string lastName;
        int userAge;
        double productPrice;
        bool isStudent;

        // Welcome to the discount calculator 
        Console.WriteLine("*********************************************************");
        Console.WriteLine("Welcome to the Discount Calculator!");
        Console.WriteLine("*********************************************************");
        
        // Prompt user to enter info
        Console.Write("What is your first name? ");
        firstName = Console.ReadLine();
        
        Console.Write("What is your last name? ");
        lastName = Console.ReadLine();
        
        string userName = firstName + " " + lastName; // Combines the user's first and last name 
        
        Console.Write("How old are you? ");
        userAge = int.Parse(Console.ReadLine());
        
        Console.Write("What is the price of the item you're interested in? $");
        productPrice = double.Parse(Console.ReadLine());
        
        Console.Write("Are you a student? (true/false): ");
        isStudent = bool.Parse(Console.ReadLine());
        
        // Calculations 
        int futureAge = userAge + 5;
        double studentDiscount = productPrice * 0.9; // 10% Student Discount 
        double seniorDiscount = productPrice * 0.8; // 20% Senior Discount 
        
        // Outputs 
        Console.WriteLine("\n\n*********************************************************");
        Console.WriteLine($"Hello, {userName}!");
        Console.WriteLine($"Your current age is {userAge}.");
        Console.WriteLine($"In 5 years, you will be {futureAge}.");
        Console.WriteLine($"The original price of the item is ${productPrice}.");
        
        if (isStudent == true) // If the user is a student then the Student Discount will appear 
        {
            Console.WriteLine($"As a student, your discounted price is ${studentDiscount}.");
        }

        if (userAge >= 60) // If the user's age is greater than or equal to 60 then the senior citizen Discount will appear 
        {
            Console.WriteLine($"As a senior citizen, your discounted price is ${seniorDiscount}.");
        }

        if (isStudent == false && userAge < 60) // No discount will show if the user is neither a student nor senior citizen 
        {
            Console.WriteLine($"Unfortunately there are no discounts for you. \nSorry, {userName}.");
        }
        
        Console.WriteLine("*********************************************************");
    }
}