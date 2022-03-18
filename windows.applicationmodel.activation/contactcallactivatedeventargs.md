---
-api-id: T:Windows.ApplicationModel.Activation.ContactCallActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class ContactCallActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IContactActivatedEventArgs, Windows.ApplicationModel.Activation.IContactCallActivatedEventArgs
-->

# Windows.ApplicationModel.Activation.ContactCallActivatedEventArgs

## -description
Provides data when an app is activated to call a contact.

> **JavaScript**
> This type appears as [WebUIContactCallActivatedEventArgs](../windows.ui.webui/webuicontactcallactivatedeventargs.md).

## -remarks
Windows 8.1 allows users to call their contacts from the [Contact Card](../windows.applicationmodel.contacts/contactmanager_showcontactcard_1968125937.md) or Windows Search experience. By implementing the contact call activation contract, Windows can launch your app to make calls for the user.

To receive call activations, your app must register for the "windows.contact" extension category in its manifest. Under this extension, you must include a "LaunchAction" element with the "Verb" attribute equal to "call." You can then specify the "ServiceId" element to specify the type of calling you support. For example, if your app handles standard PSTN calls, you can specify a "ServiceId" of "telephone." If your app handles calling over a web based service, like Skype, you can specify the domain name of that service, for example "skype.com."

If multiple apps have registered for this contract, the user can choose one of them as their default for handling calls.

> [!NOTE]
> To enable a user to set your app as their default calling app for PSTN numbers, your app must also support the “tel” URI scheme.

Here is an example for manifest registration.

```xml
<m2:Extension Category="windows.contact" xmlns:m2="http://schemas.microsoft.com/appx/2013/manifest">
  <m2:Contact>
    <m2:ContactLaunchActions>
      <m2:LaunchAction Verb="call" DesiredView="useLess">
        <m2:ServiceId>telephone</m2:ServiceId>
        <m2:ServiceId>skype.com</m2:ServiceId>
      </m2:LaunchAction>
    </m2:ContactLaunchActions>
  </m2:Contact>
</m2:Extension>
```

After you register in your manifest, your app can be activated for the contact call contract. When your app is activated, you can use the event information to identify the call activation and extract the parameters that help you complete the call for the user.

For info about how to handle app activation through contact actions, see [Quickstart: Handling contact actions ](/previous-versions/windows/apps/dn518236(v=win.10)).

## -examples
Here is an example of the code you need to handle contact call activations for PSTN numbers and Skype Ids.

```csharp
protected override void OnActivated(IActivatedEventArgs args)
{
    if (args.Kind == ActivationKind.Contact)
    {
        var contactArgs = args as IContactActivatedEventArgs;
        if (contactArgs.Verb == Windows.ApplicationModel.Contacts.ContactLaunchActionVerbs.Call)
        {
            IContactCallActivatedEventArgs callArgs = contactArgs as IContactCallActivatedEventArgs;

            //get contact display info
            var contactName = callArgs.Contact.DisplayName;
            var contactThumbnail = callArgs.Contact.Thumbnail;

            if (callArgs.ServiceId == "telephone")
            {
                var phoneNumber = callArgs.ServiceUserId;
                //add calling logic for PSTN numbers
            }
            else if (callArgs.ServiceId == "skype.com")
            {
                var userId = callArgs.ServiceUserId;
                //add calling logic for Skype Ids
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
        if (contactArgs.Verb() == Windows::ApplicationModel::Contacts::ContactLaunchActionVerbs::Call())
        {
            auto callArgs{ contactArgs.as<Windows::ApplicationModel::Activation::ContactCallActivatedEventArgs>() };

            // Get contact display info.
            auto contactName{ callArgs.Contact().DisplayName() };
            auto contactThumbnail{ callArgs.Contact().Thumbnail() };

            if (callArgs.ServiceId() == L"telephone")
            {
                auto phoneNumber{ callArgs.ServiceUserId() };
                // Add calling logic for PSTN numbers.
            }
            else if (callArgs.ServiceId() == L"skype.com")
            {
                auto userId{ callArgs.ServiceUserId() };
                // Add calling logic for Skype Ids.
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
        if (contactArgs->Verb == Windows::ApplicationModel::Contacts::ContactLaunchActionVerbs::Call)
        {
            auto callArgs = dynamic_cast<ContactCallActivatedEventArgs^>(contactArgs);

            //get contact display info
            auto contactName = callArgs->Contact->DisplayName;
            auto contactThumbnail = callArgs->Contact->Thumbnail;

            if (callArgs->ServiceId == "telephone")
            {
                auto phoneNumber = callArgs->ServiceUserId;
                //add calling logic for PSTN numbers
            }
            else if (callArgs->ServiceId == "skype.com")
            {
                auto userId = callArgs->ServiceUserId;
                //add calling logic for Skype Ids
            }
        }
    }
}
```

## -see-also
[IContactCallActivatedEventArgs](icontactcallactivatedeventargs.md), [IContactActivatedEventArgs](icontactactivatedeventargs.md), [IActivatedEventArgs](iactivatedeventargs.md), [Handling Contact Actions sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Handling%20Contact%20Actions)
