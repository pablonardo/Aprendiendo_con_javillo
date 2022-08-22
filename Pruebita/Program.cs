using Pruebita;

public static class Program
{
    public static void Main(string[] args)
    {
        //IfySwitch.PruebaIfSwitch();
        //Iteracion.While();


        Console.WriteLine("Escriba primer numero: ");
        decimal num1 = Convert.ToDecimal(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Escriba segundo numero: ");
        decimal num2 = Convert.ToDecimal(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Escriba operador: ");
        char operador = Console.ReadKey().KeyChar;
        Console.Clear();

        Console.WriteLine($"La cuenta sera: {num1} {operador} {num2}");

        //string saludo = "8+3";

        //bool contieneEspacio = saludo.Contains('+');
        //contieneEspacio = saludo.Contains();

        decimal resultado = 0;

        switch (operador)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case '/':
                resultado = num1 / num2;
                break;
        }

        Console.WriteLine($"el resultado de la operacion es {resultado}");

    }
}