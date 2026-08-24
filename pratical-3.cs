using System;
using System.Collections.Generic;

class Expense
{
    public int ExpenseId { get; set; }
    public string Category { get; set; }
    public decimal Amount { get; set; }
    public string Note { get; set; }

    public Expense(int id, string category, decimal amount, string note)
    {
        ExpenseId = id;
        Category = category;
        Amount = amount;
        Note = note;
    }
}

class ExpenseManager
{
    private readonly List<Expense> expenseList = new List<Expense>();

    public void Add()
    {
        try
        {
            int id = ReadInteger("Enter Expense ID: ");

            Console.Write("Enter Category: ");
            string category = Console.ReadLine();

            decimal amount = ReadDecimal("Enter Amount: ");

            if (amount <= 0)
            {
                throw new ArgumentException("Amount cannot be zero or negative.");
            }

            Console.Write("Enter Description: ");
            string note = Console.ReadLine();

            expenseList.Add(new Expense(id, category, amount, note));

            Console.WriteLine("Expense added successfully.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter correct values.");
        }
        catch (ArgumentException error)
        {
            Console.WriteLine(error.Message);
        }
    }

    private int ReadInteger(string message)
    {
        Console.Write(message);
        return int.Parse(Console.ReadLine());
    }

    private decimal ReadDecimal(string message)
    {
        Console.Write(message);
        return decimal.Parse(Console.ReadLine());
    }

    public void ShowAll()
    {
        if (expenseList.Count == 0)
        {
            Console.WriteLine("No expense records found.");
            return;
        }

        Console.WriteLine("\n------ EXPENSE DETAILS ------");

        foreach (Expense item in expenseList)
        {
            Console.WriteLine(
                $"ID: {item.ExpenseId} | " +
                $"Category: {item.Category} | " +
                $"Amount: ₹{item.Amount} | " +
                $"Note: {item.Note}"
            );
        }
    }

    public void ShowTotal()
    {
        try
        {
            if (expenseList.Count == 0)
                throw new InvalidOperationException("No expenses to calculate.");

            decimal total = 0;

            foreach (Expense item in expenseList)
            {
                total += item.Amount;
            }

            Console.WriteLine($"Total Expense: ₹{total}");
        }
        catch (InvalidOperationException error)
        {
            Console.WriteLine(error.Message);
        }
    }
}

class Program
{
    static void Main()
    {
        ExpenseManager manager = new ExpenseManager();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("      EXPENSE TRACKER");
            Console.WriteLine("==============================");
            Console.WriteLine("1. Add Expense");
            Console.WriteLine("2. Display Expenses");
            Console.WriteLine("3. Show Total");
            Console.WriteLine("4. Exit");
            Console.WriteLine("==============================");

            try
            {
                Console.Write("Select option: ");
                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    manager.Add();
                }
                else if (option == 2)
                {
                    manager.ShowAll();
                }
                else if (option == 3)
                {
                    manager.ShowTotal();
                }
                else if (option == 4)
                {
                    running = false;
                    Console.WriteLine("Program closed.");
                }
                else
                {
                    Console.WriteLine("Please select an option between 1 and 4.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}