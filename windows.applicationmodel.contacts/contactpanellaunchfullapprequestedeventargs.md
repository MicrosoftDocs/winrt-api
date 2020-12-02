---
-api-id: T:Windows.ApplicationModel.Contacts.ContactPanelLaunchFullAppRequestedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class ContactPanelLaunchFullAppRequestedEventArgs
-->

# Windows.ApplicationModel.Contacts.ContactPanelLaunchFullAppRequestedEventArgs

## -description

Provides event information for the [LaunchFullAppRequested](contactpanel_launchfullapprequested.md) event.

## -remarks

First, check to see the [Handled](contactpanellaunchfullapprequestedeventargs_handled.md) property is `false`. Then, set the [Handled](contactpanellaunchfullapprequestedeventargs_handled.md) property to `true`, and start your app. Depending on what sort of experience you want to provide your users, consider closing the Contact Panel because they’ll be interacting directly with the full version of your app.

## -see-also

## -examples

The following example illustrates the remarks in this topic.

```csharp
async void OnLaunchFullAppRequested(ContactPanel ContactPanel,
                                    ContactPanelLaunchFullAppRequestedEventArgs e)
{
    if (!e.Handled)
    {
        e.Handled = true;
        if (await TryLaunchFullAppFromCurrentStateAsync())
        {
            // we've successfully started the full version of our app; close the hosted view.
            ContactPanel.ClosePanel();
        }
    }
}

```

## -capabilities

contactsSystem
