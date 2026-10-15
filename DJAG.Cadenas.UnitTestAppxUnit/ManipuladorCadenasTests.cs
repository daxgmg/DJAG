using DJAG.Cadenas;

namespace DJAG.Cadenas.UnitTestAppxUnit;

public class ManipuladorCadenasTests
{
    private readonly ManipuladorCadenas _m = new();

    [Theory]
    [InlineData("hola", "aloh")]
    [InlineData("", "")]
    public void Invertir_RetornaCadenaInvertida(string entrada, string esperado)
        => Assert.Equal(esperado, _m.Invertir(entrada));

    [Theory]
    [InlineData("Anita lava la tina", true)]
    [InlineData("Hola", false)]
    public void EsPalindromo_DetectaCorrectamente(string entrada, bool esperado)
        => Assert.Equal(esperado, _m.EsPalindromo(entrada));

    [Fact]
    public void ContarVocales_CuentaCorrectamente()
        => Assert.Equal(5, _m.ContarVocales("murciélago"));

    [Fact]
    public void AMayusculas_ConvierteTexto()
        => Assert.Equal("HOLA", _m.AMayusculas("hola"));
}