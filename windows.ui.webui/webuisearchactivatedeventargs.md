---
-api-id: T:Windows.UI.WebUI.WebUISearchActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class WebUISearchActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IApplicationViewActivatedEventArgs, Windows.ApplicationModel.Activation.ISearchActivatedEventArgs, Windows.ApplicationModel.Activation.ISearchActivatedEventArgsWithLinguisticDetails, Windows.UI.WebUI.IActivatedEventArgsDeferral
-->

# Windows.UI.WebUI.WebUISearchActivatedEventArgs

## -description
Provides information about the activated event that fires when the user searches the app from the Search charm and the app isn't the main app on screen.

> **C#/C++/VB**
> This type appears as [SearchActivatedEventArgs](../windows.applicationmodel.activation/searchactivatedeventargs.md).

## -remarks
> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

If your app integrates with the Search contract, a webUISearchActivatedEventArgs is passed to your app's [onactivated](/previous-versions/windows/apps/br212679(v=win.10)) event handler when the user searches the app from the Search charm and your app is not the main app on screen. This type of activation is indicated by the [activationKind.search](../windows.applicationmodel.activation/activationkind.md) value returned by the [kind](webuisearchactivatedeventargs_kind.md) property.

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx).

## -examples

## -see-also
[Search contract sample (Windows 8)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample)
