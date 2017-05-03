---
-api-id: T:Windows.Networking.NetworkOperators.MobileBroadbandPinType
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Networking.NetworkOperators.MobileBroadbandPinType : int
-->

# MobileBroadbandPinType

## -description
Describes the possible types for a mobile broadband PIN.

## -enum-fields
### -field None:0
Not used (only for initialization).

### -field Custom:1
This is a custom vendor-defined PIN type. It is not included in the list.

### -field Pin1:2
For GSM-based devices, this is a Subscriber Identity Module (SIM) PIN. For CDMA-based devices, power-on device lock is reported as PIN1.

### -field Pin2:3
This is a SIM PIN2 that protects certain SIM functionality.

### -field SimPin:4
This is a PIN that locks the device to a specific SIM card.

### -field FirstSimPin:5
This is a PIN that locks the device to the very first inserted SIM card.

### -field NetworkPin:6
This is a PIN that allows the device to be personalized to a network. For more information about this PIN type, see section 22.022 of the 3GPP specification.

### -field NetworkSubsetPin:7
This is a PIN that allows the device to be personalized to a subset of a network. For more information about this PIN type, see section 22.022 of the 3GPP specification.

### -field ServiceProviderPin:8
This is a PIN that allows the device to be personalized to a service provider. For more information about this PIN type, see section 22.022 of the 3GPP specification.

### -field CorporatePin:9
This is a PIN that allows the device to be personalized to a specific company. For more information about this PIN type, see section 22.022 of the 3GPP specification.

### -field SubsidyLock:10
This is a PIN that allows the device to be restricted to operate on a specific network. For more information about this PIN type, see section 22.022 of the 3GPP specification.


## -remarks

## -examples

## -see-also
[MobileBroadbandPin](mobilebroadbandpin.md)