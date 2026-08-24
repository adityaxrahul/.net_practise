using System;

class Student
{
    private int id, age;
    private string name, gender, branch, scholarship, hostel, library, status;
    private double percentage;

    public Student(int i, string n, int a, string g, double p)
    {
        id = i;
        name = n;
        age = a;
        gender = g;
        percentage = p;

        if (percentage >= 90)
        {
            branch = "Artificial Intelligence";
            scholarship = "100% Scholarship";
            hostel = "Available";
            library = "Premium Access";
            status = "Confirmed";
        }
        else if (percentage >= 80)
        {
            branch = "Computer Engineering";
            scholarship = "75% Scholarship";
            hostel = "Available";
            library = "Premium Access";
            status = "Confirmed";
        }
        else if (percentage >= 70)
        {
            branch = "Information Technology";
            scholarship = "50% Scholarship";
            hostel = "Not Available";
            library = "Standard Access";
            status = "Confirmed";
        }
        else
        {
            branch = "Civil Engineering";
            scholarship = "25% Scholarship";
            hostel = "Not Available";
            library = "Standard Access";
            status = "Waiting List";
        }
    }

    public void Display()
    {
        Console.WriteLine("\n===== STUDENT ADMISSION REPORT =====");
        Console.WriteLine("Student ID       : " + id);
        Console.WriteLine("Name             : " + name);
        Console.WriteLine("Age              : " + age);
        Console.WriteLine("Gender           : " + gender);
        Console.WriteLine("Percentage       : " + percentage + "%");
        Console.WriteLine("Branch           : " + branch);
        Console.WriteLine("Scholarship      : " + scholarship);
        Console.WriteLine("Hostel           : " + hostel);
        Console.WriteLine("Library Access   : " + library);
        Console.WriteLine("Admission Status: " + status);
    }
}

class Program
{
    static void Main(string[] args)
    {
        double totalMarks, obtainedMarks, percentage;

        Console.Write("Enter Total Marks: ");
        totalMarks = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Obtained Marks: ");
        obtainedMarks = Convert.ToDouble(Console.ReadLine());

        percentage = (obtainedMarks / totalMarks) * 100;

        Console.WriteLine("\nPercentage = " + percentage + "%");

        if (percentage < 60)
        {
            Console.WriteLine("Sorry! Admission Rejected.");
            return;
        }

        Console.WriteLine("Congratulations! You are eligible for admission.");

        Console.Write("Enter Student ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Gender: ");
        string gender = Console.ReadLine();

        Student s1 = new Student(id, name, age, gender, percentage);
        s1.Display();
    }
}