using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1_OOP
{
    class Bankac
    {
        public string AcNumber;
        public double Balance;
        public string CustomerName;
        public string Email;
        public int PhoneNumber;

        public Bankac(string Pacnumber, double PBalance, string PCusName, string PEmail, int Pphonenum)
        {
            AcNumber = Pacnumber;
            Balance = PBalance;
            CustomerName = PCusName;
            Email = PEmail;
            PhoneNumber = Pphonenum;


        }

        public string AddMoney(double PAddmoney)
        {
            Balance = Balance + PAddmoney;
           return $"Your New Balance is:{Balance}";
        }

        public string DeductMoney(double PDeductmoney)
        {
            if (PDeductmoney <= Balance)
            {
                Balance = Balance - PDeductmoney;
                return $"Your New Balance is:{Balance}";
            }
            else
            {
                return "Error";
            }
            
        }



    }
}
