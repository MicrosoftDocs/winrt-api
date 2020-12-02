---
-api-id: M:Windows.ApplicationModel.Contacts.ContactCardDelayedDataLoader.SetData(Windows.ApplicationModel.Contacts.Contact)
-api-type: winrt method
---

<!-- Method syntax
public void SetData(Windows.ApplicationModel.Contacts.Contact contact)
-->

# Windows.ApplicationModel.Contacts.ContactCardDelayedDataLoader.SetData

## -description
Updates the contact card with the [Contact](contact.md) object and completes the contact card UI.

## -parameters
### -param contact
The contact to update the contact card with.

## -remarks
> [!NOTE]
> The contact card will time out within four seconds after [ShowDelayLoadedContactCard](contactmanager_showdelayloadedcontactcard_1685487355.md) returns. So, if SetData isn't called within this four second interval, the contact card UI becomes final, and no more updates can be applied. You can call SetData only once and before you call [Close](contactcarddelayeddataloader_close_811482585.md). If you call SetData twice or after [Close](contactcarddelayeddataloader_close_811482585.md), SetData fails with an exception; the **HRESULT** error code is **HRESULT_FROM_WIN32(ERROR_INVALID_STATE)**.

For info about how to manage contacts, see [Contacts and calendar](/windows/uwp/contacts-and-calendar/).

## -examples

## -see-also
[Contact manager API sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Contact%20manager%20API%20sample)
## -capabilities
contactsSystem
