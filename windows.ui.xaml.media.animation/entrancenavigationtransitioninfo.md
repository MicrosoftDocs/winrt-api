---
-api-id: T:Windows.UI.Xaml.Media.Animation.EntranceNavigationTransitionInfo
-api-type: winrt class
---

<!-- Class syntax.
public class EntranceNavigationTransitionInfo : Windows.UI.Xaml.Media.Animation.NavigationTransitionInfo, Windows.UI.Xaml.Media.Animation.IEntranceNavigationTransitionInfo
-->

# Windows.UI.Xaml.Media.Animation.EntranceNavigationTransitionInfo

## -description
Specifies the animation to run when content appears on a [Page](../windows.ui.xaml.controls/page.md).

Equivalent WinUI class: [Microsoft.UI.Xaml.Media.Animation.EntranceNavigationTransitionInfo](/windows/winui/api/microsoft.ui.xaml.media.animation.entrancenavigationtransitioninfo).

## -remarks
The **EntranceNavigationTransitionInfo** class represents the page refresh animation. Page refresh is a combination of a slide up animation and a fade in animation for the incoming content. 

With Windows 10, version 1803, a Frame uses [NavigationThemeTransition](navigationthemetransition.md) to animate navigation between Pages. By default, the animation is *Page Refresh* because the [DefaultNavigationTransitionInfo](navigationthemetransition_defaultnavigationtransitioninfo.md) is EntranceNavigationTransitionInfo.

### XAML attached properties

EntranceNavigationTransitionInfo is the host service class for a [XAML attached property](/windows/uwp/xaml-platform/attached-properties-overview).

In order to support XAML processor access to the attached properties, and also to expose equivalent _get_ and _set_ operations to code, each XAML attached property has a pair of Get and Set accessor methods. Another way to get or set the value in code is to use the dependency property system, calling either [GetValue](../windows.ui.xaml/dependencyobject_getvalue_1188551207.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue_52578133.md) and passing the identifier field as the dependency property identifier.

| Attached property | Description |
| - | - |
| IsTargetElement | Gets or sets a value that indicates whether the element is the target of the animation.<ul><li>Type: Boolean</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.media.animation.entrancenavigationtransitioninfo.istargetelementproperty">IsTargetElementProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.media.animation.entrancenavigationtransitioninfo.getistargetelement">GetIsTargetElement</a>, <a href="/uwp/api/windows.ui.xaml.media.animation.entrancenavigationtransitioninfo.setistargetelement">SetIsTargetElement</a></li></ul>

## -examples

## -see-also
[NavigationTransitionInfo](navigationtransitioninfo.md), [Frame.Navigate(Type, Object, NavigationTransitionInfo)](../windows.ui.xaml.controls/frame_navigate_1426351961.md)
