---
-api-id: P:Windows.ApplicationModel.Search.SearchPaneSuggestionsRequestedEventArgs.QueryText
-api-type: winrt property
---

<!-- Property syntax
public string QueryText { get; }
-->

# Windows.ApplicationModel.Search.SearchPaneSuggestionsRequestedEventArgs.QueryText

## -description

Gets the text that the app should provide suggestions for and that was in the search box when the [SuggestionsRequested](searchpane_suggestionsrequested.md) event occurred.

## -property-value

The query text that the app should provide suggestions for.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

Generally, this is the current text in the search box, but if the user types quickly or the app processes slowly, it may not be.

## -examples

## -see-also

[SearchPane.SuggestionsRequested event](searchpane_suggestionsrequested.md), [SearchPaneSuggestionsRequestedEventArgs class](searchpanesuggestionsrequestedeventargs.md)