---
-api-id: M:Windows.AI.Actions.ActionRuntime.CreateInvocationContextWithWindowId(System.String,Windows.UI.WindowId)
-api-type: winrt method
---

# Windows.AI.Actions.ActionRuntime.CreateInvocationContextWithWindowId(System.String,Windows.UI.WindowId)

<!--
public Windows.AI.Actions.ActionInvocationContext CreateInvocationContextWithWindowId (string actionId, Windows.UI.WindowId invokerWindowId);
-->


## -description

Creates an [ActionInvocationContext](actioninvocationcontext.md) object associated with the specified action and window ID.

## -parameters

### -param actionId

The ID of the app action for which the invocation context is created. The action ID is declared in the Action definition JSON file. For more information, see [Action definition JSON schema for App Actions on Windows](/windows/ai/app-actions/actions-json).

### -param invokerWindowId

A [WindowId](/uwp/api/windows.ui.windowid) object specifying the window that invoked the app action.

## -returns

A new **ActionInvocationContext** object.

## -remarks

## -see-also

## -examples


