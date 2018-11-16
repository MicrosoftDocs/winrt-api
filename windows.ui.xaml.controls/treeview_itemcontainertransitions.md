---
-api-id: P:Windows.UI.Xaml.Controls.TreeView.ItemContainerTransitions
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public TransitionCollection ItemContainerTransitions { get;  set; }
-->

# Windows.UI.Xaml.Controls.TreeView.ItemContainerTransitions

## -description

Gets or sets the collection of [Transition](../windows.ui.xaml.media.animation/transition.md) style elements that apply to the item containers of a TreeView.

## -xaml-syntax

```xaml
<TreeView>
  <TreeView.ItemContainerTransitions>
    <TransitionCollection>
      oneOrMoreTransitions
    </TransitionCollection>
  </TreeView.ItemContainerTransitions>
</TreeView>
```

## -xaml-values

<dl><dt>oneOrMoreTransitions</dt><dd>oneOrMoreTransitionsOne or more object elements instantiating types that are derived from the Transition base type. Typically there is only one of each type of transition included in the collection.</dd>
</dl>

## -property-value

The collection of [Transition](../windows.ui.xaml.media.animation/transition.md) style elements that apply to the item containers of an [ItemsControl](itemscontrol.md).

## -remarks

## -see-also

## -examples

