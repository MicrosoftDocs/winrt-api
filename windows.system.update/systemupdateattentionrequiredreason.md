---
-api-id: T:Windows.System.Update.SystemUpdateAttentionRequiredReason
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum SystemUpdateAttentionRequiredReason : int 
-->

# Windows.System.Update.SystemUpdateAttentionRequiredReason

> [!IMPORTANT]
> Only available for [Windows 10 IoT Core](https://learn.microsoft.com/windows/iot-core/windows-iot-core).

## -description
Reason why user attention is required.

## -enum-fields
### -field UpdateBlocked:4
Update cannot proceed.

### -field None:0
No attention required.

### -field NetworkRequired:1
Network connection requires attention.

### -field InsufficientDiskSpace:2
Insufficient disk space to download updates.

### -field InsufficientBattery:3
Insufficient battery power to begin updating system.

## -remarks

## -see-also
[SystemUpdateManager.ExtendedError](systemupdatemanager_extendederror.md), [SystemUpdateManager.AttentionRequiredReason](systemupdatemanager_attentionrequiredreason.md)

## -examples

