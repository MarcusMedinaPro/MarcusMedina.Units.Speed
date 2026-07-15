namespace MarcusMedina.Units.Speed.Scientific;

/// <summary>
/// Vetenskapliga hastighetenheter — ljusets hastighet, Mach och ljud.
/// <code>
/// 1.Mach().ToKilometersPerHour()         // ≈ 1234.8
/// 1.SpeedOfLight().ToKilometersPerSecond() // 299 792
/// </code>
/// </summary>
public static class ScientificSpeedExtensions
{
    /// <summary>Mach 1 vid 20°C, 1 atm = 343 m/s</summary>
    public static Speed Mach(this int v) => new(v * 343.0);
    public static Speed Mach(this double v) => new(v * 343.0);
    /// <summary>Ljusets hastighet c = 299 792 458 m/s (exakt)</summary>
    public static Speed SpeedOfLight(this int v) => new(v * 299_792_458.0);
    public static Speed SpeedOfLight(this double v) => new(v * 299_792_458.0);
    /// <summary>Ljudets hastighet i vatten vid 25°C ≈ 1 481 m/s</summary>
    public static Speed SpeedOfSoundInWater(this int v) => new(v * 1_481.0);
    public static Speed SpeedOfSoundInWater(this double v) => new(v * 1_481.0);

    public static double ToMach(this Speed s) => s.MetersPerSecond / 343.0;
    public static double ToSpeedOfLight(this Speed s) => s.MetersPerSecond / 299_792_458.0;
    public static double ToSpeedOfSoundInWater(this Speed s) => s.MetersPerSecond / 1_481.0;
}
