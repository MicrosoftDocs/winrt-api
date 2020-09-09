---
-api-id: T:Windows.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo
-api-type: winrt class
---

<!-- Class syntax.
public class ContinuumNavigationTransitionInfo : Windows.UI.Xaml.Media.Animation.NavigationTransitionInfo, Windows.UI.Xaml.Media.Animation.IContinuumNavigationTransitionInfo
-->

# Windows.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo

## -description
Specifies the object that will fly between pages to provide context during a continuum transition.

## -xaml-syntax
```xaml
<NavigationThemeTransition>
  <ContinuumNavigationTransitionInfo ... />
</NavigationThemeTransition>
```


## -remarks

### XAML attached properties

ContinuumNavigationTransitionInfo is the host service class for several [XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview).

In order to support XAML processor access to the attached properties, and also to expose equivalent _get_ and _set_ operations to code, each XAML attached property has a pair of Get and Set accessor methods. Another way to get or set the value in code is to use the dependency property system, calling either [GetValue](../windows.ui.xaml/dependencyobject_getvalue_1188551207.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue_52578133.md) and passing the identifier field as the dependency property identifier.

| Attached property | Description |
| - | - |
| ExitElementContainer | Gets or sets a value that indicates whether this element is the container of the exit element for the navigation transition.<ul><li>Type: Boolean</li><li>Identifier field: <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.media.animation.continuumnavigationtransitioninfo.exitelementcontainerproperty">ExitElementContainerProperty</a></li><li>Accessor methods: <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.media.animation.continuumnavigationtransitioninfo.getexitelementcontainer">GetExitElementContainer</a>, <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.media.animation.continuumnavigationtransitioninfo.setexitelementcontainer">SetExitElementContainer</a></li></ul> |
| IsEntranceElement | Gets or sets a value that indicates whether this element is the entrance element for the continuum navigation.<ul><li>Type: Boolean</li><li>Identifier field: <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.media.animation.continuumnavigationtransitioninfo.isentranceelementproperty">IsEntranceElementProperty</a></li><li>Accessor methods: <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.media.animation.continuumnavigationtransitioninfo.getisentranceelement">GetIsEntranceElement</a>, <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.media.animation.continuumnavigationtransitioninfo.setisentranceelement">SetIsEntranceElement</a></li></ul> |
| IsExitElement | Gets or sets a value that indicates whether this element is the exit element for the continuum navigation.<ul><li>Type: Boolean</li><li>Identifier field: <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.media.animation.continuumnavigationtransitioninfo.isexitelementproperty">IsExitElementProperty</a></li><li>Accessor methods: <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.media.animation.continuumnavigationtransitioninfo.getisexitelement">GetIsExitElement</a>, <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.media.animation.continuumnavigationtransitioninfo.setisexitelement">SetIsExitElement</a></li></ul> |

## -examples

## -see-also
[NavigationTransitionInfo](navigationtransitioninfo.md)