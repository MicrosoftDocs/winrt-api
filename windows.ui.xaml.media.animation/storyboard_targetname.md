---
-api-id: P:Windows.UI.Xaml.Media.Animation.Storyboard.TargetName
-api-type: winrt attachedproperty
---

# Windows.UI.Xaml.Media.Animation.Storyboard.TargetName

<!--
see GetTargetName, and SetTargetName
-->

## -description

Gets or sets the name of the object to animate.

## -remarks

`Storyboard.TargetName` is used to reference another element by its name. The element being referenced is the element/object where the animation should apply. This mechanism is part of the basic design of the animation system: it enables animation resources to be declared separately from UI declaration resources, and makes it possible to apply one animation definition to several different property behaviors. For the value of `Storyboard.TargetName` on a particular animation, you specify the target element's [Name](../windows.ui.xaml/frameworkelement_name.md) or [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) value, which is a string. That named element should already exist in some other area of XAML markup.

The meaning of [Name](../windows.ui.xaml/frameworkelement_name.md)/[x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) strings is controlled by a XAML namescope concept. For most animation targeting scenarios you won't need to worry about the influence of XAML namescopes, but you might encounter XAML name resolution issues if you're trying to target template parts, or objects that were created using [XamlReader.Load](../windows.ui.xaml.markup/xamlreader_load_1077941801.md) and subsequently added to the object tree. For more info, see [XAML namescopes](/windows/uwp/xaml-platform/xaml-namescopes).

<ul><li>Type: string</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.media.animation.storyboard.targetnameproperty">TargetNameProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.media.animation.storyboard.gettargetname">GetTargetName</a>, <a href="/uwp/api/windows.ui.xaml.media.animation.storyboard.settargetname">SetTargetName</a></li></ul>

## -see-also

[XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples


