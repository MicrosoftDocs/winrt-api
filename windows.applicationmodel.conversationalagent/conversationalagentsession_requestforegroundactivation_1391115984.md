---
-api-id: M:Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSession.RequestForegroundActivation
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public ConversationalAgentSessionUpdateResponse ConversationalAgentSession.RequestForegroundActivation()
-->

# Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSession.RequestForegroundActivation

## -description

Synchronously requests that the digital assistant be activated to the foreground.

> [!Important]
> To avoid possible concurrency issues, we recommend using [RequestForegroundActivationAsync](conversationalagentsession_requestforegroundactivationasync_303330599.md) instead.

## -returns

A [ConversationalAgentSessionUpdateResponse](conversationalagentsessionupdateresponse.md).

## -remarks

Use this method to provide some kind of UI response in your app. Digital assistant voice responses can be initiated from a background task.

## -see-also

[RequestForegroundActivationAsync](conversationalagentsession_requestforegroundactivationasync_303330599.md)

## -examples
