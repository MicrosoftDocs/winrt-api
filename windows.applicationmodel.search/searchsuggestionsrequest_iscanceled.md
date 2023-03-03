---
-api-id: P:Windows.ApplicationModel.Search.SearchSuggestionsRequest.IsCanceled
-api-type: winrt property
---

<!-- Property syntax
public bool IsCanceled { get; }
-->

# Windows.ApplicationModel.Search.SearchSuggestionsRequest.IsCanceled

## -description

Indicates whether the request for suggestions to display is canceled.

## -property-value

`true` if the request was canceled; otherwise, `false`. The default is `false`.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

A request for search pane or in-app search box suggestions is valid if it's still tied to the most recent [SuggestionsRequested](../windows.ui.xaml.controls/searchbox_suggestionsrequested.md) event, which means that the user hasn't changed the search query.

## -examples

## -see-also
