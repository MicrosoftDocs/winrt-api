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
> To implement search in an app for Windows 10, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/uwp/design/controls-and-patterns/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), [SearchContract](/uwp/api/windows.applicationmodel.search.searchcontract)) or SearchBox ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md)/[WinJS.UI.SearchBox](/previous-versions/windows/apps/dn301949(v=win.10))) APIs in apps for Windows 10.

Generally, this is the current text in the search box, but if the user types quickly or the app processes slowly, it may not be.

## -examples

## -see-also

[SearchPane.SuggestionsRequested event](searchpane_suggestionsrequested.md), [SearchPaneSuggestionsRequestedEventArgs class](searchpanesuggestionsrequestedeventargs.md)