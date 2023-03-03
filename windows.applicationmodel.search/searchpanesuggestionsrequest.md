---
-api-id: T:Windows.ApplicationModel.Search.SearchPaneSuggestionsRequest
-api-type: winrt class
---

<!-- Class syntax.
public class SearchPaneSuggestionsRequest : Windows.ApplicationModel.Search.ISearchPaneSuggestionsRequest
-->

# Windows.ApplicationModel.Search.SearchPaneSuggestionsRequest

## -description

Stores suggestions and information about the request for suggestions.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

If your app provides its own suggestions to display in the search pane, use the [SearchPaneSuggestionsRequest.SearchSuggestionCollection](searchpanesuggestionsrequest_searchsuggestioncollection.md) property to add your app's suggestions to the collection of suggestions to display.

The search pane can display 5 suggestions, at most. Additionally, each separator you use takes the place of a suggestion and lowers the number of suggestions that you can display.

## -examples

## -see-also

[Search contract sample (Windows 8)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample), [SearchPane.SuggestionsRequested event](searchpane_suggestionsrequested.md), [SearchPaneSuggestionsRequestedEventArgs class](searchpanesuggestionsrequestedeventargs.md), [SearchPaneSuggestionsRequestedEventArgs.Request property](searchpanesuggestionsrequestedeventargs_request.md)
