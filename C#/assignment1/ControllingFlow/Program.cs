using ControllingFlow;

//FizzBuzz game
FizzBuzz fz = new FizzBuzz();
fz.Count();

//The following code results in an infinite loop
//int max = 500;
//for (byte i = 0; i < max; i++)
//{
//    Console.WriteLine(i);
//}
// can add `if (i==255) break;` inside the for loop to prevent the infinite loop

//Print a pyramid
PrintPyramid pp = new PrintPyramid();
pp.Print();

//Guess number game
GuessNumber gn = new GuessNumber();
gn.Guess();

//Calculate age in days
AgeInDays aid = new AgeInDays();
aid.Birthdate = "2000/01/06"; // have to be in the format yyyy/mm/dd
aid.Calculate();

//Greet user base on time of day
Greeting g = new Greeting();
g.Dt = DateTime.Now;
g.Greet();

//Count up to 24
CountTo24 c = new CountTo24();
c.Count();

