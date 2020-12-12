---
-api-id: T:Windows.ApplicationModel.Search.SearchPaneVisibilityChangedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class SearchPaneVisibilityChangedEventArgs : Windows.ApplicationModel.Search.ISearchPaneVisibilityChangedEventArgs
-->

# Windows.ApplicationModel.Search.SearchPaneVisibilityChangedEventArgs

## -description

Provides data for a [VisibilityChanged](searchpane_visibilitychanged.md) event that is associated with a [searchPane](searchpane.md) object.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/uwp/design/controls-and-patterns/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), [SearchContract](/uwp/api/windows.applicationmodel.search.searchcontract)) or SearchBox ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md)/[WinJS.UI.SearchBox](/previous-versions/windows/apps/dn301949(v=win.10))) APIs in apps for Windows 10.

This object is passed to an app's [VisibilityChanged](searchpane_visibilitychanged.md) event handler.

## -examples

## -see-also

[SearchPane class](searchpane.md), [SearchPane.Show methods](searchpane_show_1323631364.md), [SearchPane.VisibilityChanged event](searchpane_visibilitychanged.md), [SearchPane.Visible property](searchpane_visible.md)