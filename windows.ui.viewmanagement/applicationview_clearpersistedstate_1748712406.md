---
-api-id: M:Windows.UI.ViewManagement.ApplicationView.ClearPersistedState(System.String)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public void ApplicationView.ClearPersistedState(String key)
-->

# Windows.UI.ViewManagement.ApplicationView.ClearPersistedState

## -description

Clears any properties the system has saved for the view with the specified identifier for the given application.

## -parameters
### -param key

The [PersistedStateId](applicationview_persistedstateid.md) for the view to be cleared.

## -remarks

If a view with this identifier still exists in the app at the time of calling this method, the system will save state for this identifier when that view is updated or closed.

## -see-also

## -examples

