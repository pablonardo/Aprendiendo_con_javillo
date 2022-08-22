namespace Pruebita
{
    public static class Iteracion
    {
        public static void While()
        {
            //short vecesEjecutado = 0;

            ////-32.768
            //while (vecesEjecutado != short.MinValue)
            //{
            //    Console.WriteLine($"Va por el numero {vecesEjecutado}, que es un numero magico");
            //    vecesEjecutado++;
            //    //Console.WriteLine("Va por el numero " + vecesEjecutado + ", que es un numero magico");
            //}


            var miListaDeEnteros = new List<int>();


            for (int i = 0; i < 7; i++)
            {
                miListaDeEnteros.Add(i);
            }

            Console.ReadLine();
        }
    }
}
