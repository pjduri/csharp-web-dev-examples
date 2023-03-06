using HelloMethods;

string language;
string name;

Console.WriteLine("Choose a language: ");
language = Console.ReadLine();
Console.WriteLine("Enter your name: ");
name = Console.ReadLine();
string message = Message.GetMessage(language, name);
Console.WriteLine(message);