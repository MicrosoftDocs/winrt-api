---
-api-id: T:Windows.ApplicationModel.Core.AppRestartFailureReason
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum AppRestartFailureReason : int
-->

# Windows.ApplicationModel.Core.AppRestartFailureReason

## -description
Describes the reasons why an app could fail a request to restart.

## -enum-fields
### -field RestartPending:0
A restart is already in progress.

### -field Other:3
Unspecified failure.

### -field NotInForeground:1
An app must be visible and in the foreground when it calls the restart API.

### -field InvalidUser:2
Could not restart for the specified user.

## -remarks

## -see-also

## -examples
