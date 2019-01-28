---
-api-id: T:Windows.Devices.Lights.LampPurposes
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum LampPurposes : uint 
-->

# Windows.Devices.Lights.LampPurposes

## -description
Purpose/s of a lamp.

## -enum-fields
### -field Undefined:0
No Purposes defined for this lamp.

### -field Control:1
Control Lamp (e.g. button/key/slider)

### -field Accent:2
Accent Lamp that doesn't interact with the user (e.g. case fan LED, illuminated side panels on a keyboard).

### -field Branding:4
Device branding (e.g. manufacturer logo).

### -field Status:8
Status lamp (e.g. unread email, CPU temperature).

### -field Illumination:16
Illuminates an object that is outside of the LampArray (e.g. stage spotlight, car headlights, camera flash).

### -field Presentation:32
A lamp the user directly looks at (e.g. within an artwork or costume).

## -remarks
It is likely this list will expand in the future, so avoid placing error checks that validate a Purpose is within the current bounds.  Preferred approach is to compare against the subset of Purposes the application supports.

## -see-also

## -examples
