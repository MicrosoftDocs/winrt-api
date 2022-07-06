---
-api-id: T:Windows.UI.Xaml.Media.Animation.ReorderThemeTransition
-api-type: winrt class
---

<!-- Class syntax.
public class ReorderThemeTransition : Windows.UI.Xaml.Media.Animation.Transition, Windows.UI.Xaml.Media.Animation.IReorderThemeTransition
-->

# Windows.UI.Xaml.Media.Animation.ReorderThemeTransition

## -description
Provides the animated transition behavior for when list-view controls items change order. Typically this is due to a drag-drop operation. Different controls and themes potentially have varying characteristics for the animations involved.



## -xaml-syntax
```xaml
<ReorderThemeTransition .../>
```

## -remarks
Note that setting the [Duration](timeline_duration.md) property has no effect on this object since the duration is preconfigured.

## -examples
The following example applies a ReorderThemeAnimation to a set of rectangles. As the new rectangles are added to the set, the other rectangles animate around the new one.

```xaml
<StackPanel>
    <Button x:Name="AddItemButton" Content="AddItem" Click="AddItemButton_Click"/>
    <ItemsControl x:Name="ItemsList">
        <ItemsControl.ItemsPanel>
            <ItemsPanelTemplate>
                <WrapGrid>
                    <WrapGrid.ChildrenTransitions>
<!-- Apply a ReorderThemeTransition that will run when child elements are reordered. -->
                        <TransitionCollection>
                            <ReorderThemeTransition/>
                        </TransitionCollection>
                    </WrapGrid.ChildrenTransitions>
                </WrapGrid>
            </ItemsPanelTemplate>
        </ItemsControl.ItemsPanel>
        <!-- Initial items. -->
        <Rectangle Width="100" Height="100" Fill="Red"/>
        <Rectangle Width="100" Height="100" Fill="Green"/>
        <Rectangle Width="100" Height="100" Fill="Blue"/>            
    </ItemsControl>            
</StackPanel>
```

```csharp
private void AddItemButton_Click(object sender, RoutedEventArgs e)
{
    Rectangle newItem = new Rectangle();
    Random rand = new Random();

    newItem.Height = 100;
    newItem.Width = 100;
    newItem.Fill = new SolidColorBrush(Color.FromArgb(255,
            (byte)rand.Next(0, 255), (byte)rand.Next(0, 255), (byte)rand.Next(0, 255)));

    // Insert a new Rectangle of a random color into the ItemsControl at index 2.
    ItemsList.Items.Insert(2, newItem);
}
```

```cppwinrt
void DocsCppWinRT::MainPage::AddItemButton_Click(Windows::Foundation::IInspectable const& sender, Windows::UI::Xaml::RoutedEventArgs const& e)
{
    Windows::UI::Xaml::Shapes::Rectangle newItem;

    newItem.Height(100);
    newItem.Width(100);

    Windows::UI::Color color;
    color.R = std::rand() % 256;
    color.G = std::rand() % 256;
    color.B = std::rand() % 256;

    newItem.Fill(Windows::UI::Xaml::Media::SolidColorBrush(color));

    // Insert a new Rectangle of a random color into the ItemsControl at index 2.
    ItemsList().Items().InsertAt(2, newItem);
}
```

```cppcx
void DocsCPP::MainPage::AddItemButton_Click(Object^ sender,RoutedEventArgs^ e)
{
    Rectangle^ newItem = ref new Rectangle();
            
    newItem->Height = 100;
    newItem->Width = 100;

    Color color;
    color.R = rand() % 256;
    color.G = rand() % 256;
    color.B = rand() % 256;

    newItem->Fill = ref new SolidColorBrush(color);

    // Insert a new Rectangle of a random color into the ItemsControl at index 2.
    ItemsList->Items->InsertAt(2, newItem);
}
```

## -see-also
[Transition](transition.md)
