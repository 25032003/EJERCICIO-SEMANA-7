using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

void adivinar()
{
    const int oportunidades = 4;
    int NumeroCPU, NumeroUsuario;
    byte Intentos, BanderaControl;
    string linea;
    //Generar numeros del 1 al 20 unicamente.
    Random ran = new Random();
    do
    {
        NumeroCPU = Convert.ToInt32(ran.Next(0, 21));
        //Console.WriteLine(NumeroCPU);
    } while (!((NumeroCPU >= 1) & (NumeroCPU <= 20)));

    //Proceso
    Intentos = 1;
    BanderaControl = 0;

    do
    {
        Console.WriteLine("Estoy pensando en un numero, cual sera?");
        linea = Console.ReadLine();
        NumeroUsuario = Convert.ToInt32(linea);
        if (NumeroCPU == NumeroUsuario)
        {
            Console.WriteLine("Adivinaste!!!");
            BanderaControl = 1;
        }
        else
        {
            if ((NumeroUsuario > NumeroCPU))
            {
                Console.WriteLine("El numero que estoy pensando es mayor");
            }
            else
            {
                Console.WriteLine("El numero que estoy pensando es menor");


            }
            Intentos++;
        }

    } while (((Intentos <= oportunidades) & (BanderaControl == 0)));
    if (BanderaControl == 0)
    {
        Console.WriteLine("El numero fue:" + NumeroCPU);
    }


}


void mayor_menor()
{
    int mayor = 0;
    int menor = 10;
    int numero = 0;
    Random random = new Random();

    for (int i = 0; i < 5; i++)
    {
        numero = random.Next(10);
        Console.WriteLine(numero);
        if (numero > mayor)
        {
            mayor = numero;
        }
        if (numero < menor)
        {
            menor = numero;

        }

    }
    Console.WriteLine("El mayor es:" + mayor);
    Console.WriteLine("El menor es:" + menor);

}

void catcher()
{
    int cantidad = 0;
    Console.WriteLine("Ingrese una cantidad");
    try
    {
        cantidad = int.Parse(Console.ReadLine());
        //cantidad = cantidad / 0;
    }
    catch (FormatException fex)
    {
        Console.WriteLine("Ingreso mal el numero" + fex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ingreso bien el numero" + ex.Message);
    }
    if (cantidad > 0)
    {
        Console.WriteLine("Cantidad ingresada =" + cantidad);
    }
}
void ejemploArreglo()
{
    int[] numero = new int[7]; //Definimos y creamos el arreglo
    int suma = 0;
    int elementos = numero.Length;
    numero[0] = 45;
    numero[1] = 50;
    numero[2] = 68;
    numero[3] = 70;
    numero[4] = 86;
    numero[5] = 92;
    numero[6] = 69;


    int segunda = 0;
    int personas = 10;
    String[] nombres = new String[personas];
    int rifa = 0;
    nombres[0] = "Maria";
    nombres[1] = "Juan";
    nombres[2] = "Pedro";
    nombres[3] = "Daniela";
    nombres[4] = "Jose";
    nombres[5] = "Karen";
    nombres[6] = "Luis";
    nombres[7] = "Julio";
    nombres[8] = "Nidia";
    nombres[9] = "Octavio";

    Random ran = new Random();
    rifa = ran.Next(personas);
    segunda = ran.Next(personas);

    Console.WriteLine("\n La primera persona Ganadora es:" + nombres[rifa]);
    Console.WriteLine("\n La segunda persona Ganadora es:" + nombres[segunda]);

    for (int i = 0; i < elementos; i++)
    {

        suma = suma + numero[i];
        Console.WriteLine("Numeros en pos 2=" + numero[i]);
    }
    Console.WriteLine("Sumatoria = " + suma);
    Console.WriteLine("El promedio es = " + suma / elementos);

    Console.WriteLine("El numero mayor es:" + numero.Max());
    Console.WriteLine("El numero menor es:" + numero.Min());

}
ejemploArreglo();
