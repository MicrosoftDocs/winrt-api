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
> [!IMPORTANT]
> The XAML syntax for all properties that use a [TransitionCollection](../windows.ui.xaml.media.animation/transitioncollection.md) value is unusual in that you must declare an explicit [TransitionCollection](../windows.ui.xaml.media.animation/transitioncollection.md) object element as the value, and then provide object elements as child elements of [TransitionCollection](../windows.ui.xaml.media.animation/transitioncollection.md) for each of the transition animations you want to use. For most other XAML collection properties you could omit the collection object element because it can be implicit, but properties that use [TransitionCollection](../windows.ui.xaml.media.animation/transitioncollection.md) don't support the implicit collection usage. For more info on implicit collections and XAML, see [XAML syntax guide](http://msdn.microsoft.com/library/a57fe7b4-9947-4aa0-bc99-5fe4686b611d).

Transition animations play a particular role in UI design of your app. The basic idea is that when there is a change or transition, the animation draws the attention of the user to the change.
<!-- For more info, see  Transition animations and theme animations.-->

## -examples

## -see-also
[Header](listviewbase_header.md), [HeaderTemplate](listviewbase_headertemplate.md), [TransitionCollection](../windows.ui.xaml.media.animation/transitioncollection.md)