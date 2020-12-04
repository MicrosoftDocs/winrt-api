---
-api-id: M:Windows.ApplicationModel.Contacts.ContactManager.IsShowDelayLoadedContactCardSupported
-api-type: winrt method
---

<!-- Method syntax
public bool IsShowDelayLoadedContactCardSupported()
-->

# Windows.ApplicationModel.Contacts.ContactManager.IsShowDelayLoadedContactCardSupported

## -description
Gets a Boolean value that indicates whether the [ShowDelayLoadedContactCard](/uwp/api/windows.applicationmodel.contacts.contactmanager.showdelayloadedcontactcard) method is supported on the current platform.

## -returns
`true` if the [ShowDelayLoadedContactCard](/uwp/api/windows.applicationmodel.contacts.contactmanager.showdelayloadedcontactcard) method is supported on the current platform; otherwise, `false`.

## -remarks
> [!NOTE]
> Source apps must be running in the foreground to call this method. An app that runs in the background will get an "Access Denied" exception if it calls this method. The return value of the method should not be cached and should only be called when needed.

## -examples

## -see-also

## -capabilities
contactsSystem
