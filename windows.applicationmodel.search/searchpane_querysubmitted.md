---
-api-id: E:Windows.ApplicationModel.Search.SearchPane.QuerySubmitted
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler QuerySubmitted<Windows.ApplicationModel.Search.SearchPane,  Windows.ApplicationModel.Search.SearchPaneQuerySubmittedEventArgs>
-->

# Windows.ApplicationModel.Search.SearchPane.QuerySubmitted

## -description

Fires when the user submits the text in the search box and the app needs to display search results.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md)/[WinJS.UI.SearchBox](/previous-versions/windows/apps/dn301949(v=win.10))) and the SearchPane. Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

If your app participates in the Search contract, register an event handler to respond when this event fires. In your QuerySubmitted event handler, respond by taking the user to your search results page and populating it with results based on the [SearchPaneQuerySubmittedEventArgs](searchpanequerysubmittedeventargs.md).[QueryText](searchpanequerysubmittedeventargs_querytext.md).

## -examples

## -see-also

[Search contract sample (Windows 8)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample), [SearchPane class](searchpane.md), [SearchPane.QueryChanged event](searchpane_querychanged.md), [SearchPaneQuerySubmittedEventArgs class](searchpanequerysubmittedeventargs.md)
