using System.Globalization;

namespace MarcusMedina.Units.Speed;

/// <summary>
/// Representerar en hastighet med meter per sekund som basenhet.
/// Alla konverteringar sker genom att multiplicera/dividera m/s-värdet.
/// </summary>
public readonly struct Speed : IComparable<Speed>, IEquatable<Speed>
{
    /// <summary>Värdet i meter per sekund (basenhet).</summary>
    public double MetersPerSecond { get; }

    public Speed(double metersPerSecond) { MetersPerSecond = metersPerSecond; }

    public int CompareTo(Speed other) => MetersPerSecond.CompareTo(other.MetersPerSecond);
    public bool Equals(Speed other) => MetersPerSecond.Equals(other.MetersPerSecond);
    public override bool Equals(object? obj) => obj is Speed s && Equals(s);
    public override int GetHashCode() => HashCode.Combine(MetersPerSecond);
    public override string ToString() => $"{MetersPerSecond.ToString("G", CultureInfo.InvariantCulture)} m/s";

    public static bool operator ==(Speed a, Speed b) => a.Equals(b);
    public static bool operator !=(Speed a, Speed b) => !(a == b);
    public static bool operator <(Speed a, Speed b) => a.MetersPerSecond < b.MetersPerSecond;
    public static bool operator >(Speed a, Speed b) => a.MetersPerSecond > b.MetersPerSecond;
    public static bool operator <=(Speed a, Speed b) => a.MetersPerSecond <= b.MetersPerSecond;
    public static bool operator >=(Speed a, Speed b) => a.MetersPerSecond >= b.MetersPerSecond;
    public static Speed operator +(Speed a, Speed b) => new(a.MetersPerSecond + b.MetersPerSecond);
    public static Speed operator -(Speed a, Speed b) => new(a.MetersPerSecond - b.MetersPerSecond);
    public static Speed operator *(Speed s, double factor) => new(s.MetersPerSecond * factor);
    public static Speed operator /(Speed s, double divisor) => new(s.MetersPerSecond / divisor);
    public static double operator /(Speed a, Speed b) => a.MetersPerSecond / b.MetersPerSecond;
}
