---
-api-id: M:Windows.ApplicationModel.Search.SearchSuggestionsRequest.GetDeferral
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Search.SearchSuggestionsRequestDeferral GetDeferral()
-->

# Windows.ApplicationModel.Search.SearchSuggestionsRequest.GetDeferral

## -description
Gets an object that lets an app respond to a request for suggestions asynchronously.

## -returns
An object that lets an app signal when it has fulfilled the request for search suggestions.

## -remarks
Your app should respond asynchronously to a request for search suggestions if fulfilling the request will take a significant amount of time, such as fetching suggestions from a web service.

Call the [Complete](searchsuggestionsrequestdeferral_complete_1807836922.md) method to signal when your app has fulfilled the request.

## -examples

## -see-also
