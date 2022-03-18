---
-api-id: T:Windows.ApplicationModel.Store.Preview.DeliveryOptimizationDownloadMode
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum DeliveryOptimizationDownloadMode : int
-->

# Windows.ApplicationModel.Store.Preview.DeliveryOptimizationDownloadMode

## -description
Defines values that represent the supported download mode types in the Delivery Optimization settings for the current device. The [DownloadMode](deliveryoptimizationsettings_downloadmode.md) property returns one of these values.

## -enum-fields
### -field Simple:0
Delivery Optimization cloud services are disabled.

### -field Lan:2
Peer sharing for Delivery Optimization on the same network is enabled.

### -field Internet:4
Internet peer sources for Delivery Optimization are enabled.

### -field HttpOnly:1
Peer-to-peer caching is disabled but Delivery Optimization can still download content from Windows Update servers or WSUS servers.

### -field Group:3
Group peer sharing for Delivery Optimization is enabled. Peering occurs across internal subnets, between devices that belong to the same group, including devices in remote offices. 

### -field Bypass:5
Delivery Optimization is bypassed and BITS is used instead.

## -remarks
For more information about download modes, see [Configure Delivery Optimization for Windows 10 updates](/windows/deployment/update/waas-delivery-optimization#download-mode).

## -see-also

## -examples
