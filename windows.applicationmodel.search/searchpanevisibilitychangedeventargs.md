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
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

This object is passed to an app's [VisibilityChanged](searchpane_visibilitychanged.md) event handler.

## -examples

## -see-also

[SearchPane class](searchpane.md), [SearchPane.Show methods](searchpane_show_1323631364.md), [SearchPane.VisibilityChanged event](searchpane_visibilitychanged.md), [SearchPane.Visible property](searchpane_visible.md)