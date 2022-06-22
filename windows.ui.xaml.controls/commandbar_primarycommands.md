---
-api-id: P:Windows.UI.Xaml.Controls.CommandBar.PrimaryCommands
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IObservableVector<Windows.UI.Xaml.Controls.ICommandBarElement> PrimaryCommands { get; }
-->

# Windows.UI.Xaml.Controls.CommandBar.PrimaryCommands

## -description
Gets the collection of primary command elements for the [CommandBar](commandbar.md).



## -xaml-syntax
```xaml
<CommandBar>
    <CommandBar.PrimaryCommands>
      commandBarElements
    </CommandBar.PrimaryCommands>
</CommandBar>
```


## -xaml-values
<dl><dt>commandBarElements</dt><dd>commandBarElementsOne or more object elements for classes that implement ICommandBarElement. These are typically AppBarButton, AppBarToggleButton or AppBarSeparator elements.</dd>
</dl>
## -property-value
The collection of primary command elements for the [CommandBar](commandbar.md). The default is an empty collection.

## -remarks
The PrimaryCommands collection can contain only [AppBarButton](appbarbutton.md), [AppBarToggleButton](appbartogglebutton.md), or [AppBarSeparator](appbarseparator.md) command elements. The primary commands are shown on the right side of the [CommandBar](commandbar.md), to the left of the More button (...) when the [FlowDirection](../windows.ui.xaml/frameworkelement_flowdirection.md) is **LeftToRight**. The layout is reversed when the [FlowDirection](../windows.ui.xaml/frameworkelement_flowdirection.md) is **RightToLeft**.

## -examples

## -see-also
[SecondaryCommands](commandbar_secondarycommands.md)
