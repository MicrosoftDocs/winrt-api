---
-api-id: P:Windows.UI.Xaml.Media.Animation.ColorAnimation.By
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.UI.Color> By { get;  set; }
-->

# Windows.UI.Xaml.Media.Animation.ColorAnimation.By

## -description
Gets or sets the total amount by which the animation changes its starting value.



## -xaml-syntax
```xaml
<ColorAnimation By="colorString"/>
-or-
<ColorAnimation By="referenceToColor"/>
- or -
<ColorAnimation>
  <ColorAnimation.By>
    <Color>colorString</Color>
  </ColorAnimation.By>
</ColorAnimation>
```


## -xaml-values
<dl><dt>colorString</dt><dd>colorStringA color specified as a string, using a variety of possible formats, including predefined named colors. For the full list of available string formats that can specify a Color as an attribute, see Color.</dd>
<dt>referenceToColor</dt><dd>referenceToColorA {StaticResource} markup extension reference or other reference to an existing color.</dd>
</dl>
## -property-value
The total amount by which the animation changes its starting value. The default is null.

<!--Projection dochack:-->
If you are programming using C# or Visual Basic, the type of this property is projected as **Color?**(a nullable [Color](../windows.ui/color.md)).

## -remarks

When you use the By property to animate a color by the specified amount, the hexadecimal value of the By property is added to the hexadecimal value of the starting color. If you're using named colors, remember, the name just represents an _rgb_ value, and that value is what is being added.

For example, if you animate #FF0000 (Red) by #0000FF (Blue), the final color is #FF00FF (Fuchsia). However, if you animate #FF00FF (Fuchsia) by #0000FF (Blue), the final color is still #FF00FF (Fuchsia).

You can set the By property by itself or with the [From](coloranimation_from.md) property. If you set both the By and [To](coloranimation_to.md) properties, the By value is ignored and the animation ends with the To value.

+ **By only:** The animation progresses from the base value of the property being animated or a previous animation's output value to the sum of that value and the value specified by the [By](coloranimation_by.md) property.
+ **From and By:** The animation progresses from the value specified by the [From](coloranimation_from.md) property to the value specified by the sum of the [From](coloranimation_from.md) and [By](coloranimation_by.md) properties.

## -examples

```xaml
<StackPanel>
    <StackPanel.Resources>
        <Storyboard x:Name="colorStoryboard">
            <ColorAnimation Storyboard.TargetName="mySolidColorBrush"
                            Storyboard.TargetProperty="Color" Duration="0:0:4" 
                            By="#0000FF"/>
        </Storyboard>
    </StackPanel.Resources>

    <StackPanel Orientation="Horizontal">
        <Button Content="Animate color" Click="Start_Animation"/>
        <Rectangle Height="100" Width="300" Margin="12,0">
            <Rectangle.Fill>
                <SolidColorBrush x:Name="mySolidColorBrush" Color="#00FF00" />
            </Rectangle.Fill>
        </Rectangle>
    </StackPanel>
</StackPanel>
```

```csharp
private void Start_Animation(object sender, RoutedEventArgs e)
{
    colorStoryboard.Begin();
}
```

## -see-also
