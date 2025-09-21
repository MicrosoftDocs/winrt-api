---
-api-id: M:Windows.Devices.Radios.Radio.RequestAccessAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Radios.RadioAccessStatus> RequestAccessAsync()
-->

# Windows.Devices.Radios.Radio.RequestAccessAsync

## -description
An asynchronous method that retrieves a value indicating what access the current user has to the radio represented
by this object. In circumstances where user permission is required to access the radio, this method prompts the
user for permission. Consequently, always call this method on the UI thread.

## -returns
An asynchronous status retrieval operation. On successful completion, contains an enumeration value describing the
current user's access to this radio.

## -remarks
Call this method before attempting to enumerate or change radio states. A typical sequence is:
1. Request access (once per session or when status might have changed).
2. Enumerate radios using [GetRadiosAsync](radio_getradiosasync_548754145.md) or device enumeration with
   [GetDeviceSelector](radio_getdeviceselector_838466080.md).
3. Attach a [StateChanged](radio_statechanged.md) handler to each radio you display.
4. Invoke [SetStateAsync](radio_setstateasync_1524539262.md) only after access is granted.

An access value other than Allowed does not imply the absence of radios; it only indicates control is restricted.

## -examples

## -see-also
