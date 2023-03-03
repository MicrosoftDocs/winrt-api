---
-api-id: P:Windows.ApplicationModel.Search.ISearchPaneQueryChangedEventArgs.QueryText
-api-type: winrt property
---

<!-- Property syntax
public string QueryText { get; }
-->

# Windows.ApplicationModel.Search.ISearchPaneQueryChangedEventArgs.QueryText

## -description

The text in the search box when the [QueryChanged](searchpane_querychanged.md) event occurs.

## -property-value

The current query text.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

## -examples

## -see-also

[ISearchPaneQueryChangedEventArgs interface](isearchpanequerychangedeventargs.md), [SearchPane.QueryChanged event](searchpane_querychanged.md), [SearchPaneQueryChangedEventArgs class](searchpanequerychangedeventargs.md), [SearchPaneQueryChangedEventArgs.QueryText](searchpanequerychangedeventargs_querytext.md)