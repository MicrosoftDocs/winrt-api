---
-api-id: M:Windows.UI.Xaml.Controls.GroupStyleSelector.SelectGroupStyleCore(System.Object,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
virtual protected Windows.UI.Xaml.Controls.GroupStyle SelectGroupStyleCore(System.Object group, System.UInt32 level)
-->

# Windows.UI.Xaml.Controls.GroupStyleSelector.SelectGroupStyleCore

## -description
When implemented by a derived class, returns a specific [GroupStyle](groupstyle.md) for a given group and level.



## -parameters
### -param group
The group to return a [GroupStyle](groupstyle.md) for.

### -param level
The level of nesting for the specified group.

## -returns
The [GroupStyle](groupstyle.md) to use for the specified group and level.

## -remarks
> **Windows 8**
> In Windows 8, you can pass **null** as the *group* parameter value. In Windows 8.1, passing **null** causes an error.

## -examples

## -see-also
