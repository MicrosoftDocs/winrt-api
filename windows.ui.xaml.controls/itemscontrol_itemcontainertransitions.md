---
-api-id: P:Windows.UI.Xaml.Controls.ItemsControl.ItemContainerTransitions
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Animation.TransitionCollection ItemContainerTransitions { get;  set; }
-->

# Windows.UI.Xaml.Controls.ItemsControl.ItemContainerTransitions

## -description
Gets or sets the collection of [Transition](../windows.ui.xaml.media.animation/transition.md) style elements that apply to the item containers of an [ItemsControl](itemscontrol.md).



## -xaml-syntax
```xaml
<itemsControl>
  <itemsControl.ItemContainerTransitions>
    <TransitionCollection>
      oneOrMoreTransitions
    </TransitionCollection>
  </itemsControl.ItemContainerTransitions>
</itemsControl>
```


## -xaml-values
<dl><dt>oneOrMoreTransitions</dt><dd>oneOrMoreTransitionsOne or more object elements instantiating types that are derived from the Transition base type. Typically there is only one of each type of transition included in the collection.</dd>
</dl>
## -property-value
The collection of [Transition](../windows.ui.xaml.media.animation/transition.md) style elements that apply to the item containers of an [ItemsControl](itemscontrol.md).

## -remarks
> [!NOTE]
> Prior to Windows 10, version 1809 (SDK 17763), the XAML syntax for properties that have a [TransitionCollection](../windows.ui.xaml.media.animation/transitioncollection.md) value requires that you declare an explicit [TransitionCollection](../windows.ui.xaml.media.animation/transitioncollection.md) object element as the value, and then provide object elements as child elements of [TransitionCollection](../windows.ui.xaml.media.animation/transitioncollection.md) for each of the transition animations you want to use. In Windows 10, version 1809 (SDK 17763) or later, [TransitionCollection](../windows.ui.xaml.media.animation/transitioncollection.md) supports the implicit collection usage, so you can omit the collection object element. For more info on implicit collections and XAML, see [XAML syntax guide](/windows/uwp/xaml-platform/xaml-syntax-guide).

Items collections can have transition animations associated with add or remove actions, or for drop target scenarios.

This property is more typically set in a [Style](../windows.ui.xaml/style.md) setter rather than inline on an object element in UI definition. For more info, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls).

The default template for [GridView](gridview.md) includes existing transition animations. Specifically, the default ItemContainerTransitions value already contains values for [AddDeleteThemeTransition](../windows.ui.xaml.media.animation/adddeletethemetransition.md), [ContentThemeTransition](../windows.ui.xaml.media.animation/contentthemetransition.md), [ReorderThemeTransition](../windows.ui.xaml.media.animation/reorderthemetransition.md) and [EntranceThemeTransition](../windows.ui.xaml.media.animation/entrancethemetransition.md) (with `IsStaggeringEnabled="False"`). If you are setting a new value for ItemContainerTransitions on [GridView](gridview.md), consider reproducing these same theme animations as a starting point.

To remove all default content transitions from a [GridView](gridview.md), you might have to re-template the [GroupStyle.ContainerStyle](groupstyle_containerstyle.md). The transition behavior for items and their containers are interrelated.

## -examples

## -see-also
[TransitionCollection](../windows.ui.xaml.media.animation/transitioncollection.md)
