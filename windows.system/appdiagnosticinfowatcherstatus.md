---
-api-id: T:Windows.System.AppDiagnosticInfoWatcherStatus
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum AppDiagnosticInfoWatcherStatus : int 
-->

# Windows.System.AppDiagnosticInfoWatcherStatus

## -description
Defines the status values that are returned from a call to [AppDiagnosticInfoWatcher.Status](appdiagnosticinfowatcher_status.md).

## -enum-fields
### -field Created:0
The **AppDiagnosticInfoWatcher** has been created.

### -field Started:1
The **AppDiagnosticInfoWatcher** has started.

### -field EnumerationCompleted:2
The **AppDiagnosticInfoWatcher** has finished enumerating running apps.

### -field Stopping:3
The **AppDiagnosticInfoWatcher** is stopping.

### -field Stopped:4
The **AppDiagnosticInfoWatcher** has stopped.

### -field Aborted:5
The **AppDiagnosticInfoWatcher** was aborted.

## -remarks

## -see-also
[AppDiagnosticInfoWatcher](appdiagnosticinfowatcher.md)

## -examples

## -capabilities
appDiagnostics
