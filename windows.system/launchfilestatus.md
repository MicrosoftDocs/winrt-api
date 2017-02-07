---
-api-id: T:Windows.System.LaunchFileStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.System.LaunchFileStatus : int
-->

# LaunchFileStatus

## -description
Specifies the result of activating an application for a file.

## -enum-fields
### -field Success:0
The application activated successfully.

### -field AppUnavailable:1
The application cannot be activated which may be because it is being updated by the store, it was installed on a removable device that is not available, and so on.

### -field DeniedByPolicy:2
The application cannot be activated for this file because files may not cross user boundaries.

### -field FileTypeNotSupported:3
The application you are trying to activate does not support this file type.

### -field Unknown:4
An unknown error was encountered while activating the application.


## -remarks

## -examples

## -see-also