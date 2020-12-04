---
-api-id: T:Windows.ApplicationModel.Activation.ContactMessageActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class ContactMessageActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IContactActivatedEventArgs, Windows.ApplicationModel.Activation.IContactMessageActivatedEventArgs
-->

# Windows.ApplicationModel.Activation.ContactMessageActivatedEventArgs

## -description
Provides data when an app is activated to send a message to a contact.

> **JavaScript**
> This type appears as [WebUIContactMessageActivatedEventArgs](../windows.ui.webui/webuicontactmessageactivatedeventargs.md).

## -remarks
Windows 8.1 allows users to message their contacts from the [Contact Card](../windows.applicationmodel.contacts/contactmanager_showcontactcard_1968125937.md) or Windows Search experience. By implementing the contact message activation contract, Windows can launch your app to send messages for the user.

To receive message activations, your app must register for the "windows.contact" extension category in its manifest. Under this extension, you must include a "LaunchAction" element with the "Verb" attribute equal to "message." You can then specify the "ServiceId" element to specify the type of messaging you support. For example, if your app handles standard text messages, you can specify a "ServiceId" of "telephone." If your app handles messaging over a web based service, like Skype, you can specify the domain name of that service, for example "skype.com."

If multiple apps have registered for this contract, the user can choose one of them as their default for handling messages.

Here is an example for manifest registration.

```xml
<m2:Extension Category="windows.contact" xmlns:m2="http://schemas.microsoft.com/appx/2013/manifest">
  <m2:Contact>
    <m2:ContactLaunchActions>
      <m2:LaunchAction Verb="message" DesiredView="useLess">
        <m2:ServiceId>telephone</m2:ServiceId>
      </m2:LaunchAction>
      <m2:LaunchAction Verb="message" DesiredView="useLess">
        <m2:ServiceId>skype.com</m2:ServiceId>
      </m2:LaunchAction>
    </m2:ContactLaunchActions>
  </m2:Contact>
</m2:Extension>
```

After you register in your manifest, your app can be activated for the contact message contract. When your app is activated, you can use the event information to identify the message activation and extract the parameters that help you complete the messaging scenario for the user.

For info about how to handle app activation through contact actions, see [Quickstart: Handling contact actions ](/previous-versions/windows/apps/dn518236(v=win.10)).

## -examples
Here is an example of the code you need to handle contact message activations for PSTN numbers and Skype Ids.

```csharp
protected override void OnActivated(IActivatedEventArgs args)
{
    if (args.Kind == ActivationKind.Contact)
    {
        var contactArgs = args as IContactActivatedEventArgs;
        if (contactArgs.Verb == Windows.ApplicationModel.Contacts.ContactLaunchActionVerbs.Message)
        {
            IContactMessageActivatedEventArgs messageArgs = contactArgs as IContactMessageActivatedEventArgs;

            //get contact display info
            var contactName = messageArgs.Contact.DisplayName;
            var contactThumbnail = messageArgs.Contact.Thumbnail;

            if (messageArgs.ServiceId == "telephone")
            {
                var phoneNumber = messageArgs.ServiceUserId;
                //add messaging logic for PSTN numbers
            }
            else if (messageArgs.ServiceId == "skype.com")
            {
                var userId = messageArgs.ServiceUserId;
                //add messaging logic for Skype Ids
            }
        }
    }
}
```

```cppwinrt
void App::OnActivated(Windows::ApplicationModel::Activation::IActivatedEventArgs const& args)
{
    if (args.Kind() == Windows::ApplicationModel::Activation::ActivationKind::Contact)
    {
        auto contactArgs{ args.as<Windows::ApplicationModel::Activation::IContactActivatedEventArgs>() };
        if (contactArgs.Verb() == Windows::ApplicationModel::Contacts::ContactLaunchActionVerbs::Message())
        {
            auto messageArgs{ contactArgs.as<Windows::ApplicationModel::Activation::ContactMessageActivatedEventArgs>() };

            // Get contact display info.
            auto contactName{ messageArgs.Contact().DisplayName() };
            auto contactThumbnail{ messageArgs.Contact().Thumbnail() };

            if (messageArgs.ServiceId() == L"telephone")
            {
                auto phoneNumber = messageArgs.ServiceUserId();
                // Add messaging logic for PSTN numbers.
            }
            else if (messageArgs.ServiceId() == L"skype.com")
            {
                auto userId = messageArgs.ServiceUserId();
                // Add messaging logic for Skype Ids.
            }
        }
    }
}
```

```cppcx
void App::OnActivated(IActivatedEventArgs^ args)
{
    if (args->Kind == ActivationKind::Contact)
    {
        auto contactArgs = dynamic_cast<IContactActivatedEventArgs^>(args);
        if (contactArgs->Verb == Windows::ApplicationModel::Contacts::ContactLaunchActionVerbs::Message)
        {
            auto messageArgs = dynamic_cast<ContactMessageActivatedEventArgs^>(contactArgs);

            //get contact display info
            auto contactName = messageArgs->Contact->DisplayName;
            auto contactThumbnail = messageArgs->Contact->Thumbnail;

            if (messageArgs->ServiceId == "telephone")
            {
                auto phoneNumber = messageArgs->ServiceUserId;
                //add messaging logic for PSTN numbers
            }
            else if (messageArgs->ServiceId == "skype.com")
            {
                auto userId = messageArgs->ServiceUserId;
                //add messaging logic for Skype Ids
            }
        }
    }
}
```

## -see-also
[IContactMessageActivatedEventArgs](icontactmessageactivatedeventargs.md), [IContactActivatedEventArgs](icontactactivatedeventargs.md), [IActivatedEventArgs](iactivatedeventargs.md), [Handling Contact Actions sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Handling%20Contact%20Actions)
