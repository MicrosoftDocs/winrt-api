---
-api-id: P:Windows.ApplicationModel.Chat.RcsEndUserMessageAvailableEventArgs.Message
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.ApplicationModel.Chat.RcsEndUserMessage Message { get; }
-->

# Windows.ApplicationModel.Chat.RcsEndUserMessageAvailableEventArgs.Message

## -description
Gets the actual message to display, or empty if [IsMessageAvailable](rcsendusermessageavailableeventargs_ismessageavailable.md) is FALSE.

## -property-value
The actual message to display.

## -remarks
If[IsMessageAvailable](rcsendusermessageavailableeventargs_ismessageavailable.md) is **True**, then this will contain the message to display. If [IsMessageAvailable](rcsendusermessageavailableeventargs_ismessageavailable.md) is **False**, then this will be an empty string.

## -examples

## -see-also

## -capabilities
chatSystem, smsSend, chat
