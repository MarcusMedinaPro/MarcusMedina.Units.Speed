# MarcusMedina.Units.Speed

[![NuGet](https://img.shields.io/nuget/v/MarcusMedina.Units.Speed.svg?style=for-the-badge&logo=nuget)](https://www.nuget.org/packages/MarcusMedina.Units.Speed/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/MarcusMedina.Units.Speed.svg?style=for-the-badge&logo=nuget)](https://www.nuget.org/packages/MarcusMedina.Units.Speed/)
[![C#](https://img.shields.io/badge/C%23-14.0-239120?style=for-the-badge&logo=csharp&logoColor=white)](#)
[![.NET](https://img.shields.io/badge/.NET-10.0+-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=for-the-badge)](https://opensource.org/licenses/MIT)
[![Open Source](https://raw.githubusercontent.com/MarcusMedinaPro/MarcusMedina.Units.Speed/main/assets/open-source.svg)](https://opensource.org)
[![Build](https://img.shields.io/github/actions/workflow/status/MarcusMedinaPro/MarcusMedina.Units.Speed/release.yml?branch=main&label=Build&style=for-the-badge&logo=github)](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Speed/actions)
[![Signed](https://img.shields.io/badge/Signed-Sigstore-green?style=for-the-badge&logo=linux)](https://docs.sigstore.dev)
[![Wiki](https://img.shields.io/badge/docs-wiki-blue?style=for-the-badge&logo=github)](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Speed/wiki)

**Fluent speed unit conversion for .NET 10+** — metric, US customary, nautical, and scientific units.

Convert between m/s, km/h, mph, knots, Mach and even the speed of light with a strongly-typed `Speed` struct — no more guessing which raw `double` means what.

> This one comes with a very specific, very embarrassing memory attached. Back in upper-secondary school, working through a problem involving a truck's weight, speed, road surface, and wind resistance, I somehow — through some mysterious chain of unit errors — calculated that the truck was travelling at 5 times the speed of light. My teacher was not impressed. Years later, teaching my own students, I still had flashbacks to that exact lesson, to the teacher telling the class about "someone" who'd once gotten a truck up to 5x lightspeed. So I finally sat down and coded speed conversions properly, if only to explain it to myself, decades late.
>
> In this case, I wanted each unit conversion to be broken into the same small, obvious steps — precisely the steps that would have stopped that truck from ever breaking causality.

---

## Features

- ✅ **Metric** — mm/s, cm/s, m/s, km/h, km/s
- ✅ **US customary** — in/s, ft/s, mph, mi/s
- ✅ **Nautical** — knots
- ✅ **Scientific** — Mach, speed of light, speed of sound in water
- ✅ **Strongly typed** — `Speed` struct instead of a raw `double`, so units can't be mixed up by accident
- ✅ **Fluent API** — `120.KilometersPerHour().ToMilesPerHour()`
- ✅ **Comparable & arithmetic** — `+`, `-`, `*`, `/`, and full comparison operators
- ✅ **Zero dependencies** — pure .NET, no external packages

---

## Installation

```bash
dotnet add package MarcusMedina.Units.Speed
```

**Requirements:** .NET 10.0+, C# 14.0+

---

## Quick Start

```csharp
using MarcusMedina.Units.Speed.Metric;
using MarcusMedina.Units.Speed.Nautical;
using MarcusMedina.Units.Speed.Scientific;

// Create a Speed from any supported unit
Speed car   = 120.KilometersPerHour();
Speed ship  = 15.Knots();
Speed jet   = 1.2.Mach();

// Convert to whatever unit you need
double mph   = car.ToMilesPerHour();     // ≈ 74.6
double ms    = ship.ToMetersPerSecond(); // ≈ 7.72

// Arithmetic works directly on Speed values
Speed total = car + 10.KilometersPerHour();

// Comparisons
bool faster = jet > car;
```

---

## API Overview

| Namespace | Unit family |
|-----------|-------------|
| `MarcusMedina.Units.Speed.Metric` | mm/s, cm/s, m/s, km/h, km/s |
| `MarcusMedina.Units.Speed.US` | in/s, ft/s, mph, mi/s |
| `MarcusMedina.Units.Speed.Nautical` | knots |
| `MarcusMedina.Units.Speed.Scientific` | Mach, speed of light, speed of sound in water |

Every unit exposes a creation extension (`1.Knots()`) and a conversion extension
(`speed.ToKnots()`). The `Speed` struct itself always stores the value in meters per second,
so mixing units in the same expression is always safe.

---

## Testing

```bash
cd csharp
dotnet test --configuration Release
```

Tests: **24 passed** — covering all unit families, arithmetic operators, and edge cases.

---

## License

MIT — see [LICENSE](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Speed/blob/main/LICENSE) for details.

---

## Built with Human + AI Collaboration

This library was written by **Marcus Medina** together with **Claude Code** (Anthropic) — not through "vibe coding" where you just describe and accept, but through genuine collaboration: planning together, reviewing each other's decisions, pushing back when something felt wrong, and iterating until the result felt right.

The goal was always to write code worth reading and code worth using — the kind a student can open, understand, and learn from, and the kind any programmer can drop into real, professional work without wanting to rewrite it from scratch. AI was a partner in that process, not a shortcut around it.

If you're curious about this way of working, the source code and git history are open. Every decision has a reason behind it.

## Made for Curious Minds

This library was built with students in mind — not as a black box to copy and paste, but as a real-world example of how clean, purposeful code is written and shared.

Whether you're discovering C# for the first time, need a reliable helper for your school project, or are simply trying to fall in love with writing code — you're exactly who this was made for.

The source is open. Read it, fork it, break it, improve it. That's the whole point.

And if this library saved you an afternoon, or made something click that didn't before — that's everything.

*Non-students are equally welcome. Good code doesn't care about your diploma.*

⭐ If this helped you, consider starring the project on GitHub — it helps other students find it too.

💬 Have an idea, a feature request, or just want to say hi? Open an issue on GitHub — I'd love to hear from you.

## Package Integrity

All releases are signed with [cosign](https://docs.sigstore.dev) (Sigstore keyless signing).

To verify a downloaded package, download both the `.nupkg` and its `.sigstore.json` bundle from the [GitHub Release](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Speed/releases), then run:

```bash
cosign verify-blob <package.nupkg> \
  --bundle <package.nupkg.sigstore.json> \
  --certificate-identity-regexp "https://github.com/MarcusMedinaPro/.*/release.yml" \
  --certificate-oidc-issuer https://token.actions.githubusercontent.com
```

Expected output: `Verified OK`

## Related Projects

- [MarcusMedina.Units.Area](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Area) — Fluent area unit conversion
- [MarcusMedina.Units.Distance](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Distance) — Fluent distance unit conversion
- [MarcusMedina.Units.Weight](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Weight) — Fluent weight unit conversion
- [MarcusMedina.Units.Math](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Math) — Unit-aware mathematical operations
- [MarcusMedina.Maths.Algebra](https://github.com/MarcusMedinaPro/MarcusMedina.Maths.Algebra) — Algebraic expressions and symbolic math
