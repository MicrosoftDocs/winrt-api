---
-api-id: M:Windows.Devices.WiFiDirect.WiFiDirectAdvertisementPublisher.Start
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void Start()
-->

# Windows.Devices.WiFiDirect.WiFiDirectAdvertisementPublisher.Start

## -description
Starts the Wi-Fi Direct advertisement.

## -remarks
The status of the [WiFiDirectAdvertisementPublisher](wifidirectadvertisementpublisher.md) will transition to the **Started** state or to the **Aborted** state if the request failed immediately due to an error.

The [WiFiDirectAdvertisementPublisher](wifidirectadvertisementpublisher.md) will be automatically stopped when an app is suspended if the [ListenStateDiscoverability](wifidirectadvertisement_listenstatediscoverability.md) property on the [WiFiDirectAdvertisement](wifidirectadvertisement.md) is set to **Normal**.

## -examples

## -see-also
[WiFiDirectAdvertisement](wifidirectadvertisement.md), [WiFiDirectAdvertisement.ListenStateDiscoverability](wifidirectadvertisement_listenstatediscoverability.md), [WiFiDirectAdvertisementPublisherStatus](wifidirectadvertisementpublisherstatus.md)