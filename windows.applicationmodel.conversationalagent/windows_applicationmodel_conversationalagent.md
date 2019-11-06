---
-api-id: N:Windows.ApplicationModel.ConversationalAgent
-api-type: winrt namespace
ms.custom: 19H1
---

<!-- Namespace syntax.
namespace Windows.ApplicationModel.ConversationalAgent 
-->

# Windows.ApplicationModel.ConversationalAgent

## -description

Provides applications the ability to expose functionality through any digital assistant supported by the Windows platform Agent Activation Runtime (AAR).

## -remarks

Users can enable a first-stage signal for a digital assistant in Settings. This signal can include a *wake* utterance, Bluetooth transmission, system keyboard accelerator, in-app speech recognition, or other sounds (door slam, smoke detector). For example, the "Hey Cortana" keywords enable listening mode for a Cortana interaction.

A second-stage utterance (or keyword detection) is part of the intent phase. For example, "Hey Cortana, *what's the forecast for today?*".

Third-stage keyword detection involves a remote cloud service.

If a [ConversationalAgentSignal](conversationalagentsignal.md) is detected while a [ConversationalAgentSession](conversationalagentsession.md) is **inactive**, the AAR raises a [ConversationalAgentTrigger](../windows.applicationmodel.background/conversationalagenttrigger.md) background event. Your app can then use the Signal property to process the conversation.

If a [ConversationalAgentSignal](conversationalagentsignal.md) is detected while a [ConversationalAgentSession](conversationalagentsession.md) is **active** (listening, speaking, detecting), the AAR does not raise  a [ConversationalAgentTrigger](../windows.applicationmodel.background/conversationalagenttrigger.md) background event. Instead, it raises the [SessionInterrupted](conversationalagentsession_sessioninterrupted.md) event to indicate that the digital assistant app should set itself to inactive and stop processing input. The digital assistant can then decide to ignore the new signal or use it in the [context](conversationalagentsignal_signalcontext.md) of the current session.

> [!NOTE]
> Some digital assistant sessions cannot be interrupted by another signal. For example, Cortana requires the user to issue a cancel or stop command to end the current session (the user cannot be in a Cortana session and issue commands to Alexa).

## -see-also

## -examples
