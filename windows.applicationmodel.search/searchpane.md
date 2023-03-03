---
-api-id: T:Windows.ApplicationModel.Search.SearchPane
-api-type: winrt class
---

<!-- Class syntax.
public class SearchPane : Windows.ApplicationModel.Search.ISearchPane
-->

# Windows.ApplicationModel.Search.SearchPane

## -description

Deprecated. Use the [Windows.UI.Xaml.Controls.AutoSuggestBox](../windows.ui.xaml.controls/autosuggestbox.md) control instead. Represents and manages the search pane that opens when a user activates the Search charm.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md)/[WinJS.UI.SearchBox](/previous-versions/windows/apps/dn301949(v=win.10))) and the SearchPane. Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

This object is available to apps that participate in the Search contract. In order to provide users with search results, you must add code to your Activated event handler that responds when your app is activated for search. To learn more about responding to [Search](../windows.applicationmodel.activation/activationkind.md) activation events, see [webUISearchActivatedEventArgs](../windows.ui.webui/webuisearchactivatedeventargs.md) (JavaScript) or [SearchActivatedEventArgs](../windows.applicationmodel.activation/searchactivatedeventargs.md) (C#/C++/VB).

You can see code examples that demonstrate how to respond to search events and manage the search pane in the [Search contract sample (Windows 8)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample).

## -examples

## -see-also

[Search contract sample (Windows 8)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample), [Handle app activation](/windows/uwp/launch-resume/activate-an-app), [SearchPane.GetForCurrentView method](searchpane_getforcurrentview_1363600702.md), [Windows.ApplicationModel.Activation.ActivationKind enum](../windows.applicationmodel.activation/activationkind.md), [Windows.ApplicationModel.Activation.SearchActivatedEventArgs class](../windows.applicationmodel.activation/searchactivatedeventargs.md), [Windows.ApplicationModel.Core.CoreApplicationView.Activated event](../windows.applicationmodel.core/coreapplicationview_activated.md)
