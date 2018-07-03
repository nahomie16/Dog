using System;

namespace Dog
{
    class Dog
    {
       // "If lost, call [owner]. ['Her'|'His'] name is [
        public String name = "";
        public int age; 
        public String owner = "";

        Dog(String owner, String name, int age, Gender g){ //Constructor
            this.owner = owner;
            this.name = name;
            this.age = age; 
            // this,

        }
        int bark(int num_barks){
            for (int i = 0; i < num_barks; i++)
            {
                Console.WriteLine("Woof!");
            }

        }

        String getTag(){

            return "If lost, call {0}. ['Her'|'His'] name is {1} and ['she'|'he'] is {2}  ['year'|'years'] old.", this.owner, this.name, this.age;;  
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
