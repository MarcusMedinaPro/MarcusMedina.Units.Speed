namespace MarcusMedina.Units.Speed.US;

/// <summary>
/// Amerikanska hastighetenheter.
/// <code>
/// 60.MilesPerHour().ToKilometersPerHour()  // ≈ 96.56
/// 1.MilesPerHour().ToMetersPerSecond()     // ≈ 0.447
/// </code>
/// </summary>
public static class USSpeedExtensions
{
    /// <summary>1 in/s = 0.0254 m/s</summary>
    public static Speed InchesPerSecond(this int v) => new(v * 0.0254);
    public static Speed InchesPerSecond(this double v) => new(v * 0.0254);
    /// <summary>1 ft/s = 0.3048 m/s</summary>
    public static Speed FeetPerSecond(this int v) => new(v * 0.3048);
    public static Speed FeetPerSecond(this double v) => new(v * 0.3048);
    /// <summary>1 mph = 0.44704 m/s</summary>
    public static Speed MilesPerHour(this int v) => new(v * 0.44704);
    public static Speed MilesPerHour(this double v) => new(v * 0.44704);
    /// <summary>1 mi/s = 1 609.344 m/s</summary>
    public static Speed MilesPerSecond(this int v) => new(v * 1_609.344);
    public static Speed MilesPerSecond(this double v) => new(v * 1_609.344);

    public static double ToInchesPerSecond(this Speed s) => s.MetersPerSecond / 0.0254;
    public static double ToFeetPerSecond(this Speed s) => s.MetersPerSecond / 0.3048;
    public static double ToMilesPerHour(this Speed s) => s.MetersPerSecond / 0.44704;
    public static double ToMilesPerSecond(this Speed s) => s.MetersPerSecond / 1_609.344;
}
