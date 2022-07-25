---
-api-id: P:Windows.UI.Xaml.Media.Animation.RepositionThemeTransition.IsStaggeringEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsStaggeringEnabled { get;  set; }
-->

# Windows.UI.Xaml.Media.Animation.RepositionThemeTransition.IsStaggeringEnabled

## -description
Gets or sets a value that determines whether the transition staggers rendering of multiple items, or renders all items at once.



## -xaml-syntax
```xaml
<RepositionThemeTransition IsStaggeringEnabled="bool"/>
```

## -property-value
**true** if the animation staggers rendering of multiple items. **false** if the animation renders all items at once. The default is **true**.

## -remarks
Available starting in Windows 10, version 1607.

The [ListView](../windows.ui.xaml.controls/listview.md) control utilizes the [RepositionThemeTransition](repositionthemetransition.md) to animate items when an item’s position changes. Unlike some of the other theme transitions, when more than one item’s position changes, the [RepositionThemeTransition](repositionthemetransition.md) staggers the animation across the collection. (The second item lags slightly behind the first item, the third behind the second, etc.) Set this property to **false** to make all items render at once.

## -examples
This example shows how to use a [RepositionThemeTransition](repositionthemetransition.md) with a [ListView](../windows.ui.xaml.controls/listview.md).

```xaml
<ListView>
    <ListView.ItemContainerTransitions>
        <TransitionCollection>
            <!-- Animate when items are removed, 
                 but don't stagger the animation across columns. -->
            <RepositionThemeTransition IsStaggeringEnabled="False"/>
        </TransitionCollection>
    </ListView.ItemContainerTransitions>
</ListView>
```

```csharp
var lv = new ListView();
var transition = new RepositionThemeTransition();
transition.IsStaggeringEnabled = false;
lv.ItemContainerTransitions.Add(transition);
```

```cppwinrt
Windows::UI::Xaml::Controls::ListView lv;
Windows::UI::Xaml::Media::Animation::RepositionThemeTransition transition;
transition.IsStaggeringEnabled(false);
lv.ItemContainerTransitions().Append(transition);
```

```cppcx
auto lv = ref new ListView();
auto transition = ref new RepositionThemeTransition();
transition->IsStaggeringEnabled = false;
lv->ItemContainerTransitions->Append(transition);
```

## -see-also
