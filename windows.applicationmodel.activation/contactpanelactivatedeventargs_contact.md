---
-api-id: P:Windows.ApplicationModel.Activation.ContactPanelActivatedEventArgs.Contact
-api-type: winrt property
---

<!-- Property syntax.
public Contact Contact { get; }
-->

# Windows.ApplicationModel.Activation.ContactPanelActivatedEventArgs.Contact

## -description

Gets the selected contact from the Contact Panel.

## -property-value

The selected contact. 

## -remarks
The selected contact will be an empty contact with only its Id property set.  You must use this Id to re-retrieve the contact from the ContactStore in order to get access to the rest of the contact's property data.

## -see-also

## -examples
```cs
protected async override void OnActivated(IActivatedEventArgs args)
{
    if (args.Kind == ActivationKind.ContactPanel)
    {
        // At this point, ContactPanelActivatedEventArgs.Contact
        // is an empty Contact.  Only its Id property is set.
        ContactPanelActivatedEventArgs panelArgs = (ContactPanelActivatedEventArgs)args;

        // To get access to all of the Contact's property data, you must
        // use the Id to re-retrieve the Contact from the ContactStore.
        ContactStore store = await ContactManager.RequestStoreAsync(ContactStoreAccessType.AppContactsReadWrite);
        Contact contact = await store.GetContactAsync(panelArgs.Contact.Id);

        // Now you have a fully populated Contact to work with.
    }
}
```
