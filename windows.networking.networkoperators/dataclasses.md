---
-api-id: T:Windows.Networking.NetworkOperators.DataClasses
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Networking.NetworkOperators.DataClasses : uint
-->

# DataClasses

## -description
Describes the cellular data services supported by a mobile broadband network device.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.


> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations). 

## -enum-fields
### -field None:0
No data services supported.

### -field Gprs:1
The device supports the GPRS data service implemented by GSM providers.

### -field Edge:2
The device supports the EDGE data service implemented by GSM providers.

### -field Umts:4
The device supports the UMTS data service implemented by GSM providers.

### -field Hsdpa:8
The device supports the HSDPA data service implemented by GSM providers.

### -field Hsupa:16
The device supports the HSUPA (High Speed Uplink Packet Access) data service.

### -field LteAdvanced:32
The device supports the HSDPA Lite data service implemented by GSM providers.

### -field Cdma1xRtt:65536
The device supports the 1xRTT data service implemented by CDMA providers.

### -field Cdma1xEvdo:131072
The device supports the 1xEV-DO data service implemented by CDMA providers.

### -field Cdma1xEvdoRevA:262144
The device supports the 1xEV-DO RevA data service implemented by CDMA providers.

### -field Cdma1xEvdv:524288
The device supports the 1xEV-DV data service implemented by CDMA providers.

### -field Cdma3xRtt:1048576
The device supports the 3xRTT data service implemented by CDMA providers.

### -field Cdma1xEvdoRevB:2097152
The device supports the 1xEV-DO RevB data service, which is identified for future use.

### -field CdmaUmb:4194304
The device supports the UMB data service implemented by CDMA providers.

### -field Custom:2147483648
The device supports a custom data service.


## -remarks

## -examples

## -see-also
## -capabilities
cellularDeviceIdentity, cellularDeviceControl
