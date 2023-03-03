---
-api-id: P:Windows.ApplicationModel.Search.SearchSuggestionCollection.Size
-api-type: winrt property
---

<!-- Property syntax
public uint Size { get; }
-->

# Windows.ApplicationModel.Search.SearchSuggestionCollection.Size

## -description

The number of suggestions in the collection.

## -property-value

The number of suggestions.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

The search pane can display 5 suggestions, at most. Additionally, each separator you use takes the place of a suggestion and lowers the number of suggestions that you can display.

## -examples

## -see-also

[Search contract sample (Windows 8)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample), [SearchSuggestionCollection class](searchsuggestioncollection.md), [SearchPane.SuggestionsRequested event](searchpane_suggestionsrequested.md), [SearchPane.ResultSuggestionChosen event](searchpane_resultsuggestionchosen.md), [SearchPaneSuggestionsRequestedEventArgs class](searchpanesuggestionsrequestedeventargs.md), [SearchPaneSuggestionsRequestedEventArgs.Request property](searchpanesuggestionsrequestedeventargs_request.md), [SearchPaneSuggestionsRequest class](searchpanesuggestionsrequest.md), [SearchPaneSuggestionsRequest.SearchSuggestionCollection property](searchpanesuggestionsrequest_searchsuggestioncollection.md)
