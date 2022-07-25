---
-api-id: P:Windows.UI.Xaml.Controls.ListViewBase.HeaderTransitions
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Animation.TransitionCollection HeaderTransitions { get;  set; }
-->

# Windows.UI.Xaml.Controls.ListViewBase.HeaderTransitions

## -description
Gets or sets the collection of [Transition](../windows.ui.xaml.media.animation/transition.md) style elements that apply to the view header.



## -xaml-syntax
```xaml
<listViewBase>
  <listViewBase.HeaderTransitions>
    <TransitionCollection>
      oneOrMoreTransitions
    </TransitionCollection>
  </listViewBase.HeaderTransitions>
</listViewBase>
```


## -xaml-values
<dl><dt>oneOrMoreTransitions</dt><dd>oneOrMoreTransitionsOne or more object elements instantiating types that are derived from the Transition base type. Typically there is only one of each type of transition included in the collection.</dd>
</dl>
## -property-value
The collection of [Transition](../windows.ui.xaml.media.animation/transition.md) style elements that apply to the list header.

## -remarks

> [!NOTE]
> Prior to Windows 10, version 1809 (SDK 17763), the XAML syntax for properties that have a [TransitionCollection](../windows.ui.xaml.media.animation/transitioncollection.md) value requires that you declare an explicit [TransitionCollection](../windows.ui.xaml.media.animation/transitioncollection.md) object element as the value, and then provide object elements as child elements of [TransitionCollection](../windows.ui.xaml.media.animation/transitioncollection.md) for each of the transition animations you want to use. In Windows 10, version 1809 (SDK 17763) or later, [TransitionCollection](../windows.ui.xaml.media.animation/transitioncollection.md) supports the implicit collection usage, so you can omit the collection object element. For more info on implicit collections and XAML, see [XAML syntax guide](/windows/uwp/xaml-platform/xaml-syntax-guide).

Transition animations play a particular role in the UI design of your app. The basic idea is that when there is a change or transition, the animation draws the attention of the user to the change.
<!-- For more info, see  Transition animations and theme animations.-->

## -examples

## -see-also
[Header](listviewbase_header.md), [HeaderTemplate](listviewbase_headertemplate.md), [TransitionCollection](../windows.ui.xaml.media.animation/transitioncollection.md)
