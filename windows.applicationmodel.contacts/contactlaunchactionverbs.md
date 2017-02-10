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
Use the [ContactLaunchActionVerbs](contactlaunchactionverbs.md) 's properties to determine the value of the "Verb" property when your app is activated with [ActivationKind.Contact](../windows.applicationmodel.activation/activationkind.md). These properties represent all possible string values of the "Verb" property. For example, the [ContactMapActivatedEventArgs.Verb](../windows.applicationmodel.activation/contactmapactivatedeventargs_verb.md) property is set to the value of [Map](contactlaunchactionverbs_map.md).

For info about how to handle app activation through contact actions, see [Quickstart: Handling contact actions ](http://msdn.microsoft.com/library/397d8b2a-6255-4f37-8556-449a3be2ef3f) and [Quickstart: Handling contact actions ](http://msdn.microsoft.com/library/61bacc8a-24c9-4b3d-b77b-e0822467700c).

## -examples

## -see-also
[Handling Contact Actions sample](http://go.microsoft.com/fwlink/p/?LinkID=320151)