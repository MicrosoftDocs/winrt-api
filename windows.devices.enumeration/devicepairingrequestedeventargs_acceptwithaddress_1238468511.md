---
-api-id: M:Windows.Devices.Enumeration.DevicePairingRequestedEventArgs.AcceptWithAddress(System.String)
-api-type: winrt method
---

# Windows.Devices.Enumeration.DevicePairingRequestedEventArgs.AcceptWithAddress(System.String)

<!--
public void AcceptWithAddress (string address);
-->


## -description

Accepts a [PairingRequested](deviceinformationcustompairing_pairingrequested.md) event with an address, and pairs the device with the application.

## -parameters

### -param address

Your app must provide an address from the device. This is typically used for directed discovery over a network protocol such as IPP or UPnP, where the application already knows the IP/address/URL of the device. You should call **AcceptWithAddress** if you want the pairing to complete. Pass in the address as a parameter.

## -remarks

## -see-also

## -examples
