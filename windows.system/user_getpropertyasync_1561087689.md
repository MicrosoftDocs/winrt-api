---
-api-id: M:Windows.System.User.GetPropertyAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<object> GetPropertyAsync(System.String value)
-->

# Windows.System.User.GetPropertyAsync

## -description
Gets a property for the user. Use the [KnownUserProperties](knownuserproperties.md) class to obtain property names.

## -parameters
### -param value
The property to get.

## -returns
When this method completes, it returns the requested property. If the property is missing or unavailable, an empty string is returned.

## -remarks

See the [GetPropertiesAsync](user_getpropertiesasync_1952817514.md) method for details on supported properties.
## -examples

## -see-also
[User information sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/UserInfo)

## -capabilities
userAccountInformation
