---
-api-id: M:Windows.System.Profile.SystemIdentification.GetSystemIdForUser(Windows.System.User)
-api-type: winrt method
---

<!-- Method syntax
public Windows.System.Profile.SystemIdentificationInfo GetSystemIdForUser(Windows.System.User user)
-->

# Windows.System.Profile.SystemIdentification.GetSystemIdForUser

## -description
Gets an identifier value for the system based on the user ID.

## -parameters
### -param user
The [User](../windows.system/user.md) data to use for creating the system ID.

## -returns
A [SystemIdentificationInfo](systemidentificationinfo.md) object for this system, based on the user ID.

## -remarks
The identifier returned by this method is specific to the user on the current device and allows for correlation of usage across disparate services. Use of this method is restricted by the **userSystemId** capability.

## -examples

## -see-also


## -capabilities
userSystemId