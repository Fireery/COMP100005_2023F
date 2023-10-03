//Ex-1
string firstName;
char middleInitial;
string lastName;

Console.WriteLine("Enter your first name:");
firstName = Console.ReadLine();
Console.WriteLine("Enter your middle initial:");
middleInitial = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Enter your last name:");
lastName = Console.ReadLine();

Console.WriteLine($"{firstName}{lastName}");
Console.WriteLine($"{firstName}{middleInitial}{lastName}");
Console.WriteLine($"{lastName}{firstName}{middleInitial}");

//Ex-2
