---
-api-id: T:Windows.ApplicationModel.ConversationalAgent.ConversationalAgentState
-api-type: winrt enum
ms.custom: 19H1
---

<!-- Enumeration syntax.
public enum ConversationalAgentState : int 
-->

# Windows.ApplicationModel.ConversationalAgent.ConversationalAgentState

## -description

Specifies each possible [AgentState](conversationalagentsession_agentstate.md) for a digital assistant.

## -enum-fields

### -field Working:3

The [ConversationalAgent](windows_applicationmodel_conversationalagent.md) is acting on the user's input.

### -field Speaking:4

The [ConversationalAgent](windows_applicationmodel_conversationalagent.md) is actively speaking to the user.

### -field ListeningAndSpeaking:5

The [ConversationalAgent](windows_applicationmodel_conversationalagent.md) is concurrently processing input and speaking to the user.

### -field Listening:2

The [ConversationalAgent](windows_applicationmodel_conversationalagent.md) is actively processing input.

### -field Inactive:0

The [ConversationalAgent](windows_applicationmodel_conversationalagent.md) is not actively processing input or speaking to the user.

### -field Detecting:1

The [ConversationalAgent](windows_applicationmodel_conversationalagent.md) is in 2nd stage keyword detection (1st stage is the *wake* utterance).

## -remarks

## -see-also

[AgentState](conversationalagentsession_agentstate.md)

## -examples
