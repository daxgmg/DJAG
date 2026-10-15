using DJAG.Temperatura;

namespace DJAG.Temperatura.UnitTestMSTest;

[TestClass]
public class ConvertidorTemperaturaTests
{
    private readonly ConvertidorTemperatura _c = new();

    [TestMethod]
    [DataRow(0, 32)]
    [DataRow(100, 212)]
    [DataRow(-40, -40)]
    public void CelsiusAFahrenheit_ValoresConocidos(double c, double esperado)
        => Assert.AreEqual(esperado, _c.CelsiusAFahrenheit(c), 0.001);

    [TestMethod]
    [DataRow(32, 0)]
    [DataRow(212, 100)]
    public void FahrenheitACelsius_ValoresConocidos(double f, double esperado)
        => Assert.AreEqual(esperado, _c.FahrenheitACelsius(f), 0.001);

    [TestMethod]
    public void CelsiusAKelvin_CeroCelsius()
        => Assert.AreEqual(273.15, _c.CelsiusAKelvin(0), 0.001);

    [TestMethod]
    public void KelvinACelsius_CeroAbsoluto()
        => Assert.AreEqual(-273.15, _c.KelvinACelsius(0), 0.001);
}