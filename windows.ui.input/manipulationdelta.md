---
-api-id: T:Windows.UI.Input.ManipulationDelta
-api-type: winrt struct
---

<!-- Structure syntax.
public struct ManipulationDelta 
-->

# ManipulationDelta

## -description
Contains the accumulated transformations for the current manipulation.

## -struct-fields

### -field Translation
The change in x-y screen coordinates, in device-independent pixel (DIP).
    

### -field Scale
The change in distance between touch contacts, as a percentage. For example, if the distance between two contacts changes from 100 device-independent pixel (DIP) to 200 device-independent pixel (DIP) during a manipulation, the value of **Scale** would be 1.0.
    

### -field Rotation
The change in angle of rotation, in degrees.
    

### -field Expansion
The change in distance between touch contacts, as device-independent pixel (DIP). For example, if the distance between two contacts changes from 100 device-independent pixel (DIP) to 200 device-independent pixel (DIP) during a manipulation, the value of **Expansion** would be 100.0.
    

## -remarks

## -examples

## -see-also
[ManipulationCompletedEventArgs.Cumulative | manipulationCompletedEventArgs.cumulative Property
](manipulationcompletedeventargs_cumulative.md), [ManipulationVelocities](manipulationvelocities.md)