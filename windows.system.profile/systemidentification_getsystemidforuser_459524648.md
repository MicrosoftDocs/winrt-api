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
The identifier returned by this method is specific to the user on the current device and allows for correlation of usage across different applications running on the same device for a particular user. Use of this method is restricted by the **userSystemId** capability, which is a restricted capability requiring Microsoft approval. Please note that most callers should instead use the [Windows.System.Profile.SystemIdentification.GetSystemIdForPublisher](systemidentification_getsystemidforpublisher_728928815.md) method instead as it is more appropriate for the large majority of use cases and does not require a restricted capability. If you do not need to obtain an ID that is shared across apps built by different publishers, you should not use this method.

## -examples

## -see-also


## -capabilities
userSystemId
