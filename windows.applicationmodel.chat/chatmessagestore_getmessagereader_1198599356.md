---
-api-id: M:Windows.ApplicationModel.Chat.ChatMessageStore.GetMessageReader
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.ApplicationModel.Chat.ChatMessageReader GetMessageReader()
-->

# Windows.ApplicationModel.Chat.ChatMessageStore.GetMessageReader

## -description
Gets a [ChatMessageReader class](chatmessagereader.md) object which provides a message collection from the message store.

## -returns
The chat message reader.

## -remarks
The following example uses the message reader to find the first message that has a subject containing a simple search string:

```
async ChatMessage SearchMessagesBySubject(ChatMesssage store, string searchItem)
{
    ChatMessage foundMessage = null;
    IReadOnlyList<ChatMessage> messageList = await store.GetMessageReader().ReadBatchAsync();
    if (messageList.Count > 0)
    {
        foreach(ChatMessage message in messageList)
        {
            If (message.Subject.Contains(searchItem))
            {
                foundMessage = message;{
                break;
            }
        }
    }
    return foundMessage;
}
```



## -examples

## -see-also
[GetMessageReader(TimeSpan)](chatmessagestore_getmessagereader_232560328.md)