using Logica;

Ascensor ascensor = new Ascensor();
ascensor.pisoNuevoAsignado += AscensorHandler;
Console.WriteLine("Ingrese un valor (1 = Llamar ascensor, 2 = Definir Piso): ");
int accion = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el piso deseado: ");
int piso = int.Parse(Console.ReadLine());
Console.Clear();
if (accion == 1)
{
    ascensor.LlamarAscensor(piso);
}
else
{
    ascensor.DefinirPiso(piso);
}

static void AscensorHandler(object? sender, AscensorEventArgs e)
{
    Console.WriteLine(e.Piso);
}