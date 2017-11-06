---
-api-id: M:Windows.Foundation.Metadata.ApiInformation.IsEnumNamedValuePresent(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public bool IsEnumNamedValuePresent(System.String enumTypeName, System.String valueName)
-->

# Windows.Foundation.Metadata.ApiInformation.IsEnumNamedValuePresent

## -description
Returns true or false to indicate whether a specified named constant is present for a specified enumeration.

## -parameters
### -param enumTypeName
The namespace-qualified name of the type.

### -param valueName
The name of the constant.

## -returns
**True** if the specified constant is present; otherwise, **false**.

## -remarks

## -examples
```cs
if (Windows.Foundation.Metadata.ApiInformation.IsEnumNamedValuePresent("Windows.UI.Xaml.Automation.Peers.AutomationControlType", "ComboBox"))
{
    Debug.WriteLine("Windows.UI.Xaml.Automation.Peers.AutomationControlType.ComboBox enum value found");
}
else
{
    Debug.WriteLine("Windows.UI.Xaml.Automation.Peers.AutomationControlType.ComboBox enum value NOT found");
}
```
## -see-also
