string condicion = "";
bool primeraVez = true;
do
{
    float TemperaturaCelsius = WeatherForecast();
    if (primeraVez)
    {
        string PronosticoCincoDias = ConocerPronostico();
        if (PronosticoCincoDias == "si")
        {
            MostrarTemperaturas(TemperaturaCelsius);
            condicion = "si";
        }
        else
        {
            condicion = "no";
        }
        primeraVez = false;
    }
    else
    {
        MostrarTemperaturas(TemperaturaCelsius);
    }
    condicion = ConocerPronostico();
} while (condicion == "si");

static float WeatherForecast()
{
    Console.WriteLine("introduzca por pantalla la temperatura actual en grados celsius");

    float TemperaturaCelsius = float.Parse(Console.ReadLine());

    if (0 >= TemperaturaCelsius)
    {
        Console.WriteLine("Hace mucho frío afuera, asegúrate de abrigarte bien.");
    }
    else if (TemperaturaCelsius > 0 && 20 > TemperaturaCelsius)
    {
        Console.WriteLine("El clima está fresco, una chaqueta ligera sería perfecta.");
    }
    else
    {
        Console.WriteLine("Hace calor afuera, no necesitas una chaqueta.");
    }
    return TemperaturaCelsius;
}
static string ConocerPronostico()
{
    Console.WriteLine("Desea conocer el pronóstico para los próximos cinco días (si/no).");

    string ConocerPronostico = Console.ReadLine();
    return ConocerPronostico;
}
static void MostrarTemperaturas(float TemperaturaCelsius)
{
    Console.WriteLine("Día 1: " + (TemperaturaCelsius + 3) + "°C, parcialmente nublado.\r\nDía 2: " + (TemperaturaCelsius + 1) + "°C, soleado.\r\nDía 3: " + (TemperaturaCelsius + 2) + "°C, lluvias ligeras.\r\nDía 4: " + (TemperaturaCelsius + 1) + "°C, nublado.\r\nDía 5: " + (TemperaturaCelsius + 3) + "°C, soleado con algunas nubes.");
}

