---
-api-id: T:Windows.Security.Isolation.IsolatedWindowsEnvironmentProgressState
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum IsolatedWindowsEnvironmentProgressState : int 
-->

# Windows.Security.Isolation.IsolatedWindowsEnvironmentProgressState

## -description

**Deprecated.** Returned during Isolated Windows Environment creation, it represents the state of the creation process.

## -enum-fields

### -field Queued:0

Isolated Windows Environment creation is queued.

### -field Processing:1

Isolated Windows Environment creation is preparing to start.

### -field Completed:2

Isolated Windows Environment creation has completed.

### -field Creating: 3

Isolated Windows Environment creation is in progress.

### -field Retrying: 4

Something went wrong while creating the Isolated Windows Environment. The creation is being retried.

### -field Starting: 5

Isolated Windows Environment is starting.

### -field Finalizing: 6

Isolated Windows Environment settings are being configured.

## -remarks

> [!WARNING]
> This is a deprecated API.

## -see-also

## -examples
