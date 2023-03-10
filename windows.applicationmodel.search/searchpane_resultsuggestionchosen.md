---
-api-id: E:Windows.ApplicationModel.Search.SearchPane.ResultSuggestionChosen
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ResultSuggestionChosen<Windows.ApplicationModel.Search.SearchPane,  Windows.ApplicationModel.Search.SearchPaneResultSuggestionChosenEventArgs>
-->

# Windows.ApplicationModel.Search.SearchPane.ResultSuggestionChosen

## -description

Fires when the user selects one of the suggested results that was provided by the app and displayed in the search pane.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md)/[WinJS.UI.SearchBox](/previous-versions/windows/apps/dn301949(v=win.10))) and the SearchPane. Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

If your app participates in the Search contract and displays suggestions for possible results in the search pane, you should register an event handler to respond when this event fires. In your ResultSuggestionChosen event handler, respond by getting the [SearchPaneResultSuggestionChosenEventArgs](searchpaneresultsuggestionchoseneventargs.md).[Tag](searchpaneresultsuggestionchoseneventargs_tag.md) of the chosen result and using it to take the user to the result in your app UI.

> [!NOTE]
> If you want to display result suggestions, you must also listen for and handle the [SuggestionsRequested](searchpane_suggestionsrequested.md) event.

## -examples

## -see-also

[Search contract sample (Windows 8)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample), [Object class](/dotnet/api/system.object?view=dotnet-uwp-10.0&preserve-view=true), [SearchPane class](searchpane.md), [SearchPane.SuggestionsRequested event](searchpane_suggestionsrequested.md), [SearchPaneResultSuggestionChosenEventArgs class](searchpaneresultsuggestionchoseneventargs.md)
