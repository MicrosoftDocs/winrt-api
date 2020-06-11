---
-api-id: M:Windows.UI.Xaml.Application.OnCachedFileUpdaterActivated(Windows.ApplicationModel.Activation.CachedFileUpdaterActivatedEventArgs)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnCachedFileUpdaterActivated(Windows.ApplicationModel.Activation.CachedFileUpdaterActivatedEventArgs args)
-->

# Windows.UI.Xaml.Application.OnCachedFileUpdaterActivated

## -description
Invoked when the application is activated due to an activation contract with [ActivationKind](../windows.applicationmodel.activation/activationkind.md) as **CachedFileUpdater**.

## -parameters
### -param args
Event data for the event.

## -remarks
[OnFileOpenPickerActivated](application_onfileopenpickeractivated_101387531.md) is a pre-defined activation point handler that is invoked for a core [Activated](../windows.ui.core/corewindow_activated.md) event when the [ActivationKind](../windows.applicationmodel.activation/activationkind.md) is **CachedFileUpdater**. The default template app.xaml code-behind files always include an override for [OnLaunched](application_onlaunched_859642554.md), but defining overrides for other activation points such as OnCachedFileUpdaterActivated is up to your app code.

All [Application](application.md) overrides involved in an activation scenario should call [Window.Activate](window_activate_1797342875.md) in their implementations.

For example code that overrides [OnFileOpenPickerActivated](application_onfileopenpickeractivated_101387531.md), see [File picker contracts sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/File%20picker%20contracts%20sample).

## -examples

## -see-also
[CachedFileUpdaterActivatedEventArgs](../windows.applicationmodel.activation/cachedfileupdateractivatedeventargs.md), [File picker contracts sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/File%20picker%20contracts%20sample)
