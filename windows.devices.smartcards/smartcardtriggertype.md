---
-api-id: T:Windows.Devices.SmartCards.SmartCardTriggerType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.SmartCards.SmartCardTriggerType : int
-->

# SmartCardTriggerType

## -description
Represents the valid smart card trigger types.

## -enum-fields
### -field EmulatorTransaction:0
A transaction event.

### -field EmulatorNearFieldEntry:1
A field entry event.

> [!NOTE]
> This event is not supported for Universal Windows Platform (UWP) apps in Windows 10.

### -field EmulatorNearFieldExit:2
A field exit event.

> [!NOTE]
> This event is not supported for Universal Windows Platform (UWP) apps in Windows 10.

### -field EmulatorHostApplicationActivated:3
A host application activated event.

### -field EmulatorAppletIdGroupRegistrationChanged:4
An applet ID group registration changed event.

### -field ReaderCardAdded:5
A reader card was added event.


## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | ReaderCardAdded |

## -examples

## -see-also
[Create an NFC Smart Card app (applies to Windows 10 Mobile only)](/windows/uwp/devices-sensors/host-card-emulation)
