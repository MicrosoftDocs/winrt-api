---
-api-id: E:Windows.ApplicationModel.Background.BackgroundTaskRegistrationGroup.BackgroundActivated
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler BackgroundActivated<BackgroundTaskRegistrationGroup, BackgroundActivatedEventArgs>
-->

# Windows.ApplicationModel.Background.BackgroundTaskRegistrationGroup.BackgroundActivated

## -description
This event is fired when a background task that belongs to a group starts.

## -remarks
Background triggers associated with a group fire this event instead of having a task entry point. For single-process background tasks that don't define an entry point in their background task registration, this event is the entry point. Instead of calling the application's [OnBackgroundActivated](../windows.ui.xaml/application_onbackgroundactivated_431338129.md) method, the event attached to the group is called.

## -see-also
[Launching, resuming, and background tasks](/windows/uwp/launch-resume/index)

## -examples
[Background activation sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BackgroundActivation) See scenario 6 for a grouped task example.
