// Nombre del archivo: Program.cs
// Este archivo contiene el programa principal de la calculadora.

using FuncionesCalculadora; // Importa el espacio de nombres

public class Calculadora5 // Nombre de la clase actualizado a Calculadora5
{
    public static void Main(string[] args)
    {
        // Información para el usuario sobre el programa
        Console.WriteLine("\n\nEste programa es una calculadora que realiza operaciones básicas como suma, resta, mutiplicación, y división.");
        Console.WriteLine("Podrá ingresar los numeros que el usuario diga que ingresará.");
        Console.WriteLine("Ejemplo, pide sumar 5 numeros, el usuario ingresa 5 números y luego se detiene.");
        Console.WriteLine("El programa suma, resta, multiplica, o divide los números ingresados y muestra el resultado.");

        string terminar = "s"; // Inicializa la variable terminar con "s" para entrar al bucle
        double resultado = 0D; // Inicializa la variable resultado en 0
        int contador = 0; // Inicializa el contador en 0

        do
        {
            string operador = "+"; // Inicializa el operador en "+"
            int cantidadNumeros = 0; // Inicializa la cantidad de números en 0
            contador++; // Incrementa el contador en cada iteración

            // Solicitar al usuario la cantidad de números a ingresar
            Console.WriteLine("\n\nIngrese la cantidad de números: ");
            cantidadNumeros = Convert.ToInt32(Console.ReadLine());

            double[] numeros = new double[cantidadNumeros]; // Inicializa el arreglo de números con la cantidad ingresada por el usuario

            Console.WriteLine("'+' es para sumar, '-' es para restar, '*' es para multiplicar, '/' es para dividir.");
            Console.WriteLine("Ingrese el operador ('+' o '-' o '*' o '/'): ");
            operador = Console.ReadLine() ?? ""; // Operador con validador, si es null, asigna cadena vacía para que en el caso de que el usuario no ingrese nada, no se rompa el programa.

            // Bucle para ingresar los números
            for (int i = 0; i < cantidadNumeros; i++)
            {
                Console.WriteLine($"Ingrese el número {i + 1}: ");
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Realizar la operación según el operador
            switch (operador)
            {
                case "+":
                    resultado = ClaseCalculadora.SumarNumeros(numeros, resultado);
                    break;
                case "-":
                    resultado = ClaseCalculadora.RestarNumeros(numeros, resultado);
                    break;
                case "*":
                    resultado = ClaseCalculadora.MultiplicarNumeros(numeros, resultado, contador);
                    break;
                case "/":
                    resultado = ClaseCalculadora.DividirNumeros(numeros, resultado, contador);
                    break;
                default:
                    Console.WriteLine("Operador no válido. Saliendo del programa.");
                    return;
            }

            // Verificar si hubo un error (resultado es NaN)
            if (double.IsNaN(resultado))
            {
                // Manejar el error (por ejemplo, mostrar un mensaje de error)
                Console.WriteLine("¡Error! La operación no se pudo realizar.");
                resultado = 0; // Reiniciar resultado a 0
            }
            else
            {
                // Muestra el resultado de la operación
                Console.WriteLine($"El resultado de la operación es: {resultado}");
            }

            // Pregunte si desea continuar
            Console.WriteLine("¿Desea continuar la operación? \nEn caso de querer, ingrese 's', en caso de no querer, ingrese cualquier caracter: ");
            terminar = (Console.ReadLine() ?? "f").ToLower(); // terminar con validador, si es null, asigna "f" para que no se rompa el programa y termine el bucle.

        } while (terminar == "s");

        // Despedida + Creditos
        Console.WriteLine("Gracias por usar la calculadora!");
        Console.WriteLine("Desarrollado por: Arianna Torres");
    }
}
