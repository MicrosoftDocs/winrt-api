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
This method is useful to restore the navigation state of your app after it has been suspended and resumed. When your app is suspended, call GetNavigationState and save the return value. When your app is resumed, call [SetNavigationState](/uwp/api/windows.ui.xaml.controls.frame.setnavigationstate) and pass it the saved value.

Calling this method will call [Page.OnNavigatedFrom](page_onnavigatedfrom_1389759661.md) for the current page using **NavigationMode.Forward**. GetNavigationState is usually called when the application is being suspended, so the current page is navigated away from.



> [!NOTE]
> The serialization format used by these methods is for internal use only. Your app should not form any dependencies on it. Additionally, this format supports serialization only for basic types like string, char, numeric and [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) types.

## -examples

## -see-also
[SetNavigationState](/uwp/api/windows.ui.xaml.controls.frame.setnavigationstate)
