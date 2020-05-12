---
-api-id: P:Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSignal.SignalEnd
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public TimeSpan SignalEnd { get;  set; }
-->

# Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSignal.SignalEnd

## -description

Gets or sets the time span of the [ConversationalAgentSignal](conversationalagentsignal.md) end.

## -property-value

## -remarks

If the [SignalStart](conversationalagentsignal_signalstart.md) and SignalEnd time spans are the same, the signal is not a speech activation (for example, a keyboard press or Bluetooth activation).

If the [SignalStart](conversationalagentsignal_signalstart.md) and SignalEnd time spans are different, the values indicate the position of the keyword utterance in the audio stream.

## -see-also

## -examples
