---
-api-id: P:Windows.Devices.SmartCards.SmartCardAppletIdGroup.AutomaticEnablement
-api-type: winrt property
---

<!-- Property syntax
public bool AutomaticEnablement { get;  set; }
-->

# Windows.Devices.SmartCards.SmartCardAppletIdGroup.AutomaticEnablement

## -description
Gets or sets a Boolean value indicating if the operating system is permitted to enable this [AppletIdGroup](smartcardappletidgroup.md).

## -property-value
A Boolean value indicating if the operating system is permitted to enable this [AppletIdGroup](smartcardappletidgroup.md).

## -remarks
Set this property to true to allow the OS to enable this [AppletIdGroup](smartcardappletidgroup.md). For example, in the NFC settings panel, a user may select a payment app. If there is only a single payment [AppletIdGroup](smartcardappletidgroup.md), and this property is set to true, the OS will automatically enable the [AppletIdGroup](smartcardappletidgroup.md). If false, the OS will always defer to the application to enable the [AppletIdGroup](smartcardappletidgroup.md). The default value is true.

## -examples

## -see-also
[Create an NFC Smart Card app (applies to Windows 10 Mobile only)](/windows/uwp/devices-sensors/host-card-emulation)
