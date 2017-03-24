---
-api-id: P:Windows.ApplicationModel.Chat.ChatMessageStore.ChangeTracker
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.ApplicationModel.Chat.ChatMessageChangeTracker ChangeTracker { get; }
-->

# Windows.ApplicationModel.Chat.ChatMessageStore.ChangeTracker

## -description
Gets a [ChatMessageChangeTracker class](chatmessagechangetracker.md) object for the message store. A message change tracker allows an application to monitor changes to messages in the message store.

## -property-value
The chat message change tracker for the store.

## -remarks
An application can enable change tracking by accessing this [ChatMessageChangeTracker](chatmessagechangetracker.md) object. The following example shows how to enable message change tracking.

```
// Enable message change tracking
void SetTrackingOn(ChatMessageStore store)
{
    store.ChangeTracker.Enable();
}
```

The chat application receives notifications of message changes in its message change event handler which is registered to the [MessageChanged](chatmessagestore_messagechanged.md) event.

## -examples

## -see-also
