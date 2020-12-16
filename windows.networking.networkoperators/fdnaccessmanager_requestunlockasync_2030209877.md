---
-api-id: M:Windows.Networking.NetworkOperators.FdnAccessManager.RequestUnlockAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> RequestUnlockAsync(System.String contactListId)
-->

# Windows.Networking.NetworkOperators.FdnAccessManager.RequestUnlockAsync

## -description
Static method that prompts the user for the PIN required to change a contact list of Fixed Dialing Numbers (FDNs). Typically your code calls this method when planning to make a change to the contact list. If the return value on successful completion is **true**, then you will be able to change the list of FDN contacts.

## -parameters
### -param contactListId
A [ContactList ID](../windows.applicationmodel.contacts/contactlist_id.md) for the contact list you wish to change.

## -returns
An asynchronous retrieval operation. On successful completion, contains a [Boolean](/dotnet/api/system.boolean?view=dotnet-uwp-10.0&preserve-view=true) value representing whether the PIN was entered successfully.

## -remarks

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
