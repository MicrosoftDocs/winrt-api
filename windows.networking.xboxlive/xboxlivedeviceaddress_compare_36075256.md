---
-api-id: M:Windows.Networking.XboxLive.XboxLiveDeviceAddress.Compare(Windows.Networking.XboxLive.XboxLiveDeviceAddress)
-api-type: winrt method
---

<!-- Method syntax
public int Compare(Windows.Networking.XboxLive.XboxLiveDeviceAddress otherDeviceAddress)
-->

# Windows.Networking.XboxLive.XboxLiveDeviceAddress.Compare

## -description

Compares another **XboxLiveDeviceAddress** object to the current object, to see whether they represent the same device.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -parameters

### -param otherDeviceAddress

The **XboxLiveDeviceAddress** to be compared to this one.

## -returns

Zero if the two objects represent the same device; non-zero if they represent different devices

## -remarks

This method compares the invoking object (`this`) with the given **XboxLiveDeviceAddress** object, and returns a value you can use to sort **XboxLiveDeviceAddress** objects. `A.Compare(B)` returns 0 if A and B refer to the same device. If they don't refer to the same device, then if `A.Compare(B)` returns -1, `B.Compare(A)` returns +1. The returned value can thus be used to consistently sort one **XboxLiveDeviceAddress** relative to another.

No connection to either of the **XboxLiveDeviceAddress** objects involved is required; and this method doesn't initiate communication with them.

## -examples

## -see-also
