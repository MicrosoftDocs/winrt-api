---
-api-id: T:Windows.ApplicationModel.Contacts.ContactStoreAccessType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Contacts.ContactStoreAccessType : int
-->

# ContactStoreAccessType

## -description
Defines the type of access the app has to the [ContactStore](contactstore.md).

## -enum-fields
### -field AppContactsReadWrite:0
Read and write contacts that belong to the app only.

### -field AllContactsReadOnly:1
Read access to all contacts, those provided by the calling app and from other sources. This value requires the contacts capability. See [App capability declarations](/windows/uwp/packaging/app-capability-declarations) for more information.

### -field AllContactsReadWrite:2
Read and write access to all contacts. This value is not available to all apps. Your developer account must be specially provisioned by Microsoft in order to request this level of access.


## -remarks

## -examples

## -see-also

## -capabilities
contactsSystem
