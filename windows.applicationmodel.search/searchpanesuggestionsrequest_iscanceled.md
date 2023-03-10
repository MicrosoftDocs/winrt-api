---
-api-id: P:Windows.ApplicationModel.Search.SearchPaneSuggestionsRequest.IsCanceled
-api-type: winrt property
---

<!-- Property syntax
public bool IsCanceled { get; }
-->

# Windows.ApplicationModel.Search.SearchPaneSuggestionsRequest.IsCanceled

## -description

Indicates whether the request for suggestions to display is canceled.

## -property-value

`true` if the request was canceled; otherwise, `false`. The default is `false`.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

A request for search pane suggestions is valid if it is still tied to the most recent [suggestionsrequested](searchpane_suggestionsrequested.md) event; that is, if the user has not changed the search query.

## -examples

## -see-also

[SearchPane.SuggestionsRequested event](searchpane_suggestionsrequested.md), [SearchPaneSuggestionsRequest class](searchpanesuggestionsrequest.md), [SearchPaneSuggestionsRequestedEventArgs class](searchpanesuggestionsrequestedeventargs.md)