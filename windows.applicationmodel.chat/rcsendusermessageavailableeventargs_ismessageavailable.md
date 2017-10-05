---
-api-id: P:Windows.ApplicationModel.Chat.RcsEndUserMessageAvailableEventArgs.IsMessageAvailable
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public bool IsMessageAvailable { get; }
-->

# Windows.ApplicationModel.Chat.RcsEndUserMessageAvailableEventArgs.IsMessageAvailable

## -description
Gets a Boolean value indicating if a new message is available.

## -property-value
A Boolean value indicating if a new message is available.

## -remarks
There could be more than one message to be displayed. The service controls how many and the order in which to display them. You should block all Rich Communication Services (RCS) functionality while the service is displaying these messages, until a notification with this flag set to FALSE arrives.

## -examples

## -see-also

## -capabilities
chatSystem, smsSend, chat
