---
-api-id: P:Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSignal.SignalContext
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public object SignalContext { get;  set; }
-->

# Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSignal.SignalContext

## -description

Gets or sets the context for the [ConversationalAgentSignal](conversationalagentsignal.md).

## -property-value

The signal context.

## -remarks

The Windows Conversational Agent platform can detect other [ConversationalAgentSignal](conversationalagentsignal.md) during an active [ConversationalAgentSession](conversationalagentsession.md) (see [ConversationalAgentState](conversationalagentstate.md)). As a session is already in progress, the [ConversationalAgent](windows_applicationmodel_conversationalagent.md) can decide to use it in the context of the current session, or ignore it.

An example of this behavior is when the user utters "Hey Cortana, set a reminder", Cortana begins to respond with “What would you like... [to be reminded of?]”, and the user interrupts the response with additional instructions like "pick up flowers for mom". Cortana gets this new signal and stops speaking to process the new input in the context of the original intent detection.

## -see-also

## -examples
