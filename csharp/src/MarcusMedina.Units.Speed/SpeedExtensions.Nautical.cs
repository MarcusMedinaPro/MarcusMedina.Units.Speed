namespace MarcusMedina.Units.Speed.Nautical;

/// <summary>
/// Nautiska hastighetenheter.
/// <code>
/// 20.Knots().ToKilometersPerHour()  // ≈ 37.04
/// </code>
/// </summary>
public static class NauticalSpeedExtensions
{
    extension(int v)
    {
        /// <summary>1 knop = 1 852/3 600 m/s ≈ 0.514444 m/s</summary>
        public Speed Knots() => new(v * 1_852.0 / 3_600.0);
    }

    extension(double v)
    {
        public Speed Knots() => new(v * 1_852.0 / 3_600.0);
    }

    extension(Speed s)
    {
        public double ToKnots() => s.MetersPerSecond / (1_852.0 / 3_600.0);
    }
}
