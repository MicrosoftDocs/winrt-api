---
-api-id: T:Windows.ApplicationModel.Search.SearchSuggestionCollection
-api-type: winrt class
---

<!-- Class syntax.
public class SearchSuggestionCollection : Windows.ApplicationModel.Search.ISearchSuggestionCollection
-->

# Windows.ApplicationModel.Search.SearchSuggestionCollection

## -description

Represents a collection of search suggestions to be displayed in the search pane in response to a [suggestionsrequested](searchpane_suggestionsrequested.md) event.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

The search pane can display 5 suggestions, at most. Additionally, each separator you use takes the place of a suggestion and lowers the number of suggestions that you can display.

An app retrieves this object through the [SearchPaneSuggestionsRequest.searchSuggestionCollection](searchpanesuggestionsrequest_searchsuggestioncollection.md) property while handling a [SuggestionsRequested](searchpane_suggestionsrequested.md) event.

## -examples

## -see-also

[Search contract sample (Windows 8)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample), [SearchPane.SuggestionsRequested event](searchpane_suggestionsrequested.md), [SearchPaneSuggestionsRequestedEventArgs class](searchpanesuggestionsrequestedeventargs.md), [SearchPaneSuggestionsRequestedEventArgs.Request property](searchpanesuggestionsrequestedeventargs_request.md), [SearchPaneSuggestionsRequest class](searchpanesuggestionsrequest.md), [SearchPaneSuggestionsRequest.SearchSuggestionCollection property](searchpanesuggestionsrequest_searchsuggestioncollection.md)
