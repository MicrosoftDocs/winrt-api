---
-api-id: M:Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSession.RequestInterruptible(System.Boolean)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public ConversationalAgentSessionUpdateResponse ConversationalAgentSession.RequestInterruptible(Boolean interruptible)
-->

# Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSession.RequestInterruptible

## -description

Synchronously requests that this [ConversationalAgentSession](conversationalagentsession.md) be interruptible if the keyword for another digital assistant is detected.

> [!Important]
> To avoid possible concurrency issues, we recommend using [RequestInterruptibleAsync](conversationalagentsession_requestinterruptibleasync_1030348212.md) instead.

## -parameters

### -param interruptible

True, if interruptible; otherwise, false.

## -returns

A [ConversationalAgentSessionUpdateResponse](conversationalagentsessionupdateresponse.md).

## -remarks

Some digital assistant sessions cannot be interrupted by another signal. For example, Cortana requires the user to issue a cancel or stop command to end the current session (the user cannot be in a Cortana session and issue commands to Alexa).

If a session can be interrupted, the Windows Conversational Agent platform raises the [SessionInterrupted](conversationalagentsession_sessioninterrupted.md) event to indicate that the digital assistant app should set itself to inactive and stop processing input.

## -see-also

[RequestInterruptibleAsync](conversationalagentsession_requestinterruptibleasync_1030348212.md)

## -examples
