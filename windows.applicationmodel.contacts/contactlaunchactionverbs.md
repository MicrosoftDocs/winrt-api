---
-api-id: T:Windows.ApplicationModel.Contacts.ContactLaunchActionVerbs
-api-type: winrt class
---

<!-- Class syntax.
public class ContactLaunchActionVerbs 
-->

# Windows.ApplicationModel.Contacts.ContactLaunchActionVerbs

## -description
Provides data when an app is launched to perform an action to a contact.

## -remarks
Use the ContactLaunchActionVerbs's properties to determine the value of the "Verb" property when your app is activated with [ActivationKind.Contact](../windows.applicationmodel.activation/activationkind.md). These properties represent all possible string values of the "Verb" property. For example, the [ContactMapActivatedEventArgs.Verb](../windows.applicationmodel.activation/contactmapactivatedeventargs_verb.md) property is set to the value of [Map](contactlaunchactionverbs_map.md).

For info about how to handle app activation through contact actions, see [Quickstart: Handling contact actions ](/previous-versions/windows/apps/dn518236(v=win.10)).

## -examples

## -see-also
[Handling Contact Actions sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Handling%20Contact%20Actions)
## -capabilities
contactsSystem
