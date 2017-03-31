---
-api-id: M:Windows.ApplicationModel.Chat.ChatMessageChangedEventArgs.GetDeferral
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.ApplicationModel.Chat.ChatMessageChangedDeferral GetDeferral()
-->

# Windows.ApplicationModel.Chat.ChatMessageChangedEventArgs.GetDeferral

## -description
The message changed event handler that an application registers with the message store receives a deferral object in the event parameters. The [GetDeferral](chatmessagechangedeventargs_getdeferral.md) method registers a change deferral and allows an application to take action related to the change before the message store completes the change.

## -returns
Gets a deferral for the [MessageChanged](chatmessagestore_messagechanged.md) event.

## -remarks
The chat application receives a [ChatMessageChangedDeferral class](chatmessagechangeddeferral.md) object when requested by [GetDeferral](chatmessagechangedeventargs_getdeferral.md). Deferrals are only available if the application has a change event handler added to the [MessageChanged](chatmessagestore_messagechanged.md) event of the [ChatMessageStore class](chatmessagestore.md). The [ChatMessageChangedDeferral class](chatmessagechangeddeferral.md) received in the parameters for the event handler is retained for later use to notify the message store that actions related to the changer are complete.

## -examples

## -see-also
