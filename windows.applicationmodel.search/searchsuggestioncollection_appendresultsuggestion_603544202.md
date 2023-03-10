---
-api-id: M:Windows.ApplicationModel.Search.SearchSuggestionCollection.AppendResultSuggestion(System.String,System.String,System.String,Windows.Storage.Streams.IRandomAccessStreamReference,System.String)
-api-type: winrt method
---

<!-- Method syntax
public void AppendResultSuggestion(System.String text, System.String detailText, System.String tag, Windows.Storage.Streams.IRandomAccessStreamReference image, System.String imageAlternateText)
-->

# Windows.ApplicationModel.Search.SearchSuggestionCollection.AppendResultSuggestion

## -description

Appends a suggested search result to the list of suggestions to display in the search pane.

## -parameters

### -param text

The text of the suggested result.

### -param detailText

The detail text for the suggested result.

### -param tag

The unique tag that identifies this suggested result.

If this suggested result is selected by the user, a [ResultSuggestionChosen](searchpane_resultsuggestionchosen.md) event occurs. When the app handles this event, it can get the tag of the chosen result suggestion from the [SearchPaneResultSuggestionChosenEventArgs.Tag](searchpaneresultsuggestionchoseneventargs_tag.md) property.

### -param image

The image to accompany the results suggestion. The image should be 40 x 40. Windows will scale or crop smaller or larger images.

### -param imageAlternateText

The alternate text for the image.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

You should use result suggestions instead of query suggestions only to display high-confidence results that take the user directly to the item instead of to a view that shows search results.

Suggested results include an image and optional detail text to display with the suggestion in the search pane. The image signals to the user that they are seeing results and not query suggestions. If an image for the result doesn't exist, you can use a generic image or icon that represents the result or result type.

You must listen for and handle the [ResultSuggestionChosen](searchpane_resultsuggestionchosen.md) event if you want to provide result suggestions.

The search pane can display 5 suggestions, at most. Additionally, each separator you use takes the place of a suggestion and lowers the number of suggestions that you can display.
## -examples

## -see-also
[Search contract sample (Windows 8)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample), [SearchSuggestionCollection class](searchsuggestioncollection.md), [SearchPane.SuggestionsRequested event](searchpane_suggestionsrequested.md), [SearchPane.ResultSuggestionChosen event](searchpane_resultsuggestionchosen.md), [SearchPaneSuggestionsRequestedEventArgs class](searchpanesuggestionsrequestedeventargs.md), [SearchPaneSuggestionsRequestedEventArgs.Request property](searchpanesuggestionsrequestedeventargs_request.md), [SearchPaneSuggestionsRequest class](searchpanesuggestionsrequest.md), [SearchPaneSuggestionsRequest.SearchSuggestionCollection property](searchpanesuggestionsrequest_searchsuggestioncollection.md)
