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
    extension(int v)
    {
        /// <summary>1 in/s = 0.0254 m/s</summary>
        public Speed InchesPerSecond() => new(v * 0.0254);
        /// <summary>1 ft/s = 0.3048 m/s</summary>
        public Speed FeetPerSecond() => new(v * 0.3048);
        /// <summary>1 mph = 0.44704 m/s</summary>
        public Speed MilesPerHour() => new(v * 0.44704);
        /// <summary>1 mi/s = 1 609.344 m/s</summary>
        public Speed MilesPerSecond() => new(v * 1_609.344);
    }

    extension(double v)
    {
        public Speed InchesPerSecond() => new(v * 0.0254);
        public Speed FeetPerSecond() => new(v * 0.3048);
        public Speed MilesPerHour() => new(v * 0.44704);
        public Speed MilesPerSecond() => new(v * 1_609.344);
    }

    extension(Speed s)
    {
        public double ToInchesPerSecond() => s.MetersPerSecond / 0.0254;
        public double ToFeetPerSecond() => s.MetersPerSecond / 0.3048;
        public double ToMilesPerHour() => s.MetersPerSecond / 0.44704;
        public double ToMilesPerSecond() => s.MetersPerSecond / 1_609.344;
    }
}
