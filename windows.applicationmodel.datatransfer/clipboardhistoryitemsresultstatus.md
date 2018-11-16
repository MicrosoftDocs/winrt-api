---
-api-id: T:Windows.ApplicationModel.DataTransfer.ClipboardHistoryItemsResultStatus
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum ClipboardHistoryItemsResultStatus : int
-->

# Windows.ApplicationModel.DataTransfer.ClipboardHistoryItemsResultStatus

## -description
Represents the return status of a call to the [GetHistoryItemsAsync](clipboard_gethistoryitemsasync_2128899999.md) method to get the list of items currently in the clipboard history.

## -enum-fields
### -field Success:0
The request was successful.

### -field ClipboardHistoryDisabled:2
Clipboard history is disabled for the current user.

### -field AccessDenied:1
Access to the clipboard history is denied.

## -remarks

## -see-also
[GetHistoryItemsAsync](clipboard_gethistoryitemsasync_2128899999.md),[Status](clipboardhistoryitemsresult_status.md)

## -examples
