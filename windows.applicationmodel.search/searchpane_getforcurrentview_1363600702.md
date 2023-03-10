---
-api-id: M:Windows.ApplicationModel.Search.SearchPane.GetForCurrentView
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Search.SearchPane GetForCurrentView()
-->

# Windows.ApplicationModel.Search.SearchPane.GetForCurrentView

## -description
Retrieves an instance of the search pane from which users can search within the app.

## -returns
An instance of the search pane, which provides a consistent, touch-friendly search box and optional search suggestions for searching within the current application.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md)/[WinJS.UI.SearchBox](/previous-versions/windows/apps/dn301949(v=win.10))) and the SearchPane. Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

## -examples

## -see-also
[SearchPane class](searchpane.md)