---
-api-id: M:Windows.Devices.Radios.Radio.GetRadiosAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Devices.Radios.Radio>> GetRadiosAsync()
-->

# Windows.Devices.Radios.Radio.GetRadiosAsync

## -description
A static, asynchronous method that retrieves a collection of [Windows.Devices.Radios.Radio](radio.md) objects
representing the radios present when the call is made.

## -returns
An asynchronous retrieval operation. When the operation is complete, contains a list of
[Windows.Devices.Radios.Radio](radio.md) objects describing the radios present at the time of the call.

## -remarks
General guidance:
* Each call returns a fresh snapshot; radios added or removed since the previous call appear/disappear in the new
	result set.
* Handle an empty result set gracefully—do not assume an error; validate that required capabilities are declared
	before retrying.
* Re-enumerate after device add/remove if you maintain a cached list.

Architecture considerations:
* UWP apps: Works for any app architecture (x86, x64, ARM64).
* Desktop (Win32) apps: Radios are returned only when the process architecture matches the OS (for example x64 on x64,
  ARM64 on ARM64). An x86 desktop process on an x64 or ARM64 system typically returns no radios.

## -examples

## -see-also
