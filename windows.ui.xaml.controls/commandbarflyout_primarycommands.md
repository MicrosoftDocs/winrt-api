---
-api-id: P:Windows.UI.Xaml.Controls.CommandBarFlyout.PrimaryCommands
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public IObservableVector<ICommandBarElement> PrimaryCommands { get; }
-->

# Windows.UI.Xaml.Controls.CommandBarFlyout.PrimaryCommands

## -description

Gets the collection of primary command elements for the [CommandBarFlyout](commandbarflyout.md).

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.CommandBarFlyout.PrimaryCommands](/windows/winui/api/microsoft.ui.xaml.controls.commandbarflyout.primarycommands) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<CommandBarFlyout>
    <CommandBarFlyout.PrimaryCommands>
      commandBarElements
    </CommandBarFlyout.PrimaryCommands>
</CommandBarFlyout>
```

## -xaml-values

<dl><dt>commandBarElements</dt><dd>commandBarElementsOne or more object elements for classes that implement ICommandBarElement. These are typically AppBarButton, AppBarToggleButton or AppBarSeparator elements.</dd>
</dl>

## -property-value

The collection of primary command elements for the [CommandBarFlyout](commandbarflyout.md). The default is an empty collection.

## -remarks

The PrimaryCommands collection can directly contain only [AppBarButton](appbarbutton.md), [AppBarToggleButton](appbartogglebutton.md), [AppBarSeparator](appbarseparator.md) command elements. Other elements must be wrapped in an [AppBarElementContainer](appbarelementcontainer.md).

The primary commands are shown in the command bar portion of the flyout.

## -examples

## -see-also

[SecondaryCommands](commandbarflyout_secondarycommands.md)
