---
-api-id: M:Windows.UI.Xaml.Controls.Frame.Navigate(Windows.UI.Xaml.Interop.TypeName,System.Object,Windows.UI.Xaml.Media.Animation.NavigationTransitionInfo)
-api-type: winrt method
---

<!-- Method syntax
public bool Navigate(Windows.UI.Xaml.Interop.TypeName sourcePageType, System.Object parameter, Windows.UI.Xaml.Media.Animation.NavigationTransitionInfo infoOverride)
-->

# Windows.UI.Xaml.Controls.Frame.Navigate

## -description
Causes the [Frame](frame.md) to load content represented by the specified [Page](page.md)-derived data type, also passing a parameter to be interpreted by the target of the navigation, and a value indicating the animated transition to use.



## -parameters
### -param sourcePageType
The page to navigate to, specified as a type reference to its partial class type. Must be a [Page](page.md)-derived data type; otherwise, an exception is thrown. (A type reference is given as [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) for Microsoft .NET, or a [TypeName](../windows.ui.xaml.interop/typename.md) helper struct for Visual C++ component extensions (C++/CX)).

### -param parameter
The navigation parameter to pass to the target page; must have a basic type (string, char, numeric, or [GUID](/windows/win32/api/guiddef/ns-guiddef-guid)) to support parameter serialization using [GetNavigationState](frame_getnavigationstate_1352043812.md).

### -param infoOverride
Info about the animated transition.

## -returns
**false** if a [NavigationFailed](frame_navigationfailed.md) event handler has set [Handled](../windows.ui.xaml.navigation/navigationfailedeventargs_handled.md) to **true**; otherwise, **true**. See Remarks for more info.

## -remarks

## -examples
```xaml
<Frame x:Name="myFrame">
    <Frame.ContentTransitions>
        <TransitionCollection>
            <NavigationThemeTransition />
        </TransitionCollection>
    </Frame.ContentTransitions>
</Frame>
```

```csharp
// Play the default animation
myFrame.Navigate(typeof(Page2), null);

// Explicitly play the page refresh animation
myFrame.Navigate(typeof(Page2), null, new EntranceNavigationTransitionInfo());

// Play the drill in animation
myFrame.Navigate(typeof(Page2), null, new DrillInNavigationTransitionInfo());

// Suppress the default animation
myFrame.Navigate(typeof(Page2), null, new SuppressNavigationTransitionInfo());
```

## -see-also
[Navigate(Type, Object)](frame_navigate_1603787821.md), [Navigate(Type)](frame_navigate_442648331.md), [Navigation](/windows/uwp/layout/navigation-basics)
