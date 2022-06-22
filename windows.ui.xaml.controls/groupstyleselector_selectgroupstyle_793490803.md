---
-api-id: M:Windows.UI.Xaml.Controls.GroupStyleSelector.SelectGroupStyle(System.Object,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.Controls.GroupStyle SelectGroupStyle(System.Object group, System.UInt32 level)
-->

# Windows.UI.Xaml.Controls.GroupStyleSelector.SelectGroupStyle

## -description
Returns a specific [GroupStyle](groupstyle.md) for a given group and level.



## -parameters
### -param group
The group to return a [GroupStyle](groupstyle.md) for.

### -param level
The level of nesting for the specified group.

## -returns
The[GroupStyle](groupstyle.md) to use when this [GroupStyleSelector](groupstyleselector.md) is invoked in an application.

## -remarks
To provide a specific group style in a derived class, override the [SelectGroupStyleCore](groupstyleselector_selectgroupstylecore_1139726630.md) method.

> **Windows 8**
> In Windows 8, you can pass **null** as the *group* parameter value. In Windows 8.1, passing **null** causes an error.

## -examples

## -see-also
