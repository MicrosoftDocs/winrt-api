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
As of Windows10 1703 v15063, this method works ONLY when compiled for x64 target.  This is by design.

## -returns
An asynchronous retrieval operation. When the operation is complete, contains a list of [Windows.Devices.Radios.Radio](radio.md) objects describing radios that existed at the time the program launched.

## -remarks

## -examples

## -see-also
