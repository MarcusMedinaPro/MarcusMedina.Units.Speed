namespace MarcusMedina.Units.Speed.Metric;

/// <summary>
/// Metriska hastighetenheter.
/// <code>
/// 100.KilometersPerHour().ToMetersPerSecond()  // ≈ 27.78
/// 30.MetersPerSecond().ToKilometersPerHour()   // 108
/// </code>
/// </summary>
public static class MetricSpeedExtensions
{
    public static Speed MillimetersPerSecond(this int v) => new(v * 0.001);
    public static Speed MillimetersPerSecond(this double v) => new(v * 0.001);
    public static Speed CentimetersPerSecond(this int v) => new(v * 0.01);
    public static Speed CentimetersPerSecond(this double v) => new(v * 0.01);
    public static Speed MetersPerSecond(this int v) => new(v);
    public static Speed MetersPerSecond(this double v) => new(v);
    /// <summary>1 km/h = 1/3.6 m/s</summary>
    public static Speed KilometersPerHour(this int v) => new(v / 3.6);
    public static Speed KilometersPerHour(this double v) => new(v / 3.6);
    public static Speed KilometersPerSecond(this int v) => new(v * 1_000.0);
    public static Speed KilometersPerSecond(this double v) => new(v * 1_000.0);

    public static double ToMillimetersPerSecond(this Speed s) => s.MetersPerSecond / 0.001;
    public static double ToCentimetersPerSecond(this Speed s) => s.MetersPerSecond / 0.01;
    public static double ToMetersPerSecond(this Speed s) => s.MetersPerSecond;
    public static double ToKilometersPerHour(this Speed s) => s.MetersPerSecond * 3.6;
    public static double ToKilometersPerSecond(this Speed s) => s.MetersPerSecond / 1_000.0;
}
