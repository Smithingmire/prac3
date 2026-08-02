using System;
namespace practical_3_exception_handling
{
    class Program
    {
        public class ExpenseTracker
        {
            private int expenseID;
            private int expenseAMOUNT;
            private string expenseCATEGORY;
            private string paymentMODE;
            private DateTime expenseDateTime;

            public ExpenseTracker(int id, int amount, string category, string payMode)
            {
                this.expenseID = id;
                this.expenseAMOUNT = amount;
                this.expenseCATEGORY = category;
                this.paymentMODE = payMode;
                expenseDateTime = DateTime.Now;
            }

            public void Display()
            {
                Console.WriteLine("--- Expense Summary ---");
                Console.WriteLine($"ID: {expenseID}");
                Console.WriteLine($"Amount: {expenseAMOUNT}");
                Console.WriteLine($"Category: {expenseCATEGORY}");
                Console.WriteLine($"Payment Mode: {paymentMODE}");
                Console.WriteLine($"Date & Time : {expenseDateTime:dd-MM-yyyy HH:mm:ss}");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Provide your expense details --->");

                Console.Write("Enter Expense ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Amount: ");
                int amount = Convert.ToInt32(Console.ReadLine());

                if (amount < 0)
                {
                    throw new ArgumentException("Amount can't be less than zero.");
                }

                Console.Write("Enter Category: ");
                string category = Console.ReadLine();

                Console.Write("Enter Mode of Payment: ");
                string payMode = Console.ReadLine();

                ExpenseTracker e1 = new ExpenseTracker(id, amount, category, payMode);
                e1.Display();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number only.");
            }
            catch (ArgumentException aex)
            {
                Console.WriteLine($"Manual Exception: {aex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }
        }
    }
}