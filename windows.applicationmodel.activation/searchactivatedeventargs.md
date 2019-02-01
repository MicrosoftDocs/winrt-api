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
If your app integrates with the Search contract, a [SearchActivatedEventArgs](searchactivatedeventargs.md) object is passed to your app's [OnSearchActivated](../windows.ui.xaml/application_onsearchactivated_1291367716.md) activation point handler when the user searches the app from the Search charm and your app is not the main app on screen. This type of activation is indicated by the [ActivationKind.Search](activationkind.md) value returned by the [Kind](searchactivatedeventargs_kind.md) property.

Learn how to let users search with your app in [Quickstart: Adding search](https://msdn.microsoft.com/library/d412c562-22d2-41c4-9f27-27503b89b9e9). Learn about responding to other search-related events and customizing the search box and suggestions using the [SearchPane](../windows.applicationmodel.search/searchpane.md) class in the [Windows.ApplicationModel.Search](../windows.applicationmodel.search/windows_applicationmodel_search.md) namespace reference.

All [Application](../windows.ui.xaml/application.md) overrides involved in an activation scenario should call [Window.Activate](../windows.ui.xaml/window_activate_1797342875.md) in their implementations.

## -examples
The [Search contract sample](https://code.msdn.microsoft.com/windowsapps/Search-app-contract-sample-118a92f5) demonstrates how to respond to a **Search** activated event.

> [!NOTE]
> [Window.Activate](../windows.ui.xaml/window_activate_1797342875.md) is called in the `EnsureMainPageActivatedAsync` private method, not shown.

()

```csharp
async protected override void OnSearchActivated(SearchActivatedEventArgs args)
{
    await EnsureMainPageActivatedAsync(args);
    if (args.QueryText == "")
    {
        // Navigate to landing page.
    }
    else
    {
        // Display search results.
        MainPage.Current.ProcessQueryText(args.QueryText);
    }
}
```



## -see-also
[Quickstart: Adding search](https://msdn.microsoft.com/library/d412c562-22d2-41c4-9f27-27503b89b9e9), [Call asynchronous APIs in C# or Visual Basic](https://msdn.microsoft.com/library/066711e0-d5c4-467e-8683-3cc64edbcc83), [Application](../windows.ui.xaml/application.md), [OnSearchActivated](../windows.ui.xaml/application_onsearchactivated_1291367716.md), [Search contract sample](https://code.msdn.microsoft.com/windowsapps/Search-app-contract-sample-118a92f5), [ActivationKind enumeration](activationkind.md), [Windows.ApplicationModel.Search namespace](../windows.applicationmodel.search/windows_applicationmodel_search.md), [Windows.ApplicationModel.Search.SearchPane class](../windows.applicationmodel.search/searchpane.md), [Windows.UI.WebUI.WebUIApplication.Activated event](../windows.ui.webui/webuiapplication_activated.md), [OnSearchActivated](../windows.ui.xaml/application_onsearchactivated_1291367716.md), [Windows.UI.Core.CoreApplicationView.Activated event](../windows.applicationmodel.core/coreapplicationview_activated.md)
