using System;

namespace Pasword
{
    class Program
    {
        static void Main(string[] args)
        {
            string masterpw; 
            
            if(args.Length>0)
            {
                if (args[0] == "init")
                {
                    Console.WriteLine("Type in the master password: ");
                    masterpw = Console.ReadLine();
                    Console.WriteLine(" Your master password is " + masterpw);
                }
                else if (args[0] == "login")
                {   
                    //create a client which will be used as a log in--> use maybe method 
                    //ask for master pass and key
                    //if the masterpw is correct u can do thingss such as get set etc 

                }
                else if (args[0] == "get")
                {
                    
                    //print the velue stored under promp
                    //if prop is not provided, list all stored props in plain text 

                }
                else if (args[0] == "set")
                {
                    //value under prop is set in server 
                    //if value already exists then its overriden, create a method for overriding and then just call it in here?
                    //if prop is not provided write an error message 
                }
                else if (args[0] == "drop")
                {
                    //drop the property which is stored under prop
                    //if the master pw is incorrect create an error message

                    Console.WriteLine("The password you have entered is incorrect");
                }
                else if (args[0] == "secret")
                {
                    //print the key which is stored in client 
                }
                else
                {
                    Console.WriteLine(" Invalid input ");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid input"); 
            }


            
        }

        

        // in Aprop--> store the prop values in the vault 
        public int OverrideSet(int [] Aprop, int newprop, int existingprop)
        {
            // existingprop is the one already in vault

            Console.WriteLine("Write the new value to be put in the vault: ");
            //wrute to take in from console the pw = Console.ReadLine();
            newprop.ToString(); 
            
            if (Aprop.Length > 0 && Aprop[0]==existingprop)
            {
                existingprop = newprop;
                //set the new prop to the old value not sure how to 
                 
            }
            return newprop;
        }

       

    }
}
