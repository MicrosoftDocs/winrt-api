---
-api-id: T:Windows.ApplicationModel.ConversationalAgent.ConversationalAgentActivationResult
-api-type: winrt enum
---

# Windows.ApplicationModel.ConversationalAgent.ConversationalAgentActivationResult

<!--
public enum ConversationalAgentActivationResult
-->

## -description

Specifies the supported agent activation request result values.

## -enum-fields

### -field Success: 0

Activation was successful.

### -field AgentInactive: 1

Activation failed because the agent requesting the activation was not in dialog. For example, [ConversationalAgentState](conversationalagentstate.md) was inactive.

### -field ScreenNotAvailable: 2

Activation failed because the display is not accessible. For example when the laptop lid is closed.

### -field AgentInterrupted: 3

Activation failed because the agent was interrupted.

## -remarks

## -see-also

[ConversationalAgentSession.RequestActivation(Windows.ApplicationModel.ConversationalAgent.ConversationalAgentActivationKind)](conversationalagentsession_requestactivation_1263117550.md), [ConversationalAgentSession.RequestActivationAsync(Windows.ApplicationModel.ConversationalAgent.ConversationalAgentActivationKind)](conversationalagentsession_requestactivationasync_2043020377.md)

## -examples
