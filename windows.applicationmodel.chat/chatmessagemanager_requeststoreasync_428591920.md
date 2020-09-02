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
The method is invoked as an [IAsyncOperation](/previous-versions/bb776309(v=vs.85)) as shown in the following example:

```
ChatMessageStore store = await ChatMessageManager.RequestStoreAsync();

```



## -examples

## -see-also

## -capabilities
chatSystem, smsSend, chat
