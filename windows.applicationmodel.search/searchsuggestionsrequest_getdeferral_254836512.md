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

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

Your app should respond asynchronously to a request for search suggestions if fulfilling the request will take a significant amount of time, such as fetching suggestions from a web service.

Call the [Complete](searchsuggestionsrequestdeferral_complete_1807836922.md) method to signal when your app has fulfilled the request.

## -examples

## -see-also
