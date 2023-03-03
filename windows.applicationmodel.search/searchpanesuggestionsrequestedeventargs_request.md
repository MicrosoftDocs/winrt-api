---
-api-id: P:Windows.ApplicationModel.Search.SearchPaneSuggestionsRequestedEventArgs.Request
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.Search.SearchPaneSuggestionsRequest Request { get; }
-->

# Windows.ApplicationModel.Search.SearchPaneSuggestionsRequestedEventArgs.Request

## -description

Gets an object that stores suggestions and information about the request.

## -property-value

The object that stores suggestions and information about the request.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

The search pane can display 5 suggestions, at most. Additionally, each separator you use takes the place of a suggestion and lowers the number of suggestions that you can display.

## -examples

## -see-also

[SearchPane.SuggestionsRequested event](searchpane_suggestionsrequested.md), [SearchPaneSuggestionsRequest class](searchpanesuggestionsrequest.md), [SearchPaneSuggestionsRequestedEventArgs class](searchpanesuggestionsrequestedeventargs.md)