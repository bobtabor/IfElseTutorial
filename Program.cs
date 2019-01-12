using System;

namespace IfElseTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Let's suppose we need to display a
            // different message depending on the value
            // of an int.

            // int -> -2,147,483,648 to 2,147,483,647

            int value = 3;

            /*
            if (value == 3) {
                Console.Clear();
                Console.Beep();
                Console.WriteLine("Value is 3");
            }
            */            

            // Can shorten IF there's only one statement
            // in the code block.
            /* 
            if (value == 3) 
                Console.WriteLine("This also works");
            */

            // The else can be added to branch
            // the execution path:
            /*
            if (value == 3) {
                Console.WriteLine("Value is 3");
            } else if(value > 3) {
                Console.WriteLine("Value is greater than 3");
            } else {
                Console.WriteLine("Value is less than 3");
            }
             */

            // Some common operators used for comparrisson
            // or evaluation:
            // == equal to
            // > greater than or equal to
            // < less than or equal to 
            // >= greater than or equal to
            // <= less than or equal to
            // || or 
            // != not equal 
            // !

            // bool used = false;

            // bool -> true or false 
            // ALSO false == 0, anthing else is true (rare cases you'll need this)

            /*

            if (!used) {
                Console.WriteLine("That's not used.");
            }

            if (used || value == 3) {
                Console.WriteLine("It's used or the value is three (or both)");
            }
             */
             
        }
    }
}
