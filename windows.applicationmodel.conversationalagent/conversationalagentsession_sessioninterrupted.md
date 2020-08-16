---
-api-id: E:Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSession.SessionInterrupted
-api-type: winrt event
ms.custom: 19H1
---

<!-- Event syntax.
public event TypedEventHandler SessionInterrupted<ConversationalAgentSession, ConversationalAgentSessionInterruptedEventArgs>
-->

# Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSession.SessionInterrupted

## -description

Occurs when another digital assistant activation [signal](conversationalagentsignal.md) has been detected.

## -remarks

Some digital assistant sessions cannot be interrupted by another signal. For example, Cortana requires the user to issue a cancel or stop command to end the current session (the user cannot be in a Cortana session and issue commands to Alexa).

If a session can be interrupted, the Windows Conversational Agent platform raises the SessionInterrupted event to indicate that the digital assistant app should set itself to inactive and stop processing input.

## -see-also

[ConversationalAgentSessionInterruptedEventArgs](conversationalagentsessioninterruptedeventargs.md)

## -examples
