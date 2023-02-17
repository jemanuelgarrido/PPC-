Console.WriteLine("Hello Welcome");
byte edad;
try


{
    Console.WriteLine("Digite su edad ejem 20");
    edad = Convert.ToByte(Console.ReadLine());

    Console.WriteLine($"No aparentas {edad} años");
}
catch (Exception ex)
{
    Console.WriteLine("Ups no entendiste");
    Console.WriteLine("La excepcion es:" + ex.Message);
}

try
{
    byte num1, num2;


    ushort multiplicacion;

    Console.WriteLine($"Ingrese el primer digito de dos cifras ejem 22");
    num1 = Convert.ToByte(Console.ReadLine());
    Console.WriteLine($"Ingrese la segunda cifra de dos digitos");
    num2 = Convert.ToByte(Console.ReadLine());
    multiplicacion = (ushort)(num1 * num2);

    Console.WriteLine($"El resultado de la multiplicacion es:{multiplicacion}");
}
catch (Exception ex)
{
    Console.WriteLine("Ups no entendiste ");
    Console.WriteLine("La excepcion es:" + ex.Message);
}

long number1, number2, suma, resta, prod;
Console.WriteLine($"Ingrese el primer digito  ejem 2345");
number1 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine($"Ingrese el segundo digito ejem 1954");
number2 = Convert.ToInt64(Console.ReadLine());
suma = (long)(number1 + number2);
resta = (long)(number1 - number2);
prod = (long)(number1 * number2);
Console.WriteLine($"El resultado de la suma es:{suma}");
Console.WriteLine($"El resultado de la resta es:{resta}");
Console.WriteLine($"El producto de los numeros digitados es:{prod}");

