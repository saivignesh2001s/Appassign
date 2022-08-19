namespace UserappAugAssign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fname, lname;
            Console.WriteLine("Enter fname");
            fname = Console.ReadLine();
            Console.WriteLine("Enter lname");
            lname = Console.ReadLine();
            string uname, password;
            Console.WriteLine("Enter uname");
            uname = Console.ReadLine();
            Console.WriteLine("Password");
            password = Console.ReadLine();
            if ((fname == uname) && (lname == password)&&(!String.IsNullOrEmpty(uname))&&(!String.IsNullOrEmpty(password)))
                Console.WriteLine("Welcome to my app"+" "+fname+lname);
            else
            {

                if (fname != uname && lname != password)
                    Console.WriteLine("Password and uname unmatched");
                else if (fname != uname)
                    Console.WriteLine("uname unmatched");
                else if ((String.IsNullOrEmpty(uname)) || (String.IsNullOrEmpty(password)))
                    Console.WriteLine("uname or password can't be null");
                else
                    Console.WriteLine("Password unmatched");

     }
            Console.ReadLine();
        }
    }
}