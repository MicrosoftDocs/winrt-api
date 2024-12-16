---
-api-id: P:Windows.Devices.Printers.IppPrintDevice.CanModifyUserDefaultPrintTicket
-api-type: winrt property
---

# Windows.Devices.Printers.IppPrintDevice.CanModifyUserDefaultPrintTicket

<!--
public bool CanModifyUserDefaultPrintTicket { get; }
-->


## -description

Gets a boolean value indicating whether the [UserDefaultPrintTicket](ippprintdevice_userdefaultprintticket.md) can be modified.

## -property-value

True if the **UserDefaultPrintTicket** can be modified; otherwise, false.

## -remarks

The property will be false if the application is running in a restricted context and is not registered as a Print Support App for the current printer.

## -see-also

## -examples


