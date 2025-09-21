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
A static, asynchronous method that retrieves a collection of [Windows.Devices.Radios.Radio](radio.md) objects representing the radios present when the call is made.

## -returns
An asynchronous retrieval operation. When the operation is complete, contains a list of [Windows.Devices.Radios.Radio](radio.md) objects describing the radios present at the time of the call.

## -remarks
Each call returns a fresh snapshot. Radios that have been added or removed since the previous call are reflected in the new result set.

When called from a UWP app, there is no architecture requirement. This method will work on the native architecture, as well as x86 architecture on x64 or ARM64 architectures.

When this method is called from a desktop application (Win32), it will retrieve radio instances only when the application is natively compiled for the target architecture (for example, an x86 application running on an x64 computer will not obtain radio instances).

## -examples

## -see-also
