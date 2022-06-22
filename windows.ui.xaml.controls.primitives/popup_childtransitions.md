---
-api-id: P:Windows.UI.Xaml.Controls.Primitives.Popup.ChildTransitions
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Animation.TransitionCollection ChildTransitions { get;  set; }
-->

# Windows.UI.Xaml.Controls.Primitives.Popup.ChildTransitions

## -description
Gets or sets the collection of [Transition](../windows.ui.xaml.media.animation/transition.md) style elements that apply to child content of a [Popup](popup.md).



## -xaml-syntax
```xaml
<Popup>
  <Popup.ChildTransitions>
    <TransitionCollection>
      oneOrMoreTransitions
    </TransitionCollection>
  </Popup.ChildTransitions>
</Popup>
```


## -xaml-values
<dl><dt>oneOrMoreTransitions</dt><dd>oneOrMoreTransitionsOne or more object elements that instantiate types that are derived from the Transition base type. Typically there is only one of each type of transition included in the collection.</dd>
</dl>
## -property-value
The strongly typed collection of [Transition](../windows.ui.xaml.media.animation/transition.md) style elements.

## -remarks

> [!NOTE]
> Prior to Windows 10, version 1809 (SDK 17763), the XAML syntax for properties that have a [TransitionCollection](../windows.ui.xaml.media.animation/transitioncollection.md) value requires that you declare an explicit [TransitionCollection](../windows.ui.xaml.media.animation/transitioncollection.md) object element as the value, and then provide object elements as child elements of [TransitionCollection](../windows.ui.xaml.media.animation/transitioncollection.md) for each of the transition animations you want to use. In Windows 10, version 1809 (SDK 17763) or later, [TransitionCollection](../windows.ui.xaml.media.animation/transitioncollection.md) supports the implicit collection usage, so you can omit the collection object element. For more info on implicit collections and XAML, see [XAML syntax guide](/windows/uwp/xaml-platform/xaml-syntax-guide).

Transition animations play a particular role in the UI design of your app. The basic idea is that when there is a change or transition, the animation draws the attention of the user to the change.
<!-- For more info, see  Transition animations and theme animations.-->
It's not common to set the value of the ChildTransitionsproperty directly on a [Popup](popup.md)that is a direct element of app UI. It's more common to have a transitions collection be a part of a visual state, template or style. In this case you use mechanisms such as [Setter](../windows.ui.xaml/setter.md)of a [Style](../windows.ui.xaml/style.md)to specify the ChildTransitionsproperty. Styles are typically stored as a XAML resource.



## -examples

## -see-also
[TransitionCollection](../windows.ui.xaml.media.animation/transitioncollection.md)
