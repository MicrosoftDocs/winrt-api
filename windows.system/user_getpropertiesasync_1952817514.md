---
-api-id: M:Windows.System.User.GetPropertiesAsync(Windows.Foundation.Collections.IVectorView{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IPropertySet> GetPropertiesAsync(Windows.Foundation.Collections.IVectorView<System.String> values)
-->

# Windows.System.User.GetPropertiesAsync

## -description
Gets properties for the user.

## -parameters
### -param values
The properties to get. Use the [KnownUserProperties](knownuserproperties.md) class to obtain property names.

## -returns
When this method completes, it returns the requested properties. If a property is missing or unavailable, it is reported as an empty string.

## -remarks

Not all properties are available for all users. The following table summarizes which properties are available under various conditions.

Property | Local account   not domain joined | Local account   domain joined | MSA account | AAD account
-- | -- | -- | -- | --
AccountName | Not available | Not available | Not available | Not available
DisplayName | Not available | Not available | Not available | Available if domain joined
DomainName | Not available | Available | Not available | Available
FirstName | Available | Available | Available | Available
GuestHost | Available on XBOX | Available on XBOX | Available on XBOX | Available on XBOX
LastName | Available | Available | Available | Available
PrincipalName | Not available | Available | Not available | Available if domain joined
ProviderName | Not available | Not available | Not available | Not available
SessionInitiationProtocolUri | Not available | Available | Not available | Available if domain joined

## -examples

## -see-also
[User information sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/UserInfo)

## -capabilities
userAccountInformation
