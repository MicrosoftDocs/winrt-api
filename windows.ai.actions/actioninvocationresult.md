---
-api-id: T:Windows.AI.Actions.ActionInvocationResult
-api-type: winrt enum
---

# Windows.AI.Actions.ActionInvocationResult

<!--
public enum ActionInvocationResult
-->


## -description

Specifies the result state of an app action invocation.

## -enum-fields

### -field Success: 0

The app action invocation was successful.

### -field UserCanceled: 1

The app action invocation was cancelled by the user.

### -field Unsupported: 2

The app action was unsupported.

### -field Unavailable: 3

The app action was unavailable. For information on app action availability, see [Toggle availability of an App Action for Windows](/windows/ai/app-actions/actions-availability).

## -remarks

This enumeration is used by the [ActionInvocationContext.Result](actioninvocationcontext_result.md) property.

## -see-also

## -examples


