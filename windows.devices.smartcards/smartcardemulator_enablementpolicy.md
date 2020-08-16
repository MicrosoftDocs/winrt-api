---
-api-id: P:Windows.Devices.SmartCards.SmartCardEmulator.EnablementPolicy
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.SmartCards.SmartCardEmulatorEnablementPolicy EnablementPolicy { get; }
-->

# Windows.Devices.SmartCards.SmartCardEmulator.EnablementPolicy

## -description
Gets the current card emulation policy set by the user.

## -property-value
The current card emulation policy set by the user through the phone settings. This property is read-only to the app; you should tell the user to change the card emulation policy in the settings on his or her phone, if their mobile operator allows it.

## -remarks
You can launch the URI `ms-settings-nfctransactions:` from within your app to take the user to the NFC control panel for transactions so they can change the enablement policy.

## -examples

## -see-also
[Create an NFC Smart Card app (applies to Windows 10 Mobile only)](/windows/uwp/devices-sensors/host-card-emulation)
