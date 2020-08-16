---
-api-id: T:Windows.Foundation.Numerics.Quaternion
-api-type: winrt struct
---

<!-- Structure syntax.
public struct Quaternion 
-->

# Quaternion

## -description
Describes a quaternion, which is an abstract representation of an orientation in space that is based on complex numbers.

In C++, **Quaternion** is projected as the [quaternion structure](/windows/win32/numerics_h/quaternion-structure).

## -struct-fields

### -field X
The *x* component of the quaternion, which is the coefficient of the **i** unit vector in the quaternion.
    

### -field Y
The *y* component of the quaternion, which is the coefficient of the **j** unit vector in the quaternion.
    

### -field Z
The *z* component of the quaternion, which is the coefficient of the **k** unit vector in the quaternion.
    

### -field W
The *w* component of the quaternion, which is the real number part of the quaternion.
    

## -remarks
The identity quaternion is (0, 0, 0, 1), where the quaternion values are listed in the order (*x*, *y*, *z*, *w*).

These quaternion values do not directly indicate an angle of rotation and an axis.

For more information about quaternions, see [Quaternion]( https://en.wikipedia.org/wiki/Quaternion), [Quaternions and spatial rotation](https://go.microsoft.com/fwlink/p/?LinkId=730456), and [Introducing the Quaternions](https://go.microsoft.com/fwlink/p/?LinkId=730457).

## -examples

## -see-also
[SpatialLocation.Orientation](../windows.perception.spatial/spatiallocation_orientation.md)

[quaternion structure](/windows/win32/numerics_h/quaternion-structure)
