---
-api-id: T:Windows.UI.Xaml.Media.Animation.ContentThemeTransition
-api-type: winrt class
---

<!-- Class syntax.
public class ContentThemeTransition : Windows.UI.Xaml.Media.Animation.Transition, Windows.UI.Xaml.Media.Animation.IContentThemeTransition
-->

# Windows.UI.Xaml.Media.Animation.ContentThemeTransition

## -description
Provides the animated transition behavior for when the content of a control is changing. This might be applied in addition to [AddDeleteThemeTransition](adddeletethemetransition.md).

## -xaml-syntax
```xaml
<ContentThemeTransition ... />
```


## -remarks
Note that setting the [Duration](timeline_duration.md) property has no effect on this object since the duration is preconfigured.

## -examples
The following example applies a [ContentThemeAnimation](contentthemetransition.md) to a rectangle.

```xaml

<!-- The ContentThemeTransition will execute when the ContentControl’s content changes. -->        
<ContentControl x:Name="ContentHost" PointerPressed="ContentHost_PointerPressed">
    <ContentControl.ContentTransitions>
        <TransitionCollection>
            <ContentThemeTransition/>
        </TransitionCollection>
    </ContentControl.ContentTransitions>
    <Rectangle Height="200" Width="200" Fill="Orange"/>
</ContentControl>
```

```csharp
private void ContentHost_PointerPressed(object sender, PointerRoutedEventArgs e)
{
    // Replace the ContentControl's content with a new Rectangle of a random color.
    Rectangle newItem = new Rectangle();
    Random rand = new Random();
            
    newItem.Height = 200;
    newItem.Width = 200;
    newItem.Fill = new SolidColorBrush(Color.FromArgb(255, 
         (byte)rand.Next(0, 255), (byte)rand.Next(0,255), (byte)rand.Next(0, 255)));

    ContentHost.Content = newItem; 
}
```

```cpp
void MyPage::ContentHost_PointerPressed(Object^ sender, PointerRoutedEventArgs^ e)
{
    // Replace the ContentControl's content with a new Rectangle of a random color.
    Rectangle^ newItem = ref new Rectangle();
            
    newItem->Height = 200;
    newItem->Width = 200;

    Color color;
    color.R = rand() % 256;
    color.G = rand() % 256;
    color.B = rand() % 256;

    newItem->Fill = ref new SolidColorBrush(color);

    ContentHost->Content = newItem; 
}
```



## -see-also
[Transition](transition.md), [Animating content transitions](http://msdn.microsoft.com/library/57659b10-39c2-4ff4-95ff-51a349d01911), [Guidelines and checklist for content transition animations](http://msdn.microsoft.com/library/0188fdb4-e183-466f-8a03-ee3ff5c474b1)