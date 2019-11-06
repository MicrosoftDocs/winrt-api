---
-api-id: P:Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSession.IsInterrupted
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public bool IsInterrupted { get; }
-->

# Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSession.IsInterrupted

## -description

Gets whether the [ConversationalAgentSession](conversationalagentsession.md) is being interrupted.

## -property-value

True, if the [ConversationalAgentSession](conversationalagentsession.md) is interrupted; otherwise, false.

## -remarks

Some digital assistant sessions cannot be interrupted by another signal. For example, Cortana requires the user to issue a cancel or stop command to end the current session (the user cannot be in a Cortana session and issue commands to Alexa).

If a session can be interrupted, the Windows Conversational Agent platform raises the [SessionInterrupted](conversationalagentsession_sessioninterrupted.md) event to indicate that the digital assistant app should set itself to inactive and stop processing input.

## -see-also

[IsInterruptible](conversationalagentsession_isinterruptible.md), [RequestInterruptible](conversationalagentsession_requestinterruptible_927441230.md), [RequestInterruptibleAsync](conversationalagentsession_requestinterruptibleasync_1030348212.md)

## -examples
