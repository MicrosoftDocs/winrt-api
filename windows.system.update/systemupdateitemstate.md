---
-api-id: T:Windows.System.Update.SystemUpdateItemState
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum SystemUpdateItemState : int 
-->

# Windows.System.Update.SystemUpdateItemState

> [!IMPORTANT]
> Only available for [Windows 10 IoT Core](https://learn.microsoft.com/windows/iot-core/windows-iot-core).

## -description
State of a [SystemUpdateItem](systemupdateitem.md).

## -enum-fields
### -field RebootRequired:7
Reboot required.

### -field Preparing:2
Preparing update item.

### -field NotStarted:0
Update not started.

### -field Installing:5
Update item installing.

### -field Initializing:1
Update item initializing.

### -field Error:8
Error encountered when trying to update&mdash;see [ExtendedError](systemupdateitem_extendederror.md)

### -field Downloading:4
Update item downloading.

### -field Completed:6
Update completed.

### -field Calculating:3
Calculating update item actions.

## -remarks

## -see-also
[SystemUpdateItem.State](systemupdateitem_state.md)

## -examples

