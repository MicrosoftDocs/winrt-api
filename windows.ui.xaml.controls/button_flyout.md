---
-api-id: P:Windows.UI.Xaml.Controls.Button.Flyout
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.Primitives.FlyoutBase Flyout { get;  set; }
-->

# Windows.UI.Xaml.Controls.Button.Flyout

## -description
Gets or sets the flyout associated with this button.

## -xaml-syntax
```xaml
<Button>
  <Button.Flyout>flyout</Button.Flyout>
</Button>

```

```xaml
<Button Flyout="{StaticResurce flyoutResourceKey"/>

```


## -xaml-values
<dl><dt>flyout</dt><dd>flyoutAn instance of a FlyoutBase derived class; typically Flyout or MenuFlyout.</dd>
<dt>flyoutResourceKey</dt><dd>flyoutResourceKeyThe key that identifies the flyout being requested. The key refers to an existing resource in a ResourceDictionary.</dd>
</dl>
## -property-value
The flyout associated with this button, if any; otherwise, **null**. The default is **null**.

## -remarks
By default, the flyout that's set as the value of the [Flyout](button_flyout.md) property displays when the button is tapped or otherwise invoked, you don't need to call methods to display it. That differs from the behavior of flyouts assigned through the [FlyoutBase.AttachedFlyout](../windows.ui.xaml.controls.primitives/flyoutbase_attachedflyout.md) attached property; these flyouts must be explicitly displayed by calling [ShowAt](../windows.ui.xaml.controls.primitives/flyoutbase_showat_157739403.md) on the flyout instance, or the static [ShowAttachedFlyout](../windows.ui.xaml.controls.primitives/flyoutbase_showattachedflyout_1146189011.md) method.

## -examples

## -see-also
[Flyout](flyout.md), [MenuFlyout](menuflyout.md), [Quickstart: Adding a Flyout](http://msdn.microsoft.com/library/de211e9b-6de8-4014-9264-c278a5c3f7bd), [XAML Flyout and MenuFlyout sample](http://go.microsoft.com/fwlink/p/?LinkID=310074)