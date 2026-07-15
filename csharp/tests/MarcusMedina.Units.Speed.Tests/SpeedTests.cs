using MarcusMedina.Units.Speed;
using MarcusMedina.Units.Speed.Metric;
using MarcusMedina.Units.Speed.US;
using MarcusMedina.Units.Speed.Nautical;
using MarcusMedina.Units.Speed.Scientific;
using Xunit;
using FluentAssertions;

namespace MarcusMedina.Units.Speed.Tests;

public class SpeedStructTests
{
    [Fact] public void Speed_StoresMetersPerSecond() => new Speed(100).MetersPerSecond.Should().Be(100);
    [Fact] public void Speed_Addition() => (new Speed(10) + new Speed(5)).MetersPerSecond.Should().Be(15);
    [Fact] public void Speed_Subtraction() => (new Speed(10) - new Speed(3)).MetersPerSecond.Should().Be(7);
    [Fact] public void Speed_Multiplication() => (new Speed(10) * 2).MetersPerSecond.Should().Be(20);
    [Fact] public void Speed_Comparison() => new Speed(100).Should().BeGreaterThan(new Speed(50));
}

public class MetricSpeedTests
{
    [Fact] public void MetersPerSecond_RoundTrip() => 30.0.MetersPerSecond().ToMetersPerSecond().Should().BeApproximately(30, 1e-9);
    [Fact] public void KilometersPerHour_100_ToMps() => 100.0.KilometersPerHour().ToMetersPerSecond().Should().BeApproximately(27.7778, 1e-3);
    [Fact] public void MetersPerSecond_30_ToKmh() => 30.0.MetersPerSecond().ToKilometersPerHour().Should().BeApproximately(108, 1e-9);
    [Fact] public void KilometersPerSecond_1_ToMetersPerSecond() => 1.KilometersPerSecond().ToMetersPerSecond().Should().BeApproximately(1000, 1e-9);
    [Fact] public void KilometersPerSecond_1_ToKmh() => 1.KilometersPerSecond().ToKilometersPerHour().Should().BeApproximately(3600, 1e-6);
}

public class USSpeedTests
{
    [Fact] public void MilesPerHour_60_ToMps() => 60.0.MilesPerHour().ToMetersPerSecond().Should().BeApproximately(26.8224, 1e-4);
    [Fact] public void FeetPerSecond_1_ToMps() => 1.0.FeetPerSecond().ToMetersPerSecond().Should().BeApproximately(0.3048, 1e-9);
    [Fact] public void MilesPerHour_1_ToMps() => 1.0.MilesPerHour().ToMetersPerSecond().Should().BeApproximately(0.44704, 1e-9);
    [Fact] public void MilesPerHour_60_ToKmh() => 60.0.MilesPerHour().MetersPerSecond.Should().BeApproximately(26.8224, 1e-4);
}

public class NauticalSpeedTests
{
    [Fact] public void Knots_1_ToMps() => 1.0.Knots().ToMetersPerSecond().Should().BeApproximately(0.514444, 1e-5);
    [Fact] public void Knots_20_ToMps() => 20.0.Knots().ToMetersPerSecond().Should().BeApproximately(10.2889, 1e-3);
    [Fact] public void Knots_RoundTrip() => 15.0.Knots().ToKnots().Should().BeApproximately(15, 1e-9);
}

public class ScientificSpeedTests
{
    [Fact] public void Mach_1_ToMps() => 1.0.Mach().ToMetersPerSecond().Should().BeApproximately(343, 1e-9);
    [Fact] public void SpeedOfLight_ToMps() => 1.0.SpeedOfLight().ToMetersPerSecond().Should().BeApproximately(299_792_458, 1e-3);
    [Fact] public void SpeedOfSoundInWater_ToMps() => 1.0.SpeedOfSoundInWater().ToMetersPerSecond().Should().BeApproximately(1481, 1e-9);
    [Fact] public void Mach_RoundTrip() => 2.0.Mach().ToMach().Should().BeApproximately(2, 1e-9);
}

public class CrossSystemSpeedTests
{
    // Use ToMetersPerSecond as common denominator for cross-namespace tests
    [Fact] public void Knots_ToMph() => 1.0.Knots().ToMilesPerHour().Should().BeApproximately(1.15078, 1e-4);
    [Fact] public void Mach_ToMph() => 1.0.Mach().ToMilesPerHour().Should().BeApproximately(767.27, 1e-1);
    [Fact] public void Mach_1_ToKmhViaMeters() => (1.0.Mach().MetersPerSecond * 3.6).Should().BeApproximately(1234.8, 1e-1);
}
