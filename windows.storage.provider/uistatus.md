---
-api-id: T:Windows.Storage.Provider.UIStatus
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Storage.Provider.UIStatus : int
-->

# UIStatus

## -description
Indicates the status of the file picker UI.

## -enum-fields
### -field Unavailable:0
The file picker is not showing UI and UI can't be requested.

If the app that provides updates requests UI by completing its response to a [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) event and setting the [FileUpdateRequest.Status](fileupdaterequest_status.md) to [FileUpdateStatus.UserInputNeeded](fileupdatestatus.md), the app will be closed immediately and the failure may be reported to the app that triggered the updates.

### -field Hidden:1
The file picker is not showing UI, but UI can be requested.

If the app that provides updates requests UI by completing its response to a [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) event and setting the [FileUpdateRequest.Status](fileupdaterequest_status.md) to [FileUpdateStatus.UserInputNeeded](fileupdatestatus.md), a [UIRequested](cachedfileupdaterui_uirequested.md) event will fire to indicate that UI will display immediately, and a new [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) event will fire (for the same file) so that the app can get the user's input and complete the request successfully.

### -field Visible:2
The file picker is currently showing UI because UI was requested by the app.

### -field Complete:3
The file picker is currently showing UI and all

This indicates that UI is presently being shown, and that the app has finished responding to all [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) events.




## -remarks

## -examples

## -see-also