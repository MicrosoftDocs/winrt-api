---
-api-id: T:Windows.ApplicationModel.Search.SearchPaneSuggestionsRequestDeferral
-api-type: winrt class
---

<!-- Class syntax.
public class SearchPaneSuggestionsRequestDeferral : Windows.ApplicationModel.Search.ISearchPaneSuggestionsRequestDeferral
-->

# Windows.ApplicationModel.Search.SearchPaneSuggestionsRequestDeferral

## -description

Enables the app to signal when it has finished populating a [SearchSuggestionCollection](searchsuggestioncollection.md) object while handling the [SuggestionsRequested](searchpane_suggestionsrequested.md) event. Apps should use a deferral if and only if they need to respond to a request for suggestions asynchronously.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

Your app should respond asynchronously to a request for suggestions if fulfilling the request will take a significant amount of time, such as fetching suggestions from a web service.

Use the [SearchPaneSuggestionsRequestDeferral.Complete](searchpanesuggestionsrequestdeferral_complete_1807836922.md) method to signal when your app has fulfilled the request.

An app retrieves this object by calling the [SearchPaneSuggestionsRequest.GetDeferral](searchpanesuggestionsrequest_getdeferral_254836512.md) method while handling the [SuggestionsRequested](searchpane_suggestionsrequested.md) event.

## -examples

## -see-also

[SearchPane class](searchpane.md), [SearchPane.SuggestionsRequested event](searchpane_suggestionsrequested.md), [SearchPaneSuggestionsRequest class](searchpanesuggestionsrequest.md), [SearchPaneSuggestionsRequest.GetDeferral method](searchpanesuggestionsrequest_getdeferral_254836512.md), [SearchPaneSuggestionsRequestedEventArgs class](searchpanesuggestionsrequestedeventargs.md)
suggestionsrequestedeventargs.md)
