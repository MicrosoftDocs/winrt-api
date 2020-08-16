---
-api-id: M:Windows.Devices.Bluetooth.BluetoothAdapter.GetRadioAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<Radio> BluetoothAdapter.GetRadioAsync()
-->

# Windows.Devices.Bluetooth.BluetoothAdapter.GetRadioAsync


## -description

Gets the radio represented by this Bluetooth adapter.

## -returns

Returns an asynchronous operation that completes with the Radio.

## -remarks

When called from a UWP app, there is no architecture requirement. This method will work on the native architecture, as well as x86 architecture on x64 or ARM64 architectures.

When this method is called from a desktop application (Win32), it will retrieve radio instances only when the application is natively compiled for the target architecture (in other words, when the application matches the computer architecture; so an x86 application running on an x64 architecture computer won't see any radio instances).

## -see-also

## -examples

## -capabilities

bluetooth

