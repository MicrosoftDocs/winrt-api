---
-api-id: T:Windows.ApplicationModel.Activation.ContactMapActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class ContactMapActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IContactActivatedEventArgs, Windows.ApplicationModel.Activation.IContactMapActivatedEventArgs
-->

# Windows.ApplicationModel.Activation.ContactMapActivatedEventArgs

## -description
Provides data when an app is activated to map a contact.

> **JavaScript**
> This type appears as [WebUIContactMapActivatedEventArgs](../windows.ui.webui/webuicontactmapactivatedeventargs.md).

## -remarks
Windows 8.1 allows users to map their contacts' locations from the [Contact Card](../windows.applicationmodel.contacts/contactmanager_showcontactcard_1968125937.md) or Windows Search experience. By implementing the contact map activation contract, Windows can launch your app to map locations for the user.

To receive map activations, your app must register for the "windows.contact" extension category in its manifest. Under this extension, you must include a "LaunchAction" element with the "Verb" attribute equal to "map."

If multiple apps have registered for this contract, the user can choose one of them as their default for handling mapping.

Here is an example for manifest registration.

```xml
<m2:Extension Category="windows.contact" xmlns:m2="http://schemas.microsoft.com/appx/2013/manifest">
  <m2:Contact>
    <m2:ContactLaunchActions>
      <m2:LaunchAction Verb="map" DesiredView="useHalf"/>
    </m2:ContactLaunchActions>
  </m2:Contact>
</m2:Extension>
```

After you register in your manifest, your app can be activated for the contact map contract. When your app is activated, you can use the event information to identify the map activation and extract the parameters that help you complete the mapping scenario for the user.

For info about how to handle app activation through contact actions, see [Quickstart: Handling contact actions ](/previous-versions/windows/apps/dn518236(v=win.10)).

## -examples
Here is an example of the code you need to handle contact map activations.

```csharp
protected override void OnActivated(IActivatedEventArgs args)
{
    if (args.Kind == ActivationKind.Contact)
    {
        var contactArgs = args as IContactActivatedEventArgs;
        if (contactArgs.Verb == Windows.ApplicationModel.Contacts.ContactLaunchActionVerbs.Map)
        {
            IContactMapActivatedEventArgs mapArgs = contactArgs as IContactMapActivatedEventArgs;

            //get contact display info
            var contactName = mapArgs.Contact.DisplayName;
            var contactThumbnail = mapArgs.Contact.Thumbnail;

            var address = mapArgs.address;
            //add mapping logic
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
        if (contactArgs.Verb() == Windows::ApplicationModel::Contacts::ContactLaunchActionVerbs::Map())
        {
            auto mapArgs{ contactArgs.as<Windows::ApplicationModel::Activation::ContactMapActivatedEventArgs>() };

            // Get contact display info.
            auto contactName{ mapArgs.Contact().DisplayName() };
            auto contactThumbnail{ mapArgs.Contact().Thumbnail() };

            auto address{ mapArgs.Address() };
            // Add mapping logic.
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
        if (contactArgs->Verb == Windows::ApplicationModel::Contacts::ContactLaunchActionVerbs::Map)
        {
            auto mapArgs = dynamic_cast<ContactMapActivatedEventArgs^>(contactArgs);

            //get contact display info
            auto contactName = mapArgs->Contact->DisplayName;
            auto contactThumbnail = mapArgs->Contact->Thumbnail;

            auto address = mapArgs->address;
            //add mapping logic
        }
    }
}
```

## -see-also
[IContactMapActivatedEventArgs](icontactmapactivatedeventargs.md), [IContactActivatedEventArgs](icontactactivatedeventargs.md), [IActivatedEventArgs](iactivatedeventargs.md), [Handling Contact Actions sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Handling%20Contact%20Actions)
