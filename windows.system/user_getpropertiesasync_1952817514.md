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

## -examples

## -see-also
[User information sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620617)

## -capabilities
userAccountInformation