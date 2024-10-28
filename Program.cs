string minhaString = "Olá, mundo! Este é um texto de teste com a letra a.";
AnalisadorDeString.ContarAEmString(minhaString);

public class AnalisadorDeString
{
    public static void ContarAEmString(string entrada)
    {
        int contador = 0;
        foreach (char c in entrada)
        {
            if (c == 'a' || c == 'A' || c == 'á')
            {
                contador++;
            }
        }

        Console.WriteLine($"A letra 'a' (incluindo acentuada) aparece {contador} vezes na string: '{entrada}'");
    }
}