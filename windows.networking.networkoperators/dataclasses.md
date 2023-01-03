---
-api-id: T:Windows.Networking.NetworkOperators.DataClasses
-api-type: winrt enum
-api-device-family-note: xbox
ms.custom: 19H1
---

<!-- Enumeration syntax
public enum Windows.Networking.NetworkOperators.DataClasses : uint
-->

# DataClasses

## -description

Defines constants that specify a cellular data service supported by a mobile broadband network device.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -enum-fields

### -field Cdma1xEvdo:131072
The device supports the 1xEV-DO data service implemented by CDMA providers.

### -field Cdma1xEvdoRevA:262144
The device supports the 1xEV-DO RevA data service implemented by CDMA providers.

### -field Cdma1xEvdoRevB:2097152
The device supports the 1xEV-DO RevB data service, which is identified for future use.

### -field Cdma1xEvdv:524288
The device supports the 1xEV-DV data service implemented by CDMA providers.

### -field Cdma1xRtt:65536
The device supports the 1xRTT data service implemented by CDMA providers.

### -field Cdma3xRtt:1048576
The device supports the 3xRTT data service implemented by CDMA providers.

### -field CdmaUmb:4194304
The device supports the UMB data service implemented by CDMA providers.

### -field Custom:2147483648
The device supports a custom data service.

### -field Edge:2
The device supports the EDGE data service implemented by GSM providers.

### -field Gprs:1
The device supports the GPRS data service implemented by GSM providers.

### -field Hsdpa:8
The device supports the HSDPA data service implemented by GSM providers.

### -field Hsupa:16
The device supports the HSUPA (High Speed Uplink Packet Access) data service.

### -field LteAdvanced:32
The device supports the LTE Advanced (LTE+) data service implemented by GSM providers.

### -field NewRadioNonStandalone:64
Specifies the 5G non-standalone data service leveraging LTE core.

### -field NewRadioStandalone:128
Specifies the advanced 5G data services leveraging 5G core.

### -field None:0
No data services supported.

### -field Umts:4
The device supports the UMTS data service implemented by GSM providers.

## -remarks

## -examples

## -see-also

## -capabilities

cellularDeviceIdentity, cellularDeviceControl
