using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = " Bruce";
            //Console.WriteLine("My name is" + name);
            string email = " peacebruce9@gmail.com";
            /*string[] domain = email.Split("@"); 
            Console.WriteLine("" + domain[1]);       
            Console.WriteLine("" + domain[1]);/* */
            string email2 = email.Replace("gmail","outlook");
            //Console.WriteLine("" + email2);
            /*Console.WriteLine(email.Trim().ToUpper());
            Console.WriteLine(email2.Trim().ToUpper());*/
            //Console.WriteLine("" + email.Length);
            Console.WriteLine($"My email is {email2} with length {email2.Length}");





        }
    }
}
