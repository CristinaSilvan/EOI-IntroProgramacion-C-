string firstName = "Bob";
string message = $"Hello {firstName}!";
WriteLine(message); // se lleva a cabo con el caracter $ delante de la cadena


string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine($"{greeting} {firstName}!");

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data"); //Combinación del literal con la interpolación