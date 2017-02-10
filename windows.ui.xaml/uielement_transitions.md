---
-api-id: P:Windows.UI.Xaml.UIElement.Transitions
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Animation.TransitionCollection Transitions { get;  set; }
-->

# Windows.UI.Xaml.UIElement.Transitions

## -description
Gets or sets the collection of [Transition](../windows.ui.xaml.media.animation/transition.md) style elements that apply to a [UIElement](uielement.md).

## -xaml-syntax
```xaml
<uielement>
  <uielement.Transitions>
    <TransitionCollection>
      oneOrMoreTransitions
    </TransitionCollection>
  </uielement.Transitions>
</uielement>
```


## -xaml-values
<dl><dt>oneOrMoreTransitions</dt><dd>oneOrMoreTransitionsOne or more object elements instantiating types that are derived from the Transition base type. Typically there is only one of each type of transition included in the collection.</dd>
</dl>
## -property-value
The strongly typed collection of [Transition](../windows.ui.xaml.media.animation/transition.md) style elements that apply to a [UIElement](uielement.md).

## -remarks
> [!IMPORTANT]
> The XAML syntax for all properties that use a [TransitionCollection](../windows.ui.xaml.media.animation/transitioncollection.md) value is unusual in that you must declare an explicit [TransitionCollection](../windows.ui.xaml.media.animation/transitioncollection.md) object element as the value, and then provide object elements as child elements of [TransitionCollection](../windows.ui.xaml.media.animation/transitioncollection.md) for each of the transition animations you want to use. For most other XAML collection properties you could omit the collection object element because it can be implicit, but properties that use [TransitionCollection](../windows.ui.xaml.media.animation/transitioncollection.md) don't support the implicit collection usage. For more info on implicit collections and XAML, see [XAML syntax guide](http://msdn.microsoft.com/library/a57fe7b4-9947-4aa0-bc99-5fe4686b611d).

This is a short list of some of the possible types for transitions:
+ [AddDeleteThemeTransition](../windows.ui.xaml.media.animation/adddeletethemetransition.md)
+ [ContentThemeTransition](../windows.ui.xaml.media.animation/contentthemetransition.md)
+ [EdgeUIThemeTransition](../windows.ui.xaml.media.animation/edgeuithemetransition.md)
+ [EntranceThemeTransition](../windows.ui.xaml.media.animation/entrancethemetransition.md)
+ [PopupThemeTransition](../windows.ui.xaml.media.animation/popupthemetransition.md)
+ [ReorderThemeTransition](../windows.ui.xaml.media.animation/reorderthemetransition.md)
+ [RepositionThemeTransition](../windows.ui.xaml.media.animation/repositionthemetransition.md)


Specific classes that derive from [UIElement](uielement.md) sometimes have their own properties that hold other types of transitions for class-specific scenarios. For example, [Popup.ChildTransitions](../windows.ui.xaml.controls.primitives/popup_childtransitions.md) and [ItemsControl.ItemContainerTransitions](../windows.ui.xaml.controls/itemscontrol_itemcontainertransitions.md).

Transition animations play a particular role in UI design of your app. The basic idea is that when there is a change or transition, the animation draws the attention of the user to the change.
<!-- For more info, see  Transition animations and theme animations.-->

It's not common to set the value of the [Transitions](uielement_transitions.md) property directly on a [UIElement](uielement.md) that is a direct element of app UI. It's more common to have a transitions collection be a part of a visual state, template or style. In this case you use mechanisms such as [Setter](setter.md) of a [Style](style.md) to specify the [Transitions](uielement_transitions.md) property, and set the value using XAML-defined content that is typically stored as a XAML resource.

[VisualTransition](visualtransition.md) is not one of the types you put in the [UIElement.Transitions](uielement_transitions.md) collection. [VisualTransition](visualtransition.md) is specifically for animations in visual state groups, and is used by the [VisualStateGroup.Transitions](visualstategroup_transitions.md) property.

## -examples
This XAML example shows a single [EntranceThemeTransition](../windows.ui.xaml.media.animation/entrancethemetransition.md) as defined in a [Style](style.md) for a [Button](../windows.ui.xaml.controls/button.md). Transition animation properties are typically set in styles and templates rather than as properties directly in a UI definition. Styles are typically stored as a XAML resource.



[!code-xml[EntranceThemeTransitionStyle](../windows.ui.xaml/code/EntranceThemeTransitionStyle/csharp/BlankPage.xaml#SnippetEntranceThemeTransitionStyle)]

## -see-also
[Storyboarded animations](http://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a), [TransitionCollection](../windows.ui.xaml.media.animation/transitioncollection.md)
