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
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

Get this object through the [LinguisticDetails](../windows.ui.xaml.controls/searchboxquerychangedeventargs_linguisticdetails.md) property while handling a [QueryChanged](../windows.ui.xaml.controls/searchbox_querychanged.md) event or through the [LinguisticDetails](../windows.ui.xaml.controls/searchboxsuggestionsrequestedeventargs_linguisticdetails.md) property while handling a [SuggestionsRequested](../windows.ui.xaml.controls/searchbox_suggestionsrequested.md) event.

## -examples

## -see-also
