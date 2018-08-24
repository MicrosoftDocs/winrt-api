---
-api-id: T:Windows.Devices.Radios.Radio
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class Radio : Windows.Devices.Radios.IRadio
-->

# Windows.Devices.Radios.Radio

## -description
Represents a radio device on the system.

## -remarks
Your code uses static members of this class like [GetRadiosAsync](radio_getradiosasync_548754145.md), [GetDeviceSelector](radio_getdeviceselector_838466080.md), and [FromIdAsync](radio_fromidasync_1322863552.md) to query for radios and to retrieve instantiated Radio objects representing particular radios on the device.

Note that your code should call [RequestAccessAsync](radio_requestaccessasync_380675631.md) at least once, from the UI thread, before trying to call [SetStateAsync](radio_setstateasync_1524539262.md). This is because in some regions, with some user settings choices, attempting to change radio state requires user permission. In this situation, calling [RequestAccessAsync](radio_requestaccessasync_380675631.md) shows the user a prompt asking if they want to allow your app to have permission to control the radio. If your app is running on a device that requires user permission and your code hasn't requested and received permission, then [SetStateAsync](radio_setstateasync_1524539262.md) will fail for lack of user permission.

## -examples

## -see-also
