---
-api-id: M:Windows.UI.StartScreen.JumpList.LoadCurrentAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.UI.StartScreen.JumpList> LoadCurrentAsync()
-->

# Windows.UI.StartScreen.JumpList.LoadCurrentAsync

## -description
Asynchronously retrieves the current jump list and its items.

## -returns
When this method completes successfully, it returns the current [JumpList](jumplist.md). If the system does not support jump lists, this method returns an empty jump list and the [SaveAsync](jumplist_saveasync_2143735121.md) method has no effect. Apps can check for this case using the [isSupported](jumplist_issupported_930300905.md) method.

## -remarks

## -examples

## -see-also
