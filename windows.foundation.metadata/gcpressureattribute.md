---
-api-id: T:Windows.Foundation.Metadata.GCPressureAttribute
-api-type: winrt class
---

<!-- Class syntax.
public class GCPressureAttribute : System.Attribute
-->

# Windows.Foundation.Metadata.GCPressureAttribute

## -description
Microsoft internal use only.

## -remarks
Enables Windows Runtime APIs that use significant amounts of native memory to signal their memory footprint to garbage-collected (GC) environments, like JavaScript and .NET Framework. Applying the [GCPressureAttribute](gcpressureattribute.md) enables efficient scheduling of garbage collection sweeps.

GC environments explicitly ignore the attribute on Windows Runtime objects that are outside of the Windows namespace.

## -examples

## -see-also
[GCPressureAmount](gcpressureamount.md)