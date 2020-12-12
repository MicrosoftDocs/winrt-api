---
-api-id: M:Windows.ApplicationModel.Search.SearchPaneSuggestionsRequestDeferral.Complete
-api-type: winrt method
---

<!-- Method syntax
public void Complete()
-->

# Windows.ApplicationModel.Search.SearchPaneSuggestionsRequestDeferral.Complete

## -description

Signals that the app has finished populating a [SearchSuggestionCollection](searchsuggestioncollection.md) object while handling the [SuggestionsRequested](searchpane_suggestionsrequested.md) event.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/uwp/design/controls-and-patterns/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), [SearchContract](/uwp/api/windows.applicationmodel.search.searchcontract)) or SearchBox ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md)/[WinJS.UI.SearchBox](/previous-versions/windows/apps/dn301949(v=win.10))) APIs in apps for Windows 10.

## -examples

## -see-also

[SearchPaneSuggestionsRequest.GetDeferral method](searchpanesuggestionsrequest_getdeferral_254836512.md), [SearchPaneSuggestionsRequestDeferral class](searchpanesuggestionsrequestdeferral.md)