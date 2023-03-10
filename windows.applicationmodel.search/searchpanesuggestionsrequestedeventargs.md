---
-api-id: T:Windows.ApplicationModel.Search.SearchPaneSuggestionsRequestedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class SearchPaneSuggestionsRequestedEventArgs : Windows.ApplicationModel.Search.ISearchPaneQueryChangedEventArgs, Windows.ApplicationModel.Search.ISearchPaneSuggestionsRequestedEventArgs
-->

# Windows.ApplicationModel.Search.SearchPaneSuggestionsRequestedEventArgs

## -description

Provides data for a [SuggestionsRequested](searchpane_suggestionsrequested.md) event that is associated with a [SearchPane](searchpane.md) object.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

This object is passed to an app's [SuggestionsRequested](searchpane_suggestionsrequested.md) event handler.

### Use your app to provide suggestions

There are a few different ways you can get suggestions for your app to provide:

+ From an app-defined, static, local list
+ From a URL that supports suggestions in OpenSearch format
+ From a URL that supports suggestions in XML format
After you obtain suggestions, you must append them to the collection of suggestions to display for the user's query. Access this collection with the [searchPaneSuggestionsRequest.searchSuggestionCollection](searchpanesuggestionsrequest_searchsuggestioncollection.md) property.

> [!NOTE]
> If you want to provide result suggestions, you must also listen for and handle the [ResultSuggestionChosen](searchpane_resultsuggestionchosen.md) event.

## -examples

## -see-also

[Search contract sample (Windows 8)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample), [SearchPane class](searchpane.md), [SearchPane.ResultSuggestionChosen event](searchpane_resultsuggestionchosen.md), [SearchPane.SuggestionsRequested event](searchpane_suggestionsrequested.md), [SearchSuggestionCollection class](searchsuggestioncollection.md), [SearchPaneSuggestionsRequestedEventArgs class, [SearchPaneSuggestionsRequest.SearchSuggestionCollection property](searchpanesuggestionsrequest_searchsuggestioncollection.md)
