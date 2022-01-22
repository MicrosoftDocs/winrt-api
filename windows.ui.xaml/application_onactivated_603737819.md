---
-api-id: M:Windows.UI.Xaml.Application.OnActivated(Windows.ApplicationModel.Activation.IActivatedEventArgs)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnActivated(Windows.ApplicationModel.Activation.IActivatedEventArgs args)
-->

# Windows.UI.Xaml.Application.OnActivated

## -description
Invoked when the application is activated by some means other than normal launching.

## -parameters
### -param args
Event data for the event.

## -remarks
When a user launches your app normally (for example, by tapping the app tile), only the [OnLaunched](application_onlaunched_859642554.md) method is called. Override the OnActivated method to perform any general app initialization that should occur only when the app is not launched normally (for example, from another app through the Search contract). You can determine how the app was activated through the [IActivatedEventArgs.Kind](../windows.applicationmodel.activation/iactivatedeventargs_kind.md) property.

For most kinds of activation, you can perform initialization specific to the activation type by overriding one of the following methods instead of the OnActivated method:
+ [OnFileActivated](application_onfileactivated_2046716329.md)
+ [OnSearchActivated](application_onsearchactivated_1291367716.md)
+ [OnShareTargetActivated](application_onsharetargetactivated_169511293.md)
+ [OnFileOpenPickerActivated](application_onfileopenpickeractivated_101387531.md)
+ [OnFileSavePickerActivated](application_onfilesavepickeractivated_425940653.md)
+ [OnCachedFileUpdaterActivated](application_oncachedfileupdateractivated_383584449.md)


For more info, see [App lifecycle](/windows/uwp/launch-resume/app-lifecycle).

## -examples

## -see-also
[Launching and resuming apps](/windows/uwp/launch-resume/)
