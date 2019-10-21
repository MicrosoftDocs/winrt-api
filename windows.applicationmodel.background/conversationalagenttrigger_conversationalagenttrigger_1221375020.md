---
-api-id: M:Windows.ApplicationModel.Background.ConversationalAgentTrigger.#ctor
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public ConversationalAgentTrigger.ConversationalAgentTrigger()
-->

# Windows.ApplicationModel.Background.ConversationalAgentTrigger.ConversationalAgentTrigger

## -description

Creates an instance of a [ConversationalAgentTrigger](conversationalagenttrigger.md).

## -remarks

If a [ConversationalAgentSignal](../windows.applicationmodel.conversationalagent/conversationalagentsignal.md) is detected while a [ConversationalAgentSession](../windows.applicationmodel.conversationalagent/conversationalagentsession.md) is **inactive**, the AAR raises a [ConversationalAgentTrigger](conversationalagenttrigger.md) background event. Your app can then use the Signal property to process the conversation.

If a [ConversationalAgentSignal](../windows.applicationmodel.conversationalagent/conversationalagentsignal.md) is detected while a [ConversationalAgentSession](../windows.applicationmodel.conversationalagent/conversationalagentsession.md) is **active** (listening, speaking, detecting), the AAR does not raise  a [ConversationalAgentTrigger](conversationalagenttrigger.md) background event. Instead, it raises the [SessionInterrupted](../windows.applicationmodel.conversationalagent/conversationalagentsession_sessioninterrupted.md) event to indicate that the digital assistant app should set itself to inactive and stop processing input. The digital assistant can then decide to ignore the new signal or use it in the [context](../windows.applicationmodel.conversationalagent/conversationalagentsignal_signalcontext.md) of the current session.

> [!NOTE]
> Some digital assistant sessions cannot be interrupted by another signal. For example, Cortana requires the user to issue a cancel or stop command to end the current session (the user cannot be in a Cortana session and issue commands to Alexa).

## -see-also

## -examples
