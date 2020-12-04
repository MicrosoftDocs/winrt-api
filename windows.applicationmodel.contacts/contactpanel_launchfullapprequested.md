---
-api-id: E:Windows.ApplicationModel.Contacts.ContactPanel.LaunchFullAppRequested
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler LaunchFullAppRequested<ContactPanel, ContactPanelLaunchFullAppRequestedEventArgs>
-->

# Windows.ApplicationModel.Contacts.ContactPanel.LaunchFullAppRequested

## -description
Occurs when the user clicks the **Launch Full App** button in the Contact Panel.
## -remarks
Handle this event to provide your users with a smoother experience. For example, your app could handle this event to ensure that the full app continues playing a video that users start in the Contact Panel, or open a message that users started reading in the Contact Panel.

If you don’t handle this event, or if you handle this event, but you don’t set the [Handled](contactpanellaunchfullapprequestedeventargs_handled.md) property of the [ContactPanelLaunchFullAppRequestedEventArgs](contactpanellaunchfullapprequestedeventargs.md) property to true, your app starts in it’s default state.

## -see-also

## -examples

## -capabilities
contactsSystem
