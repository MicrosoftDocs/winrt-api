---
-api-id: P:Windows.UI.Xaml.Controls.CommandBar.CommandBarOverflowPresenterStyle
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Style CommandBarOverflowPresenterStyle { get;  set; }
-->

# Windows.UI.Xaml.Controls.CommandBar.CommandBarOverflowPresenterStyle

## -description
Gets or sets the [Style](../windows.ui.xaml/style.md) applied to the overflow content of the [CommandBar](commandbar.md).



## -xaml-syntax
```xaml

<CommandBar CommandBarOverflowPresenterStyle={StaticResource styleResourceKey}/>
- or -
<CommandBar>
  <CommandBar.CommandBarOverflowPresenterStyle>
    <Style TargetType="CommandBarOverflowPresenter">
      oneOrMoreSetters
    </Style>
  </CommandBar.CommandBarOverflowPresenterStyle>
</CommandBar>
```


## -xaml-values
<dl><dt>styleResourceKey</dt><dd>styleResourceKeyThe key that identifies the style being requested. The key refers to an existing resource in a ResourceDictionary.</dd>
<dt>oneOrMoreSetters</dt><dd>oneOrMoreSettersOne or more Setter elements with Property attributes that target the dependency properties of a CommandBarOverflowPresenter.</dd>
</dl>
## -property-value
The applied [Style](../windows.ui.xaml/style.md) for the overflow content of the [CommandBar](commandbar.md), if present; otherwise, **null**. The default is **null**.

## -remarks
The [Style](../windows.ui.xaml/style.md) element you use for a [CommandBarOverflowPresenter](commandbaroverflowpresenter.md) value must specify `TargetType="CommandBarOverflowPresenter"`.

You can style the properties of the internal [CommandBarOverflowPresenter](commandbaroverflowpresenter.md) that is presenting the overflow content ([SecondaryCommands](commandbar_secondarycommands.md)) of a [CommandBar](commandbar.md). The properties that can be styled are the dependency properties of the base [ItemsControl](itemscontrol.md) class or [Control](control.md) class, such as [FontSize](control_fontsize.md) or [Padding](control_padding.md), or base element properties such as [FrameworkElement.Margin](../windows.ui.xaml/frameworkelement_margin.md) that the [CommandBarOverflowPresenter](commandbaroverflowpresenter.md) class inherits.

## -examples

## -see-also
[CommandBar.SecondaryCommands](commandbar_secondarycommands.md), [CommandBarOverflowPresenter](commandbaroverflowpresenter.md)
