---
-api-id: M:Windows.AI.Actions.ActionRuntime.GetActionAvailability(System.String)
-api-type: winrt method
---

# Windows.AI.Actions.ActionRuntime.GetActionAvailability(System.String)

<!--
public bool GetActionAvailability (string actionId);
-->


## -description

Gets a value indicating whether the specified entity is currently in the available state.

## -parameters

### -param actionId

The ID of the entity for which availability status is queried. The ID is dynamically assigned by the system when the entity is created, such as through one of the [ActionEntityFactory](actionentityfactory) entity creation methods.

## -returns

True if the action is currently available; otherwise, false.

## -remarks

For information on app action availability, see [Toggle availability of an App Action for Windows](/windows/ai/app-actions/action-availability).

## -see-also

## -examples


