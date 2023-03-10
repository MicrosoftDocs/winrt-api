---
-api-id: P:Windows.ApplicationModel.Search.SearchPaneQuerySubmittedEventArgs.QueryText
-api-type: winrt property
---

<!-- Property syntax
public string QueryText { get; }
-->

# Windows.ApplicationModel.Search.SearchPaneQuerySubmittedEventArgs.QueryText

## -description

Gets the text that was submitted through the search pane.

## -property-value

The submitted query text.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

## -examples

## -see-also

[SearchPane.QuerySubmitted event](searchpane_querysubmitted.md), [SearchPaneQuerySubmittedEventArgs class](searchpanequerysubmittedeventargs.md)