---
-api-id: T:Windows.System.LaunchUriStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.System.LaunchUriStatus : int
-->

# LaunchUriStatus

## -description
Specifies the result of activating an application for a URI.

## -enum-fields
### -field Success:0
The application activated successfully.

### -field AppUnavailable:1
The application cannot be activated which may be because it is being updated by the store, it was installed on a removable device that is not available, and so on.

### -field ProtocolUnavailable:2
The application you are trying to activate does not support this URI.

### -field Unknown:3
An unknown error was encountered while activating the application.


## -remarks

## -examples

## -see-also