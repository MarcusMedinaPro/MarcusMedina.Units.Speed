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
    extension(int v)
    {
        /// <summary>Mach 1 vid 20°C, 1 atm = 343 m/s</summary>
        public Speed Mach() => new(v * 343.0);
        /// <summary>Ljusets hastighet c = 299 792 458 m/s (exakt)</summary>
        public Speed SpeedOfLight() => new(v * 299_792_458.0);
        /// <summary>Ljudets hastighet i vatten vid 25°C ≈ 1 481 m/s</summary>
        public Speed SpeedOfSoundInWater() => new(v * 1_481.0);
    }

    extension(double v)
    {
        public Speed Mach() => new(v * 343.0);
        public Speed SpeedOfLight() => new(v * 299_792_458.0);
        public Speed SpeedOfSoundInWater() => new(v * 1_481.0);
    }

    extension(Speed s)
    {
        public double ToMach() => s.MetersPerSecond / 343.0;
        public double ToSpeedOfLight() => s.MetersPerSecond / 299_792_458.0;
        public double ToSpeedOfSoundInWater() => s.MetersPerSecond / 1_481.0;
    }
}
