Random rand = new Random();
int randnumber = rand.Next(100, 1000);
System.Console.WriteLine(randnumber);
int seconddigit = randnumber%10;
int firstdigit = randnumber/100;
System.Console.WriteLine($"{firstdigit}{seconddigit}");