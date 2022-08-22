namespace Pruebita
{
    internal class IfySwitch
    {
        public static void PruebaIfSwitch()
        {
            while(true)
            {
                Console.WriteLine("Escriba su signo zodiacal: ");

                string signo = Console.ReadLine();

                if (signo == "Geminis")
                {
                    Console.WriteLine("Te haces el misterioso");
                }
                else if (signo == "Piscis")
                {
                    Console.WriteLine("Te gusta la mayonesa y llorar");
                }
                else if (signo == "Tauro")
                {
                    Console.WriteLine("Sos falopa y ganador");
                    break;
                }

                var entroAlSwitch = false;

                switch (signo)
                {
                    case "Acuario":
                    case "Capricornio":
                        Console.WriteLine("Tenes olor a carpincho");
                        break;

                    case "Aries":
                        Console.WriteLine("Tenes olor a culo");
                        entroAlSwitch = true;
                        break;
                }

                Console.ReadKey();
            }
            
        }

    }
}
