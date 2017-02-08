---
-api-id: P:Windows.ApplicationModel.Activation.ContactMessageActivatedEventArgs.Verb
-api-type: winrt property
---

<!-- Property syntax
public string Verb { get; }
-->

# Windows.ApplicationModel.Activation.ContactMessageActivatedEventArgs.Verb

## -description
Gets the action to be performed.

## -property-value
The action to be performed.

## -remarks
Use the [Verb](contactmessageactivatedeventargs_verb.md) property to determine the action to perform when your app is activated with [ActivationKind.Contact](activationkind.md). For message activations, the [Verb](contactmessageactivatedeventargs_verb.md) property is set to the value of [Windows.ApplicationModel.Contacts.ContactLaunchActionVerbs.Message](../windows.applicationmodel.contacts/contactlaunchactionverbs_message.md).

For info about how to handle app activation through contact actions, see [Quickstart: Handling contact actions ](http://msdn.microsoft.com/library/397d8b2a-6255-4f37-8556-449a3be2ef3f) and [Quickstart: Handling contact actions ](http://msdn.microsoft.com/library/61bacc8a-24c9-4b3d-b77b-e0822467700c).

## -examples

## -see-also
[Handling Contact Actions sample](http://go.microsoft.com/fwlink/p/?LinkID=320151)