---
-api-id: M:Windows.Management.Update.WindowsUpdateManager.GetMostRecentCompletedUpdatesAsync(System.Int32)
-api-type: winrt method
---

# Windows.Management.Update.WindowsUpdateManager.GetMostRecentCompletedUpdatesAsync(System.Int32)

<!--
public Windows.Foundation.IAsyncOperation<System.Collections.Generic.IReadOnlyList<Windows.Management.Update.WindowsUpdateItem>> GetMostRecentCompletedUpdatesAsync (int count);
-->


## -description

Asynchronously retrieves information about the most recently completed updates.

## -parameters

### -param count

The number of recently completed updates to retrieve.

## -returns

An asynchronous operation object which, when it completes, contains a list of the *N* most recently completed updates, where *N* can't exceed *count*.

## -remarks

## -see-also
[WindowsUpdateItem](./windowsupdateitem.md)

## -examples
