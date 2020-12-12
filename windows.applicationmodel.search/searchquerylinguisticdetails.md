---
-api-id: T:Windows.ApplicationModel.Search.SearchQueryLinguisticDetails
-api-type: winrt class
---

<!-- Class syntax.
public class SearchQueryLinguisticDetails : Windows.ApplicationModel.Search.ISearchQueryLinguisticDetails
-->

# Windows.ApplicationModel.Search.SearchQueryLinguisticDetails

## -description

Provides information about query text that the user enters through an Input Method Editor (IME).

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/uwp/design/controls-and-patterns/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), [SearchContract](/uwp/api/windows.applicationmodel.search.searchcontract)) or SearchBox ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md)/[WinJS.UI.SearchBox](/previous-versions/windows/apps/dn301949(v=win.10))) APIs in apps for Windows 10.

Get this object through the [LinguisticDetails](../windows.ui.xaml.controls/searchboxquerychangedeventargs_linguisticdetails.md) property while handling a [QueryChanged](../windows.ui.xaml.controls/searchbox_querychanged.md) event or through the [LinguisticDetails](../windows.ui.xaml.controls/searchboxsuggestionsrequestedeventargs_linguisticdetails.md) property while handling a [SuggestionsRequested](../windows.ui.xaml.controls/searchbox_suggestionsrequested.md) event.

## -examples

## -see-also
