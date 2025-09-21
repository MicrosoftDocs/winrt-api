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
Retrieves a collection of [Windows.Devices.Radios.Radio](radio.md) objects representing the radios present at the time
the call is made.

## -returns
When complete, returns a list of [Windows.Devices.Radios.Radio](radio.md) objects describing the radios present at the
time of the call.

## -remarks
Platform notes:
* **Xbox:** Not supported for UWP apps. Enumeration may return no radios, and state control APIs are unavailable.

General guidance:
* Each call returns a fresh snapshot; radios added or removed since the previous call appear or disappear in the new
  result set.
* Handle an empty result set gracefully; do not assume an error. Verify that required capabilities are declared before
  retrying.
* Re-enumerate after a device add or remove if you maintain a cached list.

Architecture considerations:
* UWP apps: Works for any app architecture (x86, x64, ARM64).
* Desktop (Win32) apps: Radios are returned only when the process architecture matches the OS (for example, x64 on
  x64, ARM64 on ARM64). An x86 desktop process on an x64 or ARM64 system typically returns no radios.

## -examples

## -see-also
