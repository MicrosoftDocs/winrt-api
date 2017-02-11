---
-api-id: T:Windows.UI.WebUI.WebUIContactPostActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class WebUIContactPostActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IContactActivatedEventArgs, Windows.ApplicationModel.Activation.IContactPostActivatedEventArgs, Windows.UI.WebUI.IActivatedEventArgsDeferral
-->

# Windows.UI.WebUI.WebUIContactPostActivatedEventArgs

## -description
Provides data when an app is activated to post a contact.

## -remarks
This object is accessed when you implement an event handler for the [WinJS.Application.Onactivated](http://msdn.microsoft.com/library/8b1cf913-a914-47d1-a690-bc3f0931e9d4) or the [Windows.UI.WebUI.WebUIApplication.activated](webuiapplication_activated.md) events when [ActivationKind](../windows.applicationmodel.activation/activationkind.md) is **contact**.



> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275).

Windows 8.1 allows users to post to their contacts from the [Contact Card](../windows.applicationmodel.contacts/contactmanager_showcontactcard.md) or Windows Search experience. By implementing the contact post activation contract, Windows can launch your app to post for the user.

To receive post activations, your app must register for the "windows.contact" extension category in its manifest. Under this extension, you must include a "LaunchAction" element with the "Verb" attribute equal to "post." You can then specify the "ServiceId" element to specify the domain name of the service that your app can post to, for example "facebook.com."

If multiple apps have registered for this contract, the user can choose one of them as their default for handling posting.



Here is an example for manifest registration:

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

Here is an example of the code you need to handle contact post activations for Facebook Ids:

## -examples
JavaScript

```javascript
function activated(eventObject) {
    if (eventObject.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.contact) {
        if (eventObject.detail.verb === Windows.ApplicationModel.Contacts.ContactLaunchActionVerbs.post) {

     //get contact display info
            var contactName = eventObject.detail.contact.displayName;
            var contactThumbnail = eventObject.detail.contact.thumbnail;

     if (eventObject.detail.serviceId === "facebook.com") {
                var userId = eventObject.detail.serviceUserId;
  //add posting logic for Facebook Ids
            }
        }
    }
}

```



## -see-also
[IContactPostActivatedEventArgs](../windows.applicationmodel.activation/icontactpostactivatedeventargs.md), [IContactActivatedEventArgs](../windows.applicationmodel.activation/icontactactivatedeventargs.md), [IActivatedEventArgs](../windows.applicationmodel.activation/iactivatedeventargs.md), [IActivatedEventArgsDeferral](iactivatedeventargsdeferral.md), [Handling Contact Actions sample](http://go.microsoft.com/fwlink/p/?LinkID=320151)