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

## -remarks
The **EntranceNavigationTransitionInfo** class represents the page refresh animation. Page refresh is a combination of a slide up animation and a fade in animation for the incoming content. 

With Windows 10, version 1803, a Frame uses [NavigationThemeTransition](navigationthemetransition.md) to animate navigation between Pages. By default, the animation is *Page Refresh* because the [DefaultNavigationTransitionInfo](navigationthemetransition_defaultnavigationtransitioninfo.md) is EntranceNavigationTransitionInfo.

## -examples

## -see-also
[NavigationTransitionInfo](navigationtransitioninfo.md), [Frame.Navigate(Type, Object, NavigationTransitionInfo)](../windows.ui.xaml.controls/frame_navigate_1426351961.md)