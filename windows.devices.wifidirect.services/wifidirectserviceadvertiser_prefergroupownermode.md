---
-api-id: P:Windows.Devices.WiFiDirect.Services.WiFiDirectServiceAdvertiser.PreferGroupOwnerMode
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public bool PreferGroupOwnerMode { get;  set; }
-->

# Windows.Devices.WiFiDirect.Services.WiFiDirectServiceAdvertiser.PreferGroupOwnerMode

## -description
Gets or sets a value indicating whether the service requires that it be the Wi-Fi Direct Peer to Peer (P2P) Group Owner.

Being the Group Owner enables the service to exercise more control over the P2P connection configuration and the connection process. For details, see the Wi-Fi Direct P2P Technical Specifications, available from the Wi-Fi Alliance.

## -property-value
If true, the service must be the Group Owner (GO) of the Peer to Peer (P2P) connection between seeker and service. If false, the service will accept connections whether it is the GO or not.

## -remarks

## -examples

## -see-also
