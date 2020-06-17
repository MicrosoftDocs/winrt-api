---
-api-id: T:Windows.ApplicationModel.Search.SearchPaneSuggestionsRequestDeferral
-api-type: winrt class
---

<!-- Class syntax.
public class SearchPaneSuggestionsRequestDeferral : Windows.ApplicationModel.Search.ISearchPaneSuggestionsRequestDeferral
-->

# Windows.ApplicationModel.Search.SearchPaneSuggestionsRequestDeferral

## -description
Enables the app to signal when it has finished populating a [searchSuggestionCollection](searchsuggestioncollection.md) object while handling the [suggestionsrequested](searchpane_suggestionsrequested.md) event. Apps should use a deferral if and only if they need to respond to a request for suggestions asynchronously.

## -remarks
Your app should respond asynchronously to a request for suggestions if fulfilling the request will take a significant amount of time, such as fetching suggestions from a web service.

Use the [searchPaneSuggestionsRequestDeferral.complete](searchpanesuggestionsrequestdeferral_complete_1807836922.md) method to signal when your app has fulfilled the request.

An app retrieves this object by calling the [searchPaneSuggestionsRequest.getDeferral](searchpanesuggestionsrequest_getdeferral_254836512.md) method while handling the [suggestionsrequested](searchpane_suggestionsrequested.md) event.

## -examples
The [Search contract sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample) demonstrates how to respond to a [suggestionsrequested](searchpane_suggestionsrequested.md) event, including how to get a deferral.



[!code-csharp[all_suggestionsrequested_handler_deferral](../windows.applicationmodel.search/code/SearchContract/CS/Scenario6.xaml.cs#Snippetall_suggestionsrequested_handler_deferral)]

[!code-js[all_suggestionsrequested_handler_deferral](../windows.applicationmodel.search/code/SearchContract/js/js/scenario6.js#Snippetall_suggestionsrequested_handler_deferral)]

## -see-also
[SearchPane class](searchpane.md), [SearchPane.SuggestionsRequested event](searchpane_suggestionsrequested.md), [SearchPaneSuggestionsRequest class](searchpanesuggestionsrequest.md), [SearchPaneSuggestionsRequest.GetDeferral method](searchpanesuggestionsrequest_getdeferral_254836512.md), [SearchPaneSuggestionsRequestedEventArgs class](searchpanesuggestionsrequestedeventargs.md)
suggestionsrequestedeventargs.md)
