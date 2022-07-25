---
-api-id: P:Windows.UI.Xaml.FrameworkElement.Margin
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Thickness Margin { get;  set; }
-->

# Windows.UI.Xaml.FrameworkElement.Margin

## -description
Gets or sets the outer margin of a [FrameworkElement](frameworkelement.md).



## -xaml-syntax
```xaml
<frameworkElement Margin="uniform"/>
- or -
<frameworkElement Margin="left+right,top+bottom"/>
- or -
<frameworkElement Margin="left,top,right,bottom"/>
 
```


## -xaml-values
<dl><dt>uniform
</dt><dd>uniform A value measured in pixels that specifies a uniform Thickness. The uniform value is applied to all four Thickness properties (Left, Top, Right, Bottom).</dd>
<dt>left+right
</dt><dd>left+right A value measured in pixels that specifies the Left and Right of a symmetrical Thickness.</dd>
<dt>top+bottom</dt><dd>top+bottomA value measured in pixels that specifies the Top and Bottom of a symmetrical Thickness.</dd>
<dt>left top right bottom
</dt><dd>left top right bottom Values measured in pixels that specify the four possible dimension properties of a Thickness (Left, Top, Right, Bottom). In the XAML syntaxes shown previously, you can also use a space instead of a comma as the delimiter between values.</dd>
</dl>
## -property-value
Provides margin values for the object. The default value is a default [Thickness](thickness.md) with all properties (dimensions) equal to 0.

## -remarks
### Margin behavior and layout

A margin value greater than 0 applies space outside the object's [ActualWidth](frameworkelement_actualwidth.md) and [ActualHeight](frameworkelement_actualheight.md).

Margins are additive for peer objects in a layout; for example, two horizontally or vertically adjacent objects both with a margin of 30 set on the adjoining edge would have 60 pixels of space between them.

Objects that have margins set will not typically constrain the size of the specified Margin if the allotted rectangle space is not large enough for the margin plus the object's content area. The content area will be constrained instead when layout is calculated. The only case where margins would be constrained also is if the content is already constrained all the way to zero. However, this behavior is ultimately controlled by the specific type that is interpreting Margin, as well as the layout container of that object.

Negative values for margin dimensions are permitted, but should be used with caution (and be aware that negative margins can be interpreted differently by different class layout implementations). Negative margins typically clip the content of the object in that direction.

Non-integral values for margin values are technically permitted, but should typically be avoided.


<!--There is no prescribed upper bound for margin dimensions, and it is possible (though rarely desirable) to set a margin that positions object content outside the content area so that the object content does not display in view.

-->

### Margin and Padding

A related concept is padding. For an object and its bounding box, the margin is extra space that is allocated to the outside of the bounding box when the UI element is contained and rendered. Padding is the area inside the bounding box, and affects the layout of any additional content or child objects inside the element. [FrameworkElement](frameworkelement.md) does not define a padding property, However, several derived classes do define a **Padding** property. These include:
+ [Border.Padding](../windows.ui.xaml.controls/border_padding.md)
+ [Control.Padding](../windows.ui.xaml.controls/control_padding.md)
+ [TextBlock.Padding](../windows.ui.xaml.controls/textblock_padding.md)
+ [RichTextBlock.Padding](../windows.ui.xaml.controls/richtextblock_padding.md)
+ [ItemsPresenter.Padding](../windows.ui.xaml.controls/itemspresenter_padding.md)
 For more info about the relationship between margin and padding, see [Alignment, margin, and padding](/windows/uwp/layout/alignment-margin-padding) or [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml).

## -examples
This example sets Margin in code as part of a larger scenario of creating a UI element at run time, and then setting various layout-related properties. This is often done prior to adding a new element to an existing XAML UI page's object tree. In this case several Margin properties are set using a new [Thickness](thickness.md) created with the uniform-value constructor.



[!code-csharp[GridClassCode](../windows.ui.xaml/code/GridReferenceSample/csharp/Page.xaml.cs#SnippetGridClassCode)]

[!code-vb[GridClassCode](../windows.ui.xaml/code/GridReferenceSample/vbnet/Page.xaml.vb#SnippetGridClassCode)]

## -see-also
[Thickness](thickness.md), [Alignment, margin, and padding](/windows/uwp/layout/alignment-margin-padding), [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml)
4162-1c9c-48f4-8a94-34976fb17079)
