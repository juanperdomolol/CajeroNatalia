using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroNatalia
{
     class Operations
    {
        int Ammount, Points, SelectOption;
        DbValidation validation = new DbValidation();

        public void MenuOptions(int userName)
        {
            do
            {
                Console.WriteLine("1. Check your balance");
                Console.WriteLine("2. Withdrawals your balance");
                Console.WriteLine("3. Transfer money");
                Console.WriteLine("4. Check points Colombia");
                Console.WriteLine("5. Redeem points  Colombia");
                Console.WriteLine("6. Exit");
                SelectOption = int.Parse(Console.ReadLine());
                switch (SelectOption)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Press for continue");
                        AmmountBalance(userName);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Press for continue");
                        Withdrawals(userName);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Transfer(userName);
                        Console.WriteLine("Press for continue");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        PointsColombia(userName);
                        Console.WriteLine("Press for continue");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        ClaimPoints(userName);
                        Console.WriteLine("Press for continue");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Press for continue");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opcion de transaccion no valida");
                        break;
                }
            } while (SelectOption != 6);

        }
        private void AmmountBalance(int userName)
        {
            Console.WriteLine("Your balance is " + validation.ammount[userName]);
        }
        private void Withdrawals(int userName)
        {
            int option;
            Console.WriteLine("How much do you  want to withdrwals");
            Console.WriteLine("1. $20.000");
            Console.WriteLine("2. $50.000");
            Console.WriteLine("3. $100.000");
            Console.WriteLine("4. $500.000");
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1: 
                    if (20000 <= validation.ammount[userName] && validation.DailyAmmount <=2000000)
                    {
                        validation.ammount[userName] -= 20000;
                        validation.DailyAmmount += 20000;
                        Console.WriteLine("your balance actual is " + validation.ammount[userName]);
                    }
                    else
                    {
                    Console.WriteLine("Sorry you exceden withdrwals or ypu dont have its ammount");
                    }
                    break;
                case 2:
                    if (50000 <= validation.ammount[userName] && validation.DailyAmmount <= 2000000)
                    {
                        validation.ammount[userName] -= 50000;
                        validation.DailyAmmount += 50000;
                        Console.WriteLine("your balance actual is " + validation.ammount[userName]);
                    }
                    else
                    {
                    Console.WriteLine("Sorry you exceden withdrwals or ypu dont have its ammount");
                    }
                    break;
                case 3:
                    if (100000 <= validation.ammount[userName] && validation.DailyAmmount <= 2000000)
                    {
                        validation.ammount[userName] -= 100000;
                        validation.DailyAmmount += 100000;
                        Console.WriteLine("your balance actual is " + validation.ammount[userName]);
                    }
                    else
                    {
                    Console.WriteLine("Sorry you exceden withdrwals or ypu dont have its ammount");
                    }
                    break;
                case 4:
                    if (500000 <= validation.ammount[userName] && validation.DailyAmmount <= 2000000)
                    {
                        validation.ammount[userName] -= 500000;
                        validation.DailyAmmount += 500000;
                        Console.WriteLine("your balance actual is " + validation.ammount[userName]);
                    }
                    else
                    {
                    Console.WriteLine("Sorry you exceden withdrwals or ypu dont have its ammount");
                    }
                    break;
                default:
                    Console.WriteLine("Elegiste una opcion erronea");
                    break;
            }

        }
        private void Transfer(int UserName)
        {
            string user;
            int validation1;
            Console.WriteLine("Name of person please");
            user = Console.ReadLine();
            validation1 = validation.ExistUser(user);
            if (validation1 != -1) ValidUser(UserName, validation1);
            else Console.WriteLine("User not exist");

        }
        private void ValidUser (int UserName, int validation1)
        {
            int option;
            Console.WriteLine("Valid user, how much do you want to transfer?");
            Console.WriteLine("1. 20.000");
            Console.WriteLine("2. 50.000");
            Console.WriteLine("3. 100.000");
            Console.WriteLine("4. 500.000");
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    if (20000 <= validation.ammount[UserName])
                    {
                        Console.WriteLine("Transfer succes");
                        validation.ammount[UserName] -= 20000;
                        Console.WriteLine("your balance actual is " + validation.ammount[UserName]);
                    }
                    else
                    {
                        Console.WriteLine("Balance insufficiente");
                    }
                    break;
                case 2:
                    if (50000 <= validation.ammount[UserName])
                    {
                        Console.WriteLine("Transfer succes");
                        validation.ammount[UserName] -= 50000;
                        Console.WriteLine("your balance actual is " + validation.ammount[UserName]);
                    }
                    else
                    {
                        Console.WriteLine("Balance insufficiente");
                    }
                    break;
                case 3:
                    if (100000 <= validation.ammount[UserName])
                    {
                        Console.WriteLine("Transfer succes");
                        validation.ammount[UserName] -= 100000;
                        Console.WriteLine("your balance actual is " + validation.ammount[UserName]);
                    }
                    else
                    {
                        Console.WriteLine("Balance insufficiente");
                    }
                    break;
                case 4:
                    if (500000 <= validation.ammount[UserName])
                    {
                        Console.WriteLine("Transfer succes");
                        validation.ammount[UserName] -= 500000;
                        Console.WriteLine("your balance actual is " + validation.ammount[UserName]);
                    }
                    else
                    {
                        Console.WriteLine("Balance insufficiente");
                    }
                    break;
                default:
                    Console.WriteLine("Sorry you put a option incorrect");  
                    break;
            }
        }
        private void PointsColombia(int UserName)
        {
            Console.WriteLine("Your points Colombia");
            Console.WriteLine("total: " + validation.VivaColombia[UserName]);
        }
        private void ClaimPoints(int UserName)
        {
            int pointsClaim;
            Console.WriteLine("Your points Colombia");
            Console.WriteLine("total: " + validation.VivaColombia[UserName]);
            Console.WriteLine("How much point do you want claim?");
            pointsClaim = int.Parse(Console.ReadLine());
            validation.VivaColombia[UserName] -= pointsClaim;
            Console.WriteLine("Your points now"+validation.VivaColombia[UserName]);
        }
    }
}

