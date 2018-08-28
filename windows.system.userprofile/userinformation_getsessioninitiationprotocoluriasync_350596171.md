---
-api-id: M:Windows.System.UserProfile.UserInformation.GetSessionInitiationProtocolUriAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Uri> GetSessionInitiationProtocolUriAsync()
-->

# Windows.System.UserProfile.UserInformation.GetSessionInitiationProtocolUriAsync

## -description
Gets the Uniform Resource Identifier (URI) of the session initiation protocol for the user.

> [!IMPORTANT]
> The [UserInformation](userinformation.md) class is not supported on Windows 10 or later. Use the [User](../windows.system/user.md) class instead. See Remarks in the [UserInformation](userinformation.md) class documentation.

## -returns
The Uniform Resource Identifier (URI) of the session initiation protocol.

## -remarks
> [!IMPORTANT]
> The [UserInformation](userinformation.md) class is not supported on Windows 10 or later. Use the [User](../windows.system/user.md) class instead. See Remarks in the [UserInformation](userinformation.md) class documentation.

Access to the Uniform Resource Identifier (URI) of the session initiation protocol for the user can be blocked by privacy settings (for example, if the [UserInformation.NameAccessAllowed](userinformation_nameaccessallowed.md) property is false). If access is blocked, this method returns a null value.

This method does not throw an exception.

## -examples

## -see-also
[User](../windows.system/user.md)
