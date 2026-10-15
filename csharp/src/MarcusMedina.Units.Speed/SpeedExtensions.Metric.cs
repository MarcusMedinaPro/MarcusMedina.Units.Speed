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
    extension(int v)
    {
        public Speed MillimetersPerSecond() => new(v * 0.001);
        public Speed CentimetersPerSecond() => new(v * 0.01);
        public Speed MetersPerSecond() => new(v);
        /// <summary>1 km/h = 1/3.6 m/s</summary>
        public Speed KilometersPerHour() => new(v / 3.6);
        public Speed KilometersPerSecond() => new(v * 1_000.0);
    }

    extension(double v)
    {
        public Speed MillimetersPerSecond() => new(v * 0.001);
        public Speed CentimetersPerSecond() => new(v * 0.01);
        public Speed MetersPerSecond() => new(v);
        public Speed KilometersPerHour() => new(v / 3.6);
        public Speed KilometersPerSecond() => new(v * 1_000.0);
    }

    extension(Speed s)
    {
        public double ToMillimetersPerSecond() => s.MetersPerSecond / 0.001;
        public double ToCentimetersPerSecond() => s.MetersPerSecond / 0.01;
        public double ToMetersPerSecond() => s.MetersPerSecond;
        public double ToKilometersPerHour() => s.MetersPerSecond * 3.6;
        public double ToKilometersPerSecond() => s.MetersPerSecond / 1_000.0;
    }
}
