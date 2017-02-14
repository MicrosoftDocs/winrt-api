---
-api-id: T:Windows.ApplicationModel.Search.SearchPaneSuggestionsRequestedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class SearchPaneSuggestionsRequestedEventArgs : Windows.ApplicationModel.Search.ISearchPaneQueryChangedEventArgs, Windows.ApplicationModel.Search.ISearchPaneSuggestionsRequestedEventArgs
-->

# Windows.ApplicationModel.Search.SearchPaneSuggestionsRequestedEventArgs

## -description
Provides data for a [suggestionsrequested](searchpane_suggestionsrequested.md) event that is associated with a [searchPane](searchpane.md) object.

## -remarks
This object is passed to an app's [suggestionsrequested](searchpane_suggestionsrequested.md) event handler.

### Use your app to provide suggestions

There are a few different ways you can get suggestions for your app to provide:

+ From an app-defined, static, local list
+ From a URL that supports suggestions in OpenSearch format
+ From a URL that supports suggestions in XML format
After you obtain suggestions, you must append them to the collection of suggestions to display for the user's query. Access this collection with the [searchPaneSuggestionsRequest.searchSuggestionCollection](searchpanesuggestionsrequest_searchsuggestioncollection.md) property.

> [!NOTE]
> If you want to provide result suggestions, you must also listen for and handle the [resultsuggestionchosen](searchpane_resultsuggestionchosen.md) event.

## -examples
The [Search contract sample](http://go.microsoft.com/fwlink/p/?linkid=234892) demonstrates how to respond to a [suggestionsrequested](searchpane_suggestionsrequested.md) event.

> [!NOTE]
> You can access information about the event from the [searchPaneSuggestionsRequestedEventArgs](searchpanesuggestionsrequestedeventargs.md) object that is passed to your [suggestionsrequested](searchpane_suggestionsrequested.md) handler.



[!code-csharp[all_suggestionsrequested_handler_linguisticdetails](../windows.applicationmodel.search/code/SearchContract/CS/Scenario3.xaml.cs#Snippetall_suggestionsrequested_handler_linguisticdetails)]

[!code-js[all_suggestionsrequested_handler_linguisticdetails](../windows.applicationmodel.search/code/SearchContract/js/js/scenario3.js#Snippetall_suggestionsrequested_handler_linguisticdetails)]

```csharp
searchPane.SuggestionsRequested += new TypedEventHandler<SearchPane, SearchPaneSuggestionsRequestedEventArgs>(OnSearchPaneSuggestionsRequested);
```



## -see-also
[Search contract sample](http://go.microsoft.com/fwlink/p/?linkid=234892), [Guidelines and checklist for search](http://msdn.microsoft.com/library/c328faa3-f6ae-4970-8372-b413f1290c39), [SearchPane class](searchpane.md), [SearchPane.ResultSuggestionChosen event](searchpane_resultsuggestionchosen.md), [SearchPane.SuggestionsRequested event](searchpane_suggestionsrequested.md), [SearchSuggestionCollection class](searchsuggestioncollection.md), [SearchPaneSuggestionsRequestedEventArgs class](searchpanesuggestionsrequestedeventargs.md), [SearchPaneSuggestionsRequest.SearchSuggestionCollection property](searchpanesuggestionsrequest_searchsuggestioncollection.md)
st_searchsuggestioncollection.md)
