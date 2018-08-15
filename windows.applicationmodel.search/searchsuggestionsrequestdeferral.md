---
-api-id: T:Windows.ApplicationModel.Search.SearchSuggestionsRequestDeferral
-api-type: winrt class
---

<!-- Class syntax.
public class SearchSuggestionsRequestDeferral : Windows.ApplicationModel.Search.ISearchSuggestionsRequestDeferral
-->

# Windows.ApplicationModel.Search.SearchSuggestionsRequestDeferral

## -description
Enables the app to signal when it has finished populating a [SearchSuggestionCollection](searchsuggestioncollection.md) object while handling the [SuggestionsRequested](../windows.ui.xaml.controls/searchbox_suggestionsrequested.md) event. Use a deferral if and only if your app needs to respond to a request for suggestions asynchronously.

## -remarks
Your app should respond asynchronously to a request for suggestions if fulfilling the request will take a significant amount of time, such as fetching suggestions from a web service.

Use the [Complete](searchsuggestionsrequestdeferral_complete_1807836922.md) method to signal when your app has fulfilled the request. Retrieve this object by calling the [GetDeferral](searchsuggestionsrequest_getdeferral_254836512.md) method while handling the [SuggestionsRequested](../windows.ui.xaml.controls/searchbox_suggestionsrequested.md) event.

## -examples

## -see-also
