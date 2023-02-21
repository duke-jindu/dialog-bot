using System;
class greetingapp
{
    static void Main(String[] args)
    {
        bool Running = true;

        while (Running)
        {
            string name;
            int age;



            Console.WriteLine("what is your name?");
            name = Console.ReadLine();

            Console.WriteLine($"helo {name}, how old are you? {name}");
            var ageRespond = Console.ReadLine();
            age = Convert.ToInt32(ageRespond);


            switch (age)
            {
                case var myAge when myAge < 18:
                    Console.WriteLine("too young to be playing this game, MOVE ON!");
                    break;

                        case var myAge when myAge < 70:
                    Console.WriteLine("thanks for visiting");
                        break;

                case var myAge when myAge >= 70:
                    Console.WriteLine("you too advance for this service, NO OFFENSE!");
                        break;
                default:
                    Console.WriteLine("thank you, try again");
                    break;
            }

            Console.WriteLine($"you are {age} years old");    
            Console.WriteLine("do you want to continue?");
            string RunningResponse = Console.ReadLine();
            if(RunningResponse == "no") 
            {
               Running = false;
            }
        }
    }
}


