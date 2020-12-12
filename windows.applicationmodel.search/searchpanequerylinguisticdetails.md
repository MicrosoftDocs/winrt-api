---
-api-id: T:Windows.ApplicationModel.Search.SearchPaneQueryLinguisticDetails
-api-type: winrt class
---

<!-- Class syntax.
public class SearchPaneQueryLinguisticDetails : Windows.ApplicationModel.Search.ISearchPaneQueryLinguisticDetails
-->

# Windows.ApplicationModel.Search.SearchPaneQueryLinguisticDetails

## -description

Provides information about query text that the user enters through an Input Method Editor (IME).

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/uwp/design/controls-and-patterns/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), [SearchContract](/uwp/api/windows.applicationmodel.search.searchcontract)) or SearchBox ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md)/[WinJS.UI.SearchBox](/previous-versions/windows/apps/dn301949(v=win.10))) APIs in apps for Windows 10.

An app retrieves this object through the [searchPaneQueryChangedEventArgs.LinguisticDetails](searchpanequerychangedeventargs_linguisticdetails.md) property while handling a [QueryChanged](searchpane_querychanged.md) event or through the [SearchPaneSuggestionsRequestedEventArgs.LinguisticDetails](searchpanesuggestionsrequestedeventargs_linguisticdetails.md) property while handling a [SuggestionsRequested](searchpane_suggestionsrequested.md) event.

## -examples

## -see-also

[Search contract sample (Windows 8)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample), [SearchPane.QueryChanged event](searchpane_querychanged.md), [SearchPaneQueryChangedEventArgs class](searchpanequerychangedeventargs.md), [SearchPaneQueryChangedEventArgs.LinguisticDetails property](searchpanequerychangedeventargs_linguisticdetails.md), [SearchPane.SuggestionsRequested event](searchpane_suggestionsrequested.md), [SearchPaneSuggestionsRequestedEventArgs class](searchpanesuggestionsrequestedeventargs.md), [SearchPaneSuggestionsRequestedEventArgs.LinguisticDetails property](searchpanesuggestionsrequestedeventargs_linguisticdetails.md)
