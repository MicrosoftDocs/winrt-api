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
An asynchronous method that retrieves a value indicating what access the current user has to the radio represented by this object. In circumstances where user permission is required to access the radio, this method prompts the user for permission. Consequently, always call this method on the UI thread.

## -returns
An asynchronous status retrieval operation. On successful completion, contains an enumeration value describing the current user's access to this radio.

## -remarks

## -examples

## -see-also