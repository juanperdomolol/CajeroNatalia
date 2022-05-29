//Consulta de saldo.
//Retiros, solo si el saldo es mayor a la cantidad solicitada y si no supera
//el tope diario de retiros establecidos por el banco. Es decir que no
//podrá retirar más de dos millones de pesos diarios.
//Transferencias entre cuentas del mismo banco, para ello debe validar si
//existe la cuenta destino.
//Consulta de puntos ViveColombia
//Canje de puntos ViveColombia
namespace CajeroNatalia
{
    class Program
    {
        static void Main(string[] args)
        {
            DbValidation validation = new DbValidation();
            Operations operation = new Operations();
            string userName;
            int password, validation1, validation2;
            do
            {
                try
                {
                    Console.WriteLine("Write your username");
                    userName = Console.ReadLine();
                    Console.WriteLine("Write your password");
                    password = int.Parse(Console.ReadLine());
                    validation1 = validation.ExistUser(userName);
                    Console.WriteLine(validation1);
                    validation2 = validation.ExistWithPassword(password);
                    if(validation1!= -1 && validation2!= 0)
                    {
                        Console.WriteLine("Exists Bitch");
                        operation.MenuOptions(validation1);
                    }
                    else
                    {
                        Console.WriteLine("Abrite de aca ome");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Fallo exitosamente");
                }

            } while (true);
        }
    }
}