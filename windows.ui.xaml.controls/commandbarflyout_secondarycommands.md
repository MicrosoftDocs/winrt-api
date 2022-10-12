---
-api-id: P:Windows.UI.Xaml.Controls.CommandBarFlyout.SecondaryCommands
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public IObservableVector<ICommandBarElement> SecondaryCommands { get; }
-->

# Windows.UI.Xaml.Controls.CommandBarFlyout.SecondaryCommands

## -description

Gets the collection of secondary command elements for the [CommandBarFlyout](commandbarflyout.md).

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.CommandBarFlyout.SecondaryCommands](/windows/winui/api/microsoft.ui.xaml.controls.commandbarflyout.secondarycommands) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<CommandBarFlyout>
    <CommandBarFlyout.SecondaryCommands>
       commandBarElements
    </CommandBarFlyout.SecondaryCommands>
</CommandBarFlyout>
```

## -xaml-values

<dl><dt>commandBarElements</dt><dd>commandBarElementsOne or more object elements for classes that implement ICommandBarElement. These are typically AppBarButton, AppBarToggleButton or AppBarSeparator elements.</dd>
</dl>

## -property-value

The collection of secondary command elements for the [CommandBarFlyout](commandbarflyout.md). The default is an empty collection.

## -remarks
The SecondaryCommands collection can directly contain only [AppBarButton](appbarbutton.md), [AppBarToggleButton](appbartogglebutton.md), or [AppBarSeparator](appbarseparator.md) command elements.  Other elements must be wrapped in an [AppBarElementContainer](appbarelementcontainer.md).

The secondary commands are shown in the menu portion of the flyout when the [CommandBarFlyout](commandbarflyout.md) is expanded.

## -examples

## -see-also

[PrimaryCommands](commandbarflyout_primarycommands.md)

