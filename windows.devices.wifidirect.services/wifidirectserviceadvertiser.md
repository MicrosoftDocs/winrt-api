---
-api-id: T:Windows.Devices.WiFiDirect.Services.WiFiDirectServiceAdvertiser
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class WiFiDirectServiceAdvertiser : Windows.Devices.WiFiDirect.Services.IWiFiDirectServiceAdvertiser
-->

# Windows.Devices.WiFiDirect.Services.WiFiDirectServiceAdvertiser

## -description
Represents a Service Advertiser. This class is used by code on a device that advertises Wi-Fi Direct Services, to advertise the service.

## -remarks
This is one of several classes that support connecting two devices with a preference for which device should be the Group Owner. See the [Windows.Devices.WiFiDirect.Service](windows_devices_wifidirect_services.md) topic for a discussion of device pairing and how it can cause the Group Owner preference to be ignored (and how to fix that.)

The service name is set in the [WiFiDirectServiceAdvertiser](wifidirectserviceadvertiser_wifidirectserviceadvertiser_290278668.md) constructor. Service names are UTF-8 strings no more than 255 characters long. It is recommended that names use reverse domain name notation, where the service owner's DNS name (such as "contoso.com") is reversed and used as the beginning of the service name (such as "com.contoso.serviceX"). This convention is intended to make it easy to choose unique service names. Service names that start with "org.wi-fi.wfds" are reserved for use by the Wi-Fi Alliance, and you may not use such names for your service.

## -examples

## -see-also
