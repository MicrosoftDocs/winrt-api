---
-api-id: M:Windows.ApplicationModel.Chat.ChatMessageManager.RequestStoreAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Chat.ChatMessageStore> RequestStoreAsync()
-->

# Windows.ApplicationModel.Chat.ChatMessageManager.RequestStoreAsync

## -description
Returns the SMS messaging store for the phone.

## -returns
An asynchronous operation that returns a [ChatMessageStore](chatmessagestore.md) on successful completion.

## -remarks
This method returns an [IReadOnlyList](https://docs.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist-1?redirectedfrom=MSDN) of [ChatMessageStore class](chatmessagestore.md) objects. The method is invoked as an [IAsyncOperation](https://docs.microsoft.com/previous-versions/bb776309(v=vs.85)) as shown in the following example:

```
ChatMessageStore store = await ChatMessageManager.RequestStoreAsync();

```



## -examples

## -see-also

## -capabilities
chatSystem, smsSend, chat
