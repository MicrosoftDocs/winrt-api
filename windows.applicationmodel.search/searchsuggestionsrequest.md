---
-api-id: T:Windows.ApplicationModel.Search.SearchSuggestionsRequest
-api-type: winrt class
---

<!-- Class syntax.
public class SearchSuggestionsRequest : Windows.ApplicationModel.Search.ISearchSuggestionsRequest
-->

# Windows.ApplicationModel.Search.SearchSuggestionsRequest

## -description

Stores suggestions and information about the request for suggestions.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

If your app provides its own suggestions to display in the search pane or in-app search box, use the [SearchSuggestionCollection](searchsuggestionsrequest_searchsuggestioncollection.md) property to add your app's suggestions to the collection of suggestions to display.

## -examples

## -see-also
