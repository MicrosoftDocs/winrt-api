---
-api-id: M:Windows.UI.Xaml.Controls.Frame.GetNavigationState
-api-type: winrt method
---

<!-- Method syntax
public string GetNavigationState()
-->

# Windows.UI.Xaml.Controls.Frame.GetNavigationState

## -description
Serializes the [Frame](frame.md) navigation history into a string.

## -returns
The string-form serialized navigation history. See Remarks.

## -remarks
This method is useful to restore the navigation state of your app after it has been suspended and resumed. When your app is suspended, call [GetNavigationState](frame_getnavigationstate.md) and save the return value. When your app is resumed, call [SetNavigationState](frame_setnavigationstate.md) and pass it the saved value.

Calling this method will call [Page.OnNavigatedFrom](page_onnavigatedfrom.md) for the current page using **NavigationMode.Forward**. [GetNavigationState](frame_getnavigationstate.md) is usually called when the application is being suspended, so the current page is navigated away from.



> [!NOTE]
> The serialization format used by these methods is for internal use only. Your app should not form any dependencies on it. Additionally, this format supports serialization only for basic types like string, char, numeric and GUID types.

## -examples

## -see-also
[SetNavigationState](frame_setnavigationstate.md)