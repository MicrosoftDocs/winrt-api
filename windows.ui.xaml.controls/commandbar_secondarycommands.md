---
-api-id: P:Windows.UI.Xaml.Controls.CommandBar.SecondaryCommands
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IObservableVector<Windows.UI.Xaml.Controls.ICommandBarElement> SecondaryCommands { get; }
-->

# Windows.UI.Xaml.Controls.CommandBar.SecondaryCommands

## -description
Gets the collection of secondary command elements for the [CommandBar](commandbar.md).



## -xaml-syntax
```xaml
<CommandBar>
    <CommandBar.SecondaryCommands>
       commandBarElements
    </CommandBar.SecondaryCommands>
</CommandBar>
```


## -xaml-values
<dl><dt>commandBarElements</dt><dd>commandBarElementsOne or more object elements for classes that implement ICommandBarElement. These are typically AppBarButton, AppBarToggleButton or AppBarSeparator elements.</dd>
</dl>
## -property-value
The collection of secondary command elements for the [CommandBar](commandbar.md). The default is an empty collection.

## -remarks
The SecondaryCommands collection can contain only [AppBarButton](appbarbutton.md), [AppBarToggleButton](appbartogglebutton.md), or [AppBarSeparator](appbarseparator.md) command elements. The secondary commands are shown in the overflow menu when the [CommandBar](commandbar.md) is open.

## -examples

## -see-also
[PrimaryCommands](commandbar_primarycommands.md)
