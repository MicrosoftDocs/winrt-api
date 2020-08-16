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
A static, asynchronous method that retrieves a collection of [Windows.Devices.Radios.Radio](radio.md) objects representing radio devices which existed on the system at the time the program launched.  Additions or removals of radios are ignored by subsequent calls.

## -returns
An asynchronous retrieval operation. When the operation is complete, contains a list of [Windows.Devices.Radios.Radio](radio.md) objects describing radios that existed at the time the program launched.

## -remarks
When called from a UWP app, there is no architecture requirement. This method will work on the native architecture, as well as x86 architecture on x64 or ARM64 architectures.

When this method is called from a desktop application (Win32), it will retrieve radio instances only when the application is natively compiled for the target architecture (in other words, when the application matches the computer architecture; so an x86 application running on an x64 architecture computer won't see any radio instances).

## -examples

## -see-also
