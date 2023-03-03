---
-api-id: P:Windows.ApplicationModel.Search.SearchQueryLinguisticDetails.QueryTextAlternatives
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<string> QueryTextAlternatives { get; }
-->

# Windows.ApplicationModel.Search.SearchQueryLinguisticDetails.QueryTextAlternatives

## -description

Gets a list of the text alternatives for the current query text. These alternatives account for uncomposed text the user is entering in an IME.

## -property-value

A list of the text alternatives for the query text.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

## -examples

## -see-also
