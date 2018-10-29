---
-api-id: P:Windows.Networking.NetworkOperators.MobileBroadbandCellTdscdma.ChannelNumber
-api-type: winrt property
---

<!-- Property syntax.
public IReference<uint> ChannelNumber { get; }
-->

# Windows.Networking.NetworkOperators.MobileBroadbandCellTdscdma.ChannelNumber

## -description
Gets the channel number for serving cell.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.

> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations). 

## -property-value
The channel number for serving cell.

## -remarks
The range of this value is 0~16383; returns null if unknown.
## -see-also

## -examples


## -capabilities
cellularDeviceIdentity, cellularDeviceControl
