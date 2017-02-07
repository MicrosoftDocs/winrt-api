---
-api-id: M:Windows.ApplicationModel.Search.SearchPaneSuggestionsRequest.GetDeferral
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Search.SearchPaneSuggestionsRequestDeferral GetDeferral()
-->

# Windows.ApplicationModel.Search.SearchPaneSuggestionsRequest.GetDeferral

## -description
Retrieves an object that lets an app respond to a request for suggestions asynchronously.

## -returns
An object that lets an app signal when it has fulfilled the request for search suggestions.

## -remarks
Your app should respond asynchronously to a request for search suggestions if fulfilling the request will take a significant amount of time, such as fetching suggestions from a web service.

Use the [searchPaneSuggestionsRequestDeferral.complete](searchpanesuggestionsrequestdeferral_complete.md) method to signal when your app has fulfilled the request.

## -examples

## -see-also
[SearchPane.SuggestionsRequested event](searchpane_suggestionsrequested.md), [SearchPaneSuggestionsRequest class](searchpanesuggestionsrequest.md), [SearchPaneSuggestionsRequestedEventArgs class](searchpanesuggestionsrequestedeventargs.md), [SearchPaneSuggestionsRequestDeferral class](searchpanesuggestionsrequestdeferral.md), [SearchPaneSuggestionsRequestDeferral.Complete method](searchpanesuggestionsrequestdeferral_complete.md)