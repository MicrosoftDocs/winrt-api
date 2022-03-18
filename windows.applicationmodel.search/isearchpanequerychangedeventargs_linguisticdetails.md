---
-api-id: P:Windows.ApplicationModel.Search.ISearchPaneQueryChangedEventArgs.LinguisticDetails
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.Search.SearchPaneQueryLinguisticDetails LinguisticDetails { get; }
-->

# Windows.ApplicationModel.Search.ISearchPaneQueryChangedEventArgs.LinguisticDetails

## -description

An object that provides information about query text that the user is entering through an Input Method Editor (IME).

## -property-value

An object that provides information about query text.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/uwp/design/controls-and-patterns/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), [SearchContract](/uwp/api/windows.applicationmodel.search.searchcontract)) or SearchBox ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md)/[WinJS.UI.SearchBox](/previous-versions/windows/apps/dn301949(v=win.10))) APIs in apps for Windows 10.

## -examples

## -see-also

[ISearchPaneQueryChangedEventArgs interface](isearchpanequerychangedeventargs.md), [SearchPane.QueryChanged event](searchpane_querychanged.md), [SearchPaneQueryChangedEventArgs class](searchpanequerychangedeventargs.md), [SearchPaneQueryChangedEventArgs.LinguisticDetails property](searchpanequerychangedeventargs_linguisticdetails.md), [SearchPaneQueryLinguisticDetails class](searchpanequerylinguisticdetails.md)