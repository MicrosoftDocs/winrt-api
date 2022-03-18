---
-api-id: T:Windows.ApplicationModel.Activation.ContactVideoCallActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class ContactVideoCallActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IContactActivatedEventArgs, Windows.ApplicationModel.Activation.IContactVideoCallActivatedEventArgs
-->

# Windows.ApplicationModel.Activation.ContactVideoCallActivatedEventArgs

## -description
Provides data when an app is activated to video call a contact.

> **JavaScript**
> This type appears as [WebUIContactVideoCallActivatedEventArgs](../windows.ui.webui/webuicontactvideocallactivatedeventargs.md).

## -remarks
Windows 8.1 allows users to video call their contacts from the [Contact Card](../windows.applicationmodel.contacts/contactmanager_showcontactcard_1968125937.md) or Windows Search experience. By implementing the contact video call activation contract, Windows can launch your app to make video calls for the user.

To receive video call activations, your app must register for the "windows.contact" extension category in its manifest. Under this extension, you must include a "LaunchAction" element with the "Verb" attribute equal to "videoCall." You can then specify the "ServiceId" element to specify the domain name of the service that your app can video call over, for example "skype.com."

If multiple apps have registered for this contract, the user can choose one of them as their default for handling video calls.

Here is an example for manifest registration.

```xml
<m2:Extension Category="windows.contact" xmlns:m2="http://schemas.microsoft.com/appx/2013/manifest">
  <m2:Contact>
    <m2:ContactLaunchActions>
      <m2:LaunchAction Verb="videoCall" DesiredView="useHalf">
        <m2:ServiceId>skype.com</m2:ServiceId>
      </m2:LaunchAction>
    </m2:ContactLaunchActions>
  </m2:Contact>
</m2:Extension>
```

After you register in your manifest, your app can be activated for the contact video call contract. When your app is activated, you can use the event information to identify the video call activation and extract the parameters that help you complete the video call for the user.

## -examples
Here is an example of the code you need to handle contact video call activations for Skype Ids.

```csharp
protected override void OnActivated(IActivatedEventArgs args)
{
    if (args.Kind == ActivationKind.Contact)
    {
        var contactArgs = args as IContactActivatedEventArgs;
        if (contactArgs.Verb == Windows.ApplicationModel.Contacts.ContactLaunchActionVerbs.VideoCall)
        {
            IContactVideoCallActivatedEventArgs videoCallArgs = contactArgs as IContactVideoCallActivatedEventArgs;

            //get contact display info
            var contactName = videoCallArgs.Contact.DisplayName;
            var contactThumbnail = videoCallArgs.Contact.Thumbnail;

            if (videoCallArgs.ServiceId == "skype.com")
            {
                var userId = videoCallArgs.ServiceUserId;
                //add video calling logic for Skype Ids
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
        if (contactArgs.Verb() == Windows::ApplicationModel::Contacts::ContactLaunchActionVerbs::VideoCall())
        {
            auto videoCallArgs{ contactArgs.as<Windows::ApplicationModel::Activation::ContactVideoCallActivatedEventArgs>() };

            // Get contact display info.
            auto contactName{ videoCallArgs.Contact().DisplayName() };
            auto contactThumbnail{ videoCallArgs.Contact().Thumbnail() };

            if (videoCallArgs.ServiceId() == L"skype.com")
            {
                auto userId = videoCallArgs.ServiceUserId();
                //add messaging logic for Skype Ids
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
        if (contactArgs->Verb == Windows::ApplicationModel::Contacts::ContactLaunchActionVerbs::VideoCall)
        {
            auto videoCallArgs = dynamic_cast<ContactVideoCallActivatedEventArgs^>(contactArgs);

            //get contact display info
            auto contactName = videoCallArgs->Contact->DisplayName;
            auto contactThumbnail = videoCallArgs->Contact->Thumbnail;

            if (videoCallArgs->ServiceId == "skype.com")
            {
                auto userId = videoCallArgs->ServiceUserId;
                //add video calling logic for Skype Ids
            }
        }
    }
}
```

## -see-also
[IContactVideoCallActivatedEventArgs](icontactvideocallactivatedeventargs.md), [IContactActivatedEventArgs](icontactactivatedeventargs.md), [IActivatedEventArgs](iactivatedeventargs.md), [Handling Contact Actions sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Handling%20Contact%20Actions)
