---
-api-id: T:Windows.ApplicationModel.Activation.ContactPostActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class ContactPostActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IContactActivatedEventArgs, Windows.ApplicationModel.Activation.IContactPostActivatedEventArgs
-->

# Windows.ApplicationModel.Activation.ContactPostActivatedEventArgs

## -description
Provides data when an app is activated to post a contact.

> **JavaScript**
> This type appears as [WebUIContactPostActivatedEventArgs](../windows.ui.webui/webuicontactpostactivatedeventargs.md).

## -remarks
Windows 8.1 allows users to post to their contacts from the [Contact Card](../windows.applicationmodel.contacts/contactmanager_showcontactcard_1968125937.md) or Windows Search experience. By implementing the contact post activation contract, Windows can launch your app to post for the user.

To receive post activations, your app must register for the "windows.contact" extension category in its manifest. Under this extension, you must include a "LaunchAction" element with the "Verb" attribute equal to "post." You can then specify the "ServiceId" element to specify the domain name of the service that your app can post to, for example "facebook.com."

If multiple apps have registered for this contract, the user can choose one of them as their default for handling posting.

Here is an example for manifest registration.

```xml
<m2:Extension Category="windows.contact" xmlns:m2="http://schemas.microsoft.com/appx/2013/manifest">
  <m2:Contact>
    <m2:ContactLaunchActions>
      <m2:LaunchAction Verb="post" DesiredView="useLess">
        <m2:ServiceId>facebook.com</m2:ServiceId>
      </m2:LaunchAction>
    </m2:ContactLaunchActions>
  </m2:Contact>
</m2:Extension>
```

After you register in your manifest, your app can be activated for the contact post contract. When your app is activated, you can use the event information to identify the post activation and extract the parameters that help you complete the post scenario for the user.

## -examples
Here is an example of the code you need to handle contact post activations for Facebook Ids.

```csharp
protected override void OnActivated(IActivatedEventArgs args)
{
    if (args.Kind == ActivationKind.Contact)
    {
        var contactArgs = args as IContactActivatedEventArgs;
        if (contactArgs.Verb == Windows.ApplicationModel.Contacts.ContactLaunchActionVerbs.Post)
        {
            IContactPostActivatedEventArgs postArgs = contactArgs as IContactPostActivatedEventArgs;

            //get contact display info
            var contactName = postArgs.Contact.DisplayName;
            var contactThumbnail = postArgs.Contact.Thumbnail;

            if (postArgs.ServiceId == "facebook.com")
            {
                var userId = postArgs.ServiceUserId;
                //add posting logic for Facebook Ids
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
        if (contactArgs.Verb() == Windows::ApplicationModel::Contacts::ContactLaunchActionVerbs::Post())
        {
            auto postArgs{ contactArgs.as<Windows::ApplicationModel::Activation::ContactPostActivatedEventArgs>() };

            // Get contact display info.
            auto contactName{ postArgs.Contact().DisplayName() };
            auto contactThumbnail{ postArgs.Contact().Thumbnail() };

            if (postArgs.ServiceId() == L"facebook.com")
            {
                auto userId = postArgs.ServiceUserId();
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
        if (contactArgs->Verb == Windows::ApplicationModel::Contacts::ContactLaunchActionVerbs::Post)
        {
            auto postArgs = dynamic_cast<ContactPostActivatedEventArgs^>(contactArgs);

            //get contact display info
            auto contactName = postArgs->Contact->DisplayName;
            auto contactThumbnail = postArgs->Contact->Thumbnail;

            if (postArgs->ServiceId == "facebook.com")
            {
                auto userId = postArgs->ServiceUserId;
                //add posting logic for Facebook Ids
            }
        }
    }
}
```

## -see-also
[IContactPostActivatedEventArgs](icontactpostactivatedeventargs.md), [IContactActivatedEventArgs](icontactactivatedeventargs.md), [IActivatedEventArgs](iactivatedeventargs.md), [Handling Contact Actions sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Handling%20Contact%20Actions)
