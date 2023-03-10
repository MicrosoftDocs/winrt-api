---
-api-id: T:Windows.ApplicationModel.Activation.SearchActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class SearchActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.IApplicationViewActivatedEventArgs, Windows.ApplicationModel.Activation.ISearchActivatedEventArgs, Windows.ApplicationModel.Activation.ISearchActivatedEventArgsWithLinguisticDetails, Windows.ApplicationModel.Activation.IViewSwitcherProvider
-->

# Windows.ApplicationModel.Activation.SearchActivatedEventArgs

## -description

Provides information about the activated event that fires when the user searches the app from the Search charm and the app isn't the main app on screen.

> **JavaScript**
> This type appears as [webUISearchActivatedEventArgs](../windows.ui.webui/webuisearchactivatedeventargs.md).

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

If your app integrates with the Search contract, a SearchActivatedEventArgs object is passed to your app's [OnSearchActivated](../windows.ui.xaml/application_onsearchactivated_1291367716.md) activation point handler when the user searches the app from the Search charm and your app is not the main app on screen. This type of activation is indicated by the [ActivationKind.Search](activationkind.md) value returned by the [Kind](searchactivatedeventargs_kind.md) property.

All [Application](../windows.ui.xaml/application.md) overrides involved in an activation scenario should call [Window.Activate](../windows.ui.xaml/window_activate_1797342875.md) in their implementations.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | User |

## -examples

## -see-also

[Call asynchronous APIs in C# or Visual Basic](/windows/uwp/threading-async/call-asynchronous-apis-in-csharp-or-visual-basic), [Application](../windows.ui.xaml/application.md), [Search contract sample (Windows 8)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample), [ActivationKind enumeration](activationkind.md), [Windows.ApplicationModel.Search namespace](../windows.applicationmodel.search/windows_applicationmodel_search.md), [Windows.ApplicationModel.Search.SearchPane class](../windows.applicationmodel.search/searchpane.md), [Windows.UI.WebUI.WebUIApplication.Activated event](../windows.ui.webui/webuiapplication_activated.md), [OnSearchActivated](../windows.ui.xaml/application_onsearchactivated_1291367716.md), [Windows.UI.Core.CoreApplicationView.Activated event](../windows.applicationmodel.core/coreapplicationview_activated.md)
