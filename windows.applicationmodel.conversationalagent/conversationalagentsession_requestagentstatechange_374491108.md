---
-api-id: M:Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSession.RequestAgentStateChange(Windows.ApplicationModel.ConversationalAgent.ConversationalAgentState)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public ConversationalAgentSessionUpdateResponse ConversationalAgentSession.RequestAgentStateChange(ConversationalAgentState state)
-->

# Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSession.RequestAgentStateChange

## -description

Synchronously requests a state change for the current [ConversationalAgentSession](conversationalagentsession.md).

> [!Important]
> To avoid possible concurrency issues, we recommend using [RequestAgentStateChangeAsync](conversationalagentsession_requestagentstatechangeasync_1892921766.md) instead.

## -parameters

### -param state

The [AgentState](conversationalagentsession_agentstate.md) requested.

## -returns

A [ConversationalAgentSessionUpdateResponse](conversationalagentsessionupdateresponse.md).

## -remarks

## -see-also

[RequestAgentStateChangeAsync](conversationalagentsession_requestagentstatechangeasync_1892921766.md)

## -examples
