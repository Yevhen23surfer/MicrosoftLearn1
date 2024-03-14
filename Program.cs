string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin"))
{
    if (level > 55) // If the user is an Admin with a level greater than 55, output the message:
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else // If the user is an Admin with a level less than or equal to 55, output the message:
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}

else if (permission.Contains("Manager"))
{    // If the user is a Manager with a level 20 or greater, output the message:
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    // If the user is a Manager with a level less than 20, output the message:
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}

else
{   //If the user is not an Admin or a Manager, output the message:
    Console.WriteLine("You do not have sufficient privileges.");
}





