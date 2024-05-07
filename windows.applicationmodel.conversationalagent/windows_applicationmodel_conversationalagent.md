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

Provides applications the ability to expose functionality through any digital assistant supported by the Windows Conversational Agent platform.

> [!IMPORTANT]
> The Windows.ApplicationModel.ConversationalAgent APIs are part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -remarks

Users can enable a platform-level detection signal for a conversational agent in Settings. This signal can include a keyword utterance, Bluetooth transmission, system keyboard accelerator, in-app speech recognition, or other sounds (door slam, smoke detector). For example, the "Hey Cortana" keyword that begins a voice interaction with Cortana.

Platform-level signal detectors act as a "first-pass" filter and can result in too many unintended activations. For this reason, we recommend that you consider additional verification of an activation signal, such as using a more stringent keyword detector from the context of the agent application.

If a [ConversationalAgentSignal](conversationalagentsignal.md) is detected while the application is not running, or is not able to respond to the [ConversationalAgentSession.SignalDetected](conversationalagentsession_signaldetected.md) event, the application is activated in the background using a task registered with a [ConversationalAgentTrigger](../windows.applicationmodel.background/conversationalagenttrigger.md).

If a [ConversationalAgentSignal](conversationalagentsignal.md) is detected while the application is able to respond to a [ConversationalAgentSession.SignalDetected](conversationalagentsession_signaldetected.md) event (by calling [ConversationalAgentSession.RequestAgentStateChangeAsync](conversationalagentsession_requestagentstatechangeasync_1892921766.md)), no background activation occurs, as the signal has already been handled.

If a [ConversationalAgentSignal](conversationalagentsignal.md) is detected for a conversational agent while an interruptible session (see [RequestInterruptableAsync](conversationalagentsession_requestinterruptibleasync_1030348212.md)) is already active, the session will receive a [ConversationalAgentSession.SessionInterrupted](conversationalagentsession_sessioninterrupted.md) event to indicate that a new signal event has been raised.

> [!NOTE]
> Some digital assistant sessions cannot be interrupted by another signal. For example, Cortana requires the user to issue a cancel or stop command to end the current session (the user cannot be in a Cortana session and issue commands to Alexa).

## -see-also

## -examples
