---
-api-id: M:Windows.UI.WindowManagement.AppWindow.ClearPersistedState(System.String)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public void AppWindow.ClearPersistedState(String key)
-->

# Windows.UI.WindowManagement.AppWindow.ClearPersistedState

## -description

Clears any properties the system has saved for the window with the specified ID for the given application.

## -parameters
### -param key

The [PersistedStateId](appwindow_persistedstateid.md) for the view to be cleared.

## -remarks

If a view with this ID still exists in the app at the time of calling this method, the system will save state for this ID when that view is updated or closed.

## -see-also

[PersistedStateId](appwindow_persistedstateid.md), [ClearAllPersistedState](appwindow_clearallpersistedstate_2029617983.md)

## -examples
