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
When a user launches your app normally (for example, by tapping the app tile), only the [OnLaunched](application_onlaunched.md) method is called. Override the [OnActivated](application_onactivated.md) method to perform any general app initialization that should occur only when the app is not launched normally (for example, from another app through the Search contract). You can determine how the app was activated through the [IActivatedEventArgs.Kind](../windows.applicationmodel.activation/iactivatedeventargs_kind.md) property.

For most kinds of activation, you can perform initialization specific to the activation type by overriding one of the following methods instead of the [OnActivated](application_onactivated.md) method:
+ [OnFileActivated](application_onfileactivated.md)
+ [OnSearchActivated](application_onsearchactivated.md)
+ [OnShareTargetActivated](application_onsharetargetactivated.md)
+ [OnFileOpenPickerActivated](application_onfileopenpickeractivated.md)
+ [OnFileSavePickerActivated](application_onfilesavepickeractivated.md)
+ [OnCachedFileUpdaterActivated](application_oncachedfileupdateractivated.md)


For more info, see [App lifecycle](http://msdn.microsoft.com/library/6c469e77-f1e3-4859-a27b-c326f9616d10).

## -examples

## -see-also
[Launching and resuming apps](XREF:TODO:nodepage.launching_and_resuming_apps__c__c___vb_)