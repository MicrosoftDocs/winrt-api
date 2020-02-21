---
-api-id: M:Windows.ApplicationModel.UserActivities.UserActivity.SaveAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncAction UserActivity.SaveAsync()
-->

# Windows.ApplicationModel.UserActivities.UserActivity.SaveAsync


## -description

Publish the [UserActivity](useractivity.md).

## -returns

An asynchronous action that can be awaited.

## -remarks

**UserActivity.VisualElements.DisplayText** and **UserActivity.ActivationUri** must be set before calling **SaveAsync()** or the call will fail.

Saving a **UserActivity** converts its state to [UserActivityState.Published](useractivity_state.md)

## -see-also

## -examples

