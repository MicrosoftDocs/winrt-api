---
-api-id: P:Windows.Networking.NetworkOperators.MobileBroadbandCellUmts.PathLossInDB
-api-type: winrt property
---

<!-- Property syntax.
public IReference<double> PathLossInDB { get; }
-->

# Windows.Networking.NetworkOperators.MobileBroadbandCellUmts.PathLossInDB

## -description
Gets the path loss in dB. 

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -property-value
The path loss in dB. 

## -remarks
The range of this value is 46~173; returns null if unknown.
## -see-also

## -examples


## -capabilities
cellularDeviceIdentity, cellularDeviceControl
