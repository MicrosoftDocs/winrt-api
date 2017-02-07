---
-api-id: T:Windows.System.LaunchQuerySupportStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.System.LaunchQuerySupportStatus : int
-->

# LaunchQuerySupportStatus

## -description
Specifies whether an app is available that supports activation.

## -enum-fields
### -field Available:0
An app that handles the activation is available and may be activated.

### -field AppNotInstalled:1
No app is installed to handle the activation.

### -field AppUnavailable:2
An app that handles the activation is installed but not available because it is being updated by the store or it was installed on a removable device that is not available.

### -field NotSupported:3
The app does not handle the activation.

### -field Unknown:4
An unknown error was encountered while determining whether an app supports the activation.


## -remarks

## -examples

## -see-also