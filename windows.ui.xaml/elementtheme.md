---
-api-id: T:Windows.UI.Xaml.ElementTheme
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.ElementTheme : int
-->

# ElementTheme

## -description
Specifies a UI theme that should be used for individual [UIElement](uielement.md) parts of an app UI.



## -xaml-syntax
```xaml
<object property="enumMemberName"/> 
 
```


## -enum-fields
### -field Default:0
Use the [Application.RequestedTheme](application_requestedtheme.md) value for the element. This is the default.

### -field Light:1
Use the **Light** default theme.

### -field Dark:2
Use the **Dark** default theme.


## -remarks
This enumeration is used as a value by the [RequestedTheme](frameworkelement_requestedtheme.md) property.



> [!NOTE]
> On Windows, setting [RequestedTheme](application_requestedtheme.md) to Default will always result in "Dark" being the theme. On Windows Phone, using the Default value will result in a query for the system theme, as set by the user.

## -examples

## -see-also
[ApplicationTheme](applicationtheme.md), [RequestedTheme](frameworkelement_requestedtheme.md)
