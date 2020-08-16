---
-api-id: P:Windows.ApplicationModel.Activation.ContactMapActivatedEventArgs.Verb
-api-type: winrt property
---

<!-- Property syntax
public string Verb { get; }
-->

# Windows.ApplicationModel.Activation.ContactMapActivatedEventArgs.Verb

## -description
Gets the action to be performed.

## -property-value
The action to be performed.

## -remarks
Use the Verb property to determine the action to perform when your app is activated with [ActivationKind.Contact](activationkind.md). For map activations, the Verb property is set to the value of [Windows.ApplicationModel.Contacts.ContactLaunchActionVerbs.Map](../windows.applicationmodel.contacts/contactlaunchactionverbs_map.md).

For info about how to handle app activation through contact actions, see [Quickstart: Handling contact actions ](https://docs.microsoft.com/previous-versions/windows/apps/dn518236(v=win.10)) and [Quickstart: Handling contact actions ](https://docs.microsoft.com/previous-versions/windows/apps/dn518338(v=win.10)).

## -examples

## -see-also
[Handling Contact Actions sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Handling%20Contact%20Actions)
