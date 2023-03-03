---
-api-id: P:Windows.ApplicationModel.Search.ISearchPaneQueryChangedEventArgs.Language
-api-type: winrt property
---

<!-- Property syntax
public string Language { get; }
-->

# Windows.ApplicationModel.Search.ISearchPaneQueryChangedEventArgs.Language

## -description

The Internet Engineering Task Force (IETF) language tag (BCP 47 standard) that identifies the language currently associated with the user's text input device.

## -property-value

The Internet Engineering Task Force (IETF) BCP 47 standard language tag.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

## -examples

## -see-also

[ISearchPaneQueryChangedEventArgs interface](isearchpanequerychangedeventargs.md), [SearchPane.QueryChanged event](searchpane_querychanged.md), [SearchPaneQueryChangedEventArgs class](searchpanequerychangedeventargs.md), [SearchPaneQueryChangedEventArgs.Language property](searchpanequerychangedeventargs_language.md)