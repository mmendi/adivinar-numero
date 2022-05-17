int introducido;
int restantes;

Console.WriteLine("Adivinar el número secreto del 1 al 20");

// Generar aleatorio
int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);

// Intentos restantes
restantes = 3;

// Repetir
do
{
    // Avisa la cantidad de intentos
    Console.WriteLine($"Intentos restantes {restantes} ");

    // Pedir número al usuario
    Console.Write("Dime un número: ");
    introducido = Convert.ToInt32(Console.ReadLine());

    // Si numero > numeroSecreto, "Es muy grande"
    if (introducido > numeroSecreto)
    {
        Console.WriteLine("Es muy grande");
    }
    // Si numero < numeroSecreto, "Es muy chico"
    if (introducido < numeroSecreto)
    {
        Console.WriteLine("Es muy chico");
    }

    // restantes = restantes - 1
    restantes--;

    // Condición de salida, Hasta que numero = aleatorio o restantes = 0

} 
while ((introducido != numeroSecreto) && (restantes > 0));

// Si numero = numeroSecreto; Escribir "Felicitaciones, has adivinado el número secreto que era:  [numeroSecreto] "

if (introducido == numeroSecreto)
{
    Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era:  {numeroSecreto} ");
}
// Sino, Escribir "El número aleatorio es: " + numeroSecreto
else
{
    Console.WriteLine("El número aleatorio es: " + numeroSecreto);
}