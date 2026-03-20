---
-api-id: M:Windows.System.User.GetFromId(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.System.User GetFromId(System.String nonRoamableId)
-->

# Windows.System.User.GetFromId

## -description
Gets a user with a given Id.

## -parameters
### -param nonRoamableId
The Id of the user to get.

## -returns
The user with the given Id.

## -remarks
If no user with the given *nonRoamableId* is found, this method returns **null**. Always check the return value before using it.

A *nonRoamableId* can be obtained from the [NonRoamableId](user_nonroamableid.md) property of a [User](user.md) object. This identifier is device-specific and is not roamed to other devices.

## -examples

## -see-also
