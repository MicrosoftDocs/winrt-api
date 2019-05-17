---
-api-id: T:Windows.Devices.Enumeration.EnclosureLocation
-api-type: winrt class
---

<!-- Class syntax.
public class EnclosureLocation : Windows.Devices.Enumeration.IEnclosureLocation, Windows.Devices.Enumeration.IEnclosureLocation2
-->

# Windows.Devices.Enumeration.EnclosureLocation

## -description
Describes the physical location of a device in its enclosure.

## -remarks
The [EnclosureLocation](deviceinformation_enclosurelocation.md) property returns this object.

If the physical location of a device within its enclosure is unknown, the [inDock](enclosurelocation_indock.md) and [inLid](enclosurelocation_inlid.md) properties are false and the [Panel](enclosurelocation_panel.md) property has the value **Unknown**.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | RotationAngleInDegreesClockwise |

## -examples

## -see-also
