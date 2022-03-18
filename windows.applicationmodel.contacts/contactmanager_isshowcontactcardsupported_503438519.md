---
-api-id: M:Windows.ApplicationModel.Contacts.ContactManager.IsShowContactCardSupported
-api-type: winrt method
---

<!-- Method syntax
public bool IsShowContactCardSupported()
-->

# Windows.ApplicationModel.Contacts.ContactManager.IsShowContactCardSupported

## -description
Gets a Boolean value that indicates whether the [ShowContactCard](/uwp/api/windows.applicationmodel.contacts.contactmanager.showcontactcard) method is supported on the current platform.

## -returns
`true` if the [ShowContactCard](/uwp/api/windows.applicationmodel.contacts.contactmanager.showcontactcard) method is supported on the current platform; otherwise, `false`.

## -remarks
> [!NOTE]
> Source apps must be running in the foreground to call this method. An app that runs in the background will get an "Access Denied" exception if it calls this method. The return value of the method should not be cached and should only be called when needed.

## -examples

## -see-also

## -capabilities
contactsSystem
