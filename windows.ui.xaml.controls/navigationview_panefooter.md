---
-api-id: P:Windows.UI.Xaml.Controls.NavigationView.PaneFooter
-api-type: winrt property
---

<!-- Property syntax.
public UIElement PaneFooter { get;  set; }
-->

# Windows.UI.Xaml.Controls.NavigationView.PaneFooter

## -description

Gets or sets the content for the pane footer.

## -xaml-syntax

```xaml
<NavigationView>
  <NavigationView.PaneFooter>
    footerElement
  </NavigationView.PaneFooter>
</NavigationView>
```

## -xaml-values

<dt>footerElement</dt><dd>footerElementA single UI element that serves as footer content. This can be a panel that contains other UI elements.</dd>
</dl>

## -property-value

The content of the pane footer. The default is **null**.

## -remarks

The PaneFooter property takes a single UIElement, which can be a layout panel that contains additional elements.

If you place a [NavigationViewItem](navigationviewitem.md) in the PaneFooter, it will not raise the [NavigationView.ItemInvoked](navigationview_iteminvoked.md) event. The ItemInvoked event is raised only when the NavigationViewItem is in the [NavigationView.MenuItems](navigationview_menuitems.md) collection.

## -see-also

## -examples
