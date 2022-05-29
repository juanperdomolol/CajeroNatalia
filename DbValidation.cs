using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroNatalia
{
     class DbValidation
    {
        public string [] users = { "Natalia", "Valentin", "Maria" };
        public int[] passwords = { 2089, 1703, 0000 };
        public int[] ammount = { 2100000, 1000000, 1000 };
        public int[] VivaColombia = { 666, 200, 6000 };
        public int DailyAmmount;

        public int ExistUser(string userName)
        {
            int exist = -1;
            for (int i = 0; i < users.Length; i++)
            {

                if (users[i]== userName)
                {
                    exist = i;
                } 
            }
  
            return exist;
        }

        public int ExistWithPassword(int password)
        {
            int exists = 0;
            foreach (int pass in passwords)
            {
                if(password.Equals(pass))
                exists = 1;
            }
            return exists;
        }
    }
}
