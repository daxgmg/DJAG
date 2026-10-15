namespace DJAG.Cadenas;

public class ManipuladorCadenas
{
    public string Invertir(string texto) =>
        new string(texto.Reverse().ToArray());

    public bool EsPalindromo(string texto)
    {
        var limpio = new string(texto.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        return limpio == new string(limpio.Reverse().ToArray());
    }

    public int ContarVocales(string texto) =>
        texto.Count(c => "aeiouáéíóúAEIOUÁÉÍÓÚ".Contains(c));

    public string AMayusculas(string texto) => texto.ToUpper();
}