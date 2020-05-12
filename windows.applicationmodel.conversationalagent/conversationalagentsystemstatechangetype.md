---
-api-id: T:Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSystemStateChangeType
-api-type: winrt enum
ms.custom: 19H1
---

<!-- Enumeration syntax.
public enum ConversationalAgentSystemStateChangeType : int 
-->

# Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSystemStateChangeType

## -description

Specifies the possible state changes for the [SystemStateChanged](conversationalagentsession_systemstatechanged.md) event.

## -enum-fields

### -field UserAuthentication:0

When set, indicates that the authentication status of the user has changed (such as when a user locks or unlocks a system). Corresponds to [ConversationalAgentSession.IsUserAuthenticated](conversationalagentsession_isuserauthenticated.md).

### -field ScreenAvailability:1

When set, indicates that the system's capability to turn on, or use, a display device has changed (this does not indicate whether or not the display is currently being used). Corresponds to [ConversationalAgentSession.IsScreenAvailable](conversationalagentsession_isscreenavailable.md).

### -field IndicatorLightAvailability:2

When set, indicates that the system's capability to use status indicator lights has changed. 

Corresponds to [ConversationalAgentSession.IsIndicatorLightAvailable](conversationalagentsession_isindicatorlightavailable.md).

### -field VoiceActivationAvailability:3

When set, indicates voice activation availability has been changed through system settings or group policy. Corresponds to [ConversationalAgentSession.IsVoiceActivationAvailable](conversationalagentsession_isvoiceactivationavailable.md).

## -remarks

For the current agent state, check [ConversationalAgentSession.AgentState](conversationalagentsession_agentstate.md).

## -see-also

[SystemStateChanged](conversationalagentsession_systemstatechanged.md), [ConversationalAgentSystemStateChangedEventArgs](conversationalagentsystemstatechangedeventargs.md)

## -examples
