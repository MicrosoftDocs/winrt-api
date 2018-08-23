---
-api-id: M:Windows.Devices.WiFiDirect.Services.WiFiDirectServiceAdvertiser.#ctor(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public WiFiDirectServiceAdvertiser(System.String serviceName)
-->

# Windows.Devices.WiFiDirect.Services.WiFiDirectServiceAdvertiser.WiFiDirectServiceAdvertiser

## -description
Creates an instance of the WiFiDirectServiceAdvertiser class. To start advertising a Wi-Fi Direct Service, create an instance of this class, set its properties appropriately for your service, and then call its [Start](wifidirectserviceadvertiser_start_1587696324.md) method.

## -parameters
### -param serviceName
The name of the service to be advertised. Service names are UTF-8 strings no more than 255 characters long. It is recommended that names use reverse domain name notation, where the service owner's DNS name (such as "contoso.com") is reversed and used as the beginning of the service name (such as "com.contoso.serviceX"). This convention is intended to make it easy to choose unique service names. Service names that start with "org.wi-fi.wfds" are reserved for use by the Wi-Fi Alliance, and you may not use such names for your service.

## -remarks

## -examples

## -see-also
