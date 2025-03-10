
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("diga seu nome");
        String ola = nome();
        Console.WriteLine(ola);
        data();
        Console.WriteLine("seu id é:");
        Console.WriteLine(randomizar());
        /////
        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("seus dados estão certo?");
            String sim = Console.ReadLine();
            if (sim.ToLower() == "não")
            {
                Console.WriteLine("oque quer mudar");
                Console.WriteLine("(0)nome");
                Console.WriteLine("(1) ano");
                Console.WriteLine("(2) id ");
                int seupai = Convert.ToInt32(Console.ReadLine());
                switch (seupai)
                {
                    case 0:
                        Console.WriteLine("digite seu nome");
                        String name = nome();
                        Console.WriteLine("seu nome agora é:" + name);
                        break;
                    case 1:
                        Console.WriteLine("digite o ano em que nasceu");
                        data();
                        Console.WriteLine("sua idade:" +data);
                        break;
                    case 2:
                        Console.WriteLine("seu id é:");
                        Console.WriteLine(randomizar());
                        break;
                }

            }
            else if (sim.ToLower() == "sim")
            {
                continuar = false;
                Console.WriteLine("dados confirmados");
            }
            else
            {
                Console.WriteLine("reposta errada doido digite sim ou não");
            }

        }

    }
    static String nome()
    {

        String ola = Console.ReadLine();
        return ola;
    }
    static void data()
    {

        while (true)
        {
            Console.WriteLine("digite o ano em que nasceu");
            String digite = Console.ReadLine();
            if (int.TryParse(digite, out int numero))
            {
                Console.WriteLine("sua idade é:" + digite);
                break;
            }
            else
            {
                Console.WriteLine("erro,digite novamente");
            }
        }




    }
    static int randomizar()
    {
        Random random = new Random();
        int exato = random.Next(100000, 1000000);
        return exato;
    }


}