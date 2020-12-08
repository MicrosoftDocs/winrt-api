---
-api-id: T:Windows.ApplicationModel.Search.SearchPaneQuerySubmittedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class SearchPaneQuerySubmittedEventArgs : Windows.ApplicationModel.Search.ISearchPaneQuerySubmittedEventArgs, Windows.ApplicationModel.Search.ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails
-->

# Windows.ApplicationModel.Search.SearchPaneQuerySubmittedEventArgs

## -description

Provides data for a [QuerySubmitted](searchpane_querysubmitted.md) event that is associated with a [SearchPane](searchpane.md) instance.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/uwp/design/controls-and-patterns/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), [SearchContract](/uwp/api/windows.applicationmodel.search.searchcontract)) or SearchBox ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md)/[WinJS.UI.SearchBox](/previous-versions/windows/apps/dn301949(v=win.10))) APIs in apps for Windows 10.

This object is passed to an app's [QuerySubmitted](searchpane_querysubmitted.md) event handler.

## -examples

## -see-also

[SearchPane.QuerySubmitted event](searchpane_querysubmitted.md), [SearchPaneQuerySubmittedEventArgs class](searchpanequerysubmittedeventargs.md)
