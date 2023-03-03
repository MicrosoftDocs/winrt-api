---
-api-id: P:Windows.ApplicationModel.Search.SearchPaneQueryLinguisticDetails.QueryTextCompositionStart
-api-type: winrt property
---

<!-- Property syntax
public uint QueryTextCompositionStart { get; }
-->

# Windows.ApplicationModel.Search.SearchPaneQueryLinguisticDetails.QueryTextCompositionStart

## -description

Gets the starting location of the text that the user is composing with an Input Method Editor (IME).

## -property-value

The starting location of the query text that the user is composing with an Input Method Editor (IME).

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

## -examples

## -see-also

[SearchPaneQueryLinguisticDetails class](searchpanequerylinguisticdetails.md), [SearchPane.QueryChanged event](searchpane_querychanged.md), [SearchPaneQueryChangedEventArgs class](searchpanequerychangedeventargs.md), [SearchPaneQueryChangedEventArgs.LinguisticDetails property](searchpanequerychangedeventargs_linguisticdetails.md), [SearchPane.SuggestionsRequested event](searchpane_suggestionsrequested.md), [SearchPaneSuggestionsRequestedEventArgs class](searchpanesuggestionsrequestedeventargs.md), [SearchPaneSuggestionsRequestedEventArgs.LinguisticDetails property](searchpanesuggestionsrequestedeventargs_linguisticdetails.md)
