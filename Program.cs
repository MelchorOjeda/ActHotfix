using ConsoleAppHotfix;

Personaje personaje = new Personaje
{
    Nombre = "Arthas",
    Clase = "Guerrero",
    Nivel = 10,
    Vida = 100,
    Mana = 50
};

Console.WriteLine($"Nombre: {personaje.Nombre}");
Console.WriteLine($"Clase: {personaje.Clase}");
Console.WriteLine($"Nivel: {personaje.Nivel}");
Console.WriteLine($"Vida: {personaje.Vida}");
Console.WriteLine($"Mana: {personaje.Mana}");
