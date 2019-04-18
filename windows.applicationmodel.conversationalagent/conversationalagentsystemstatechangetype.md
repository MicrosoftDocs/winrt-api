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

### -field VoiceActivationAvailability:3

When set, indicates that voice activation is turned off due to settings or group policy.

### -field UserAuthentication:0

When set, indicates that the user is not authenticated (for example, the device is locked).

### -field ScreenAvailability:1

When set, indicates that the screen cannot be turned on.

### -field IndicatorLightAvailability:2

When set, indicates that the indicator lights are not available.

## -remarks

## -see-also

[SystemStateChanged](conversationalagentsession_systemstatechanged.md), [ConversationalAgentSystemStateChangedEventArgs](conversationalagentsystemstatechangedeventargs.md)

## -examples
