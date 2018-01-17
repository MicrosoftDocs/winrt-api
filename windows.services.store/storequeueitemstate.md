---
-api-id: T:Windows.Services.Store.StoreQueueItemState
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum StoreQueueItemState : int
-->

# Windows.Services.Store.StoreQueueItemState

## -description
Defines values that specify the state of a new or updated package that is in the download and installation queue for the current app.

## -enum-fields
### -field Paused:4
The download or installation of the package was paused.

### -field Error:3
The download or installation of the package encountered an error.

### -field Completed:1
The download and installation of the package completed.

### -field Canceled:2
The download or installation of the package was canceled.

### -field Active:0
The download or installation of the package is in progress.

## -remarks
[StoreQueueItemExtendedState](storequeueitemextendedstate.md)

## -see-also

## -examples
