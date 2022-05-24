---
-api-id: M:Windows.Networking.NetworkOperators.MobileBroadbandModem.GetIsPassthroughEnabledAsync(System.Int32)
-api-type: winrt method
---

# Windows.Networking.NetworkOperators.MobileBroadbandModem.GetIsPassthroughEnabledAsync(System.Int32)

<!--
public Windows.Foundation.IAsyncOperation<bool> GetIsPassthroughEnabledAsync (int slotindex);
-->


## -description

Asynchronously retrieves a value indicating whether passthrough mode is enabled (for either the active or inactive slot, for Dual Sim Single Active devices).

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

## -parameters

### -param slotindex

The 0-based slot index (slot number) to query about.

## -returns

An asynchronous object which, when it completes, contains a value of `true` if passthrough mode is enabled; otherwise, `false`.

## -remarks

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe
