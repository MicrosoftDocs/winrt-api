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
> The contact card will time out within four seconds after [ShowDelayLoadedContactCard](contactmanager_showdelayloadedcontactcard_1685487355.md) returns. So, if [SetData](contactcarddelayeddataloader_setdata_1176099425.md) isn't called within this four second interval, the contact card UI becomes final, and no more updates can be applied. You can call [SetData](contactcarddelayeddataloader_setdata_1176099425.md) only once and before you call [Close](contactcarddelayeddataloader_close_811482585.md). If you call [SetData](contactcarddelayeddataloader_setdata_1176099425.md) twice or after [Close](contactcarddelayeddataloader_close_811482585.md), [SetData](contactcarddelayeddataloader_setdata_1176099425.md) fails with an exception; the **HRESULT** error code is **HRESULT_FROM_WIN32(ERROR_INVALID_STATE)**.

For info about how to manage contacts, see [Managing contact cards ](http://msdn.microsoft.com/library/a0667d13-a274-4cb2-982a-5bfabb0488c2) and [Managing contact cards ](http://msdn.microsoft.com/library/364d763b-adf6-410e-a892-ba4af3799b93).

## -examples

## -see-also
[Contact manager API sample](http://go.microsoft.com/fwlink/p/?LinkID=310079)
## -capabilities
contactsSystem
