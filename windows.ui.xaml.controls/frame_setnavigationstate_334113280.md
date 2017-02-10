---
-api-id: M:Windows.UI.Xaml.Controls.Frame.SetNavigationState(System.String)
-api-type: winrt method
---

<!-- Method syntax
public void SetNavigationState(System.String navigationState)
-->

# Windows.UI.Xaml.Controls.Frame.SetNavigationState

## -description
Reads and restores the navigation history of a [Frame](frame.md) from a provided serialization string.

## -parameters
### -param navigationState
The serialization string that supplies the restore point for navigation history.

## -remarks
This method is useful to restore the navigation state of your app after it has been suspended and resumed. When your app is suspended, call [GetNavigationState](frame_getnavigationstate.md) and save the return value. When your app is resumed, call [SetNavigationState](frame_setnavigationstate.md) and pass it the saved value.

Calling [SetNavigationState](frame_setnavigationstate.md) will call [Page.OnNavigatedTo](page_onnavigatedto.md) for the current page, with **NavigationMode.Back**. [SetNavigationState](frame_setnavigationstate.md) is usually called when the application is being resumed, so the current page is navigated to.

## -examples

## -see-also
