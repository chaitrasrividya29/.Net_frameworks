namespace ConsoleApp4
{
    public class Bankaccount

        {
            private string _AccountNumber;
             public string accountName
        {
            get { 
                return "DDDFFWDW"+_AccountNumber+ "DDDD";
            }


            set
            {
                if (value.Length == 10)
                {
                    _AccountNumber = value;
                }
                else
                {
                    Console.WriteLine("account id should be 10 characters");
                }
            }

        }


    }
{
        static void Main(string[] args)
        {
        Bankaccount b = new Bankaccount();
        b.accountName = "0123456789";
        Console.WriteLine(b.accountName);
        b.
        }
    }
}
