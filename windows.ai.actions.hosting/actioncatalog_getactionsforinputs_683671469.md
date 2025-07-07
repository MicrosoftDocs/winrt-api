---
-api-id: M:Windows.AI.Actions.Hosting.ActionCatalog.GetActionsForInputs(Windows.AI.Actions.ActionEntity[],Windows.UI.WindowId)
-api-type: winrt method
---

# Windows.AI.Actions.Hosting.ActionCatalog.GetActionsForInputs(Windows.AI.Actions.ActionEntity[],Windows.UI.WindowId)

<!--
public Windows.AI.Actions.Hosting.ActionInstance[] GetActionsForInputs (Windows.AI.Actions.ActionEntity[] inputEntities, Windows.UI.WindowId invokerWindowId);
-->


## -description

Gets an array of action instances for all actions registered with the system that accept the specified list of input entities. This overload also accepts the [WindowId](/uwp/api/windows.ui.windowid) associated with the invoker of the action.

## -parameters

### -param inputEntities

A list of [ActionEntity](../windows.ai.actions/actionentity.md) objects specifying the input entities for which actions are retrieved.

### -param invokerWindowId

A **WindowId** object specifying the window that invokes the app action.

## -returns

An array of [ActionInstance](actioninstance.md) objects that provide the details and the invocation context of an app action as well as the ability to invoke the action.

## -remarks

## -see-also

## -examples


