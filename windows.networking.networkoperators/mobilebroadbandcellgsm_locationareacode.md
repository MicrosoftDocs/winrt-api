---
-api-id: P:Windows.Networking.NetworkOperators.MobileBroadbandCellGsm.LocationAreaCode
-api-type: winrt property
---

<!-- Property syntax.
public IReference<uint> LocationAreaCode { get; }
-->

# Windows.Networking.NetworkOperators.MobileBroadbandCellGsm.LocationAreaCode

## -description
Gets the Location Area Code (LAC).

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -property-value
The Location Area Code (LAC).

## -remarks
The range of this value is 0~65535; returns null if unknown.

## -see-also

## -examples


## -capabilities
cellularDeviceIdentity, cellularDeviceControl
