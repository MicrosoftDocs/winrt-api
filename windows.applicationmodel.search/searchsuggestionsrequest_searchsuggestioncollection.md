---
-api-id: P:Windows.ApplicationModel.Search.SearchSuggestionsRequest.SearchSuggestionCollection
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.Search.SearchSuggestionCollection SearchSuggestionCollection { get; }
-->

# Windows.ApplicationModel.Search.SearchSuggestionsRequest.SearchSuggestionCollection

## -description

Gets the suggestions to display in the search pane or in-app search box for the current query. Apps provide suggestions to display by appending them to this [SearchSuggestionCollection](searchsuggestioncollection.md) object.

## -property-value

The suggestions to display. Apps provide suggestions by appending them to this [SearchSuggestionCollection](searchsuggestioncollection.md) object.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/uwp/design/controls-and-patterns/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), [SearchContract](/uwp/api/windows.applicationmodel.search.searchcontract)) or SearchBox ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md)/[WinJS.UI.SearchBox](/previous-versions/windows/apps/dn301949(v=win.10))) APIs in apps for Windows 10.

Use the [SearchSuggestionCollection](searchsuggestioncollection.md) object to append app-provided suggestions and search separators to display in the search pane or in-app search box.

When the request for suggestions is completed, either by returning from the [SuggestionsRequested](../windows.ui.xaml.controls/searchbox_suggestionsrequested.md) event handler or by calling [Complete](searchsuggestionsrequestdeferral_complete_1807836922.md), the search pane or in-app search box displays the suggestions in the [SearchSuggestionCollection](searchsuggestioncollection.md).

## -examples

## -see-also
