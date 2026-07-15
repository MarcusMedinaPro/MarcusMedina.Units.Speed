namespace MarcusMedina.Units.Speed.Nautical;

/// <summary>
/// Nautiska hastighetenheter.
/// <code>
/// 20.Knots().ToKilometersPerHour()  // ≈ 37.04
/// </code>
/// </summary>
public static class NauticalSpeedExtensions
{
    /// <summary>1 knop = 1 852/3 600 m/s ≈ 0.514444 m/s</summary>
    public static Speed Knots(this int v) => new(v * 1_852.0 / 3_600.0);
    public static Speed Knots(this double v) => new(v * 1_852.0 / 3_600.0);

    public static double ToKnots(this Speed s) => s.MetersPerSecond / (1_852.0 / 3_600.0);
}
