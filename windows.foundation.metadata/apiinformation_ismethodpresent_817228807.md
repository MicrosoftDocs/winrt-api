---
-api-id: M:Windows.Foundation.Metadata.ApiInformation.IsMethodPresent(System.String,System.String,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public bool IsMethodPresent(System.String typeName, System.String methodName, System.UInt32 inputParameterCount)
-->

# Windows.Foundation.Metadata.ApiInformation.IsMethodPresent

## -description
Returns true or false to indicate whether a specified method overload with the specified number of input parameters is present for a specified type.

## -parameters
### -param typeName
The namespace-qualified name of the type.

### -param methodName
The name of the method.

### -param inputParameterCount
The number of input parameters for the overload.

## -returns
**True** if the specified method is present for the type; otherwise, **false**.

## -remarks

## -examples
```cs
if (Windows.Foundation.Metadata.ApiInformation.IsMethodPresent("Windows.Globalization.PhoneNumberFormatting.PhoneNumberFormatter", "Format", 2))
{
    Debug.WriteLine("Windows.Globalization.PhoneNumberFormatting.PhoneNumberFormatter.Format overload that takes 2 parameters was found");
}
else
{
    Debug.WriteLine("Windows.Globalization.PhoneNumberFormatting.PhoneNumberFormatter.Format overload that takes 2 parameters was NOT found");
}
```
## -see-also
[IsMethodPresent(String, String)](apiinformation_ismethodpresent_1062983651.md)