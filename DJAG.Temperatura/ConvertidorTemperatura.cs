namespace DJAG.Temperatura;

public class ConvertidorTemperatura
{
    public double CelsiusAFahrenheit(double c) => c * 9 / 5 + 32;
    public double FahrenheitACelsius(double f) => (f - 32) * 5 / 9;
    public double CelsiusAKelvin(double c) => c + 273.15;
    public double KelvinACelsius(double k) => k - 273.15;
}