using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab7GC
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a name, please: ");
                string Name = Console.ReadLine();
                CheckName(Name);

                Console.Write("Enter a phone number, please: ");
                string PhnNumber = Console.ReadLine();
                CheckPhone(PhnNumber);

                Console.Write("enter a valid e-mail, please: ");
                string Email = Console.ReadLine();
                CheckEmail(Email);

                Console.Write("Enter a date in \"dd/mm/yyyy\" format: ");
                string Date = Console.ReadLine();
                CheckDate(Date);

                Console.Write("Enter a block of HTML code, please:");
                string HTML = Console.ReadLine();
                CheckHTML(HTML);

                Console.WriteLine("Enter new validation strings? (enter \"y\" to continue or any other button to quit)");
                string Continue = Console.ReadLine();

                if(Continue == "y")
                {
                    continue;
                }
                break;
            }
        }
        private static void CheckName(string name)
        {
            if (Regex.IsMatch(name, @"^[A-Z][a-z]{0,29}$"))
            {
                Console.WriteLine("Valid name, thank you! \n");
            }
            else
            {
                Console.WriteLine("Not a valid name, sorry \n");
            }
        }
        private static void CheckEmail(string email)
        {
            if (Regex.IsMatch(email, @"^\w{5,30}@\w{5,10}\.\w{2,3}$"))
            {
                Console.WriteLine("Valid name, thank you! \n");
            }
            else
            {
                Console.WriteLine("Not a valid name, sorry \n");
            }
        }
        private static void CheckPhone(string phone)
        {
            if (Regex.IsMatch(phone, @"^\d{3}-\d{3}-\d{4}$"))
            {
                Console.WriteLine("Valid date, thank you! \n");
            }
            else
            {
                Console.WriteLine("Not a valid date, sorry. \n");
            }
        }
        private static void CheckDate(string date)
        {
            if (Regex.IsMatch(date, @"^(((0[1-9]|1[012])\/(0[1-9]|1\d|2[0-8])|(0[13456789]|1[012])\/(29|30)|(0[13578]|1[02])\/31)\/[2-9]\d{3}|02\/29\/(([2-9]\d)(0[48]|[2468][048]|[13579][26])|(([2468][048]|[3579][26])00)))$"))
            {
                Console.WriteLine("Valid date, thank you! \n");
            }
            else
            {
                Console.WriteLine("Not a valid date, sorry. \n");
            }
        }
        private static void CheckHTML(string html)
        {
            if (Regex.IsMatch(html, @"^<\w{1,}>.{1,}<\w{1,}>$"))
            {
                Console.WriteLine("Valid HTML code, thank you! \n");
            }
            else
            {
                Console.WriteLine("Not valid html code, sorry \n");
            }
        }
    }
}
