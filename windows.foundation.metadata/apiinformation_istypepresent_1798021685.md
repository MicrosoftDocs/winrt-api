---
-api-id: M:Windows.Foundation.Metadata.ApiInformation.IsTypePresent(System.String)
-api-type: winrt method
---

<!-- Method syntax
public bool IsTypePresent(System.String typeName)
-->

# Windows.Foundation.Metadata.ApiInformation.IsTypePresent

## -description
Returns true or false to indicate whether a specified type is present.

## -parameters
### -param typeName
The namespace-qualified name of the type.

## -returns
**True** if the specified type is present; otherwise, **false**.

## -remarks

## -examples
```cs
if (Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.System.AppDiagnosticInfo"))
{
    Debug.WriteLine("Windows.System.AppDiagnosticInfo type was found");
}
else
{
    Debug.WriteLine("Windows.System.AppDiagnosticInfo type was NOT found");
}
```
## -see-also
