---
-api-id: M:Windows.UI.Xaml.Controls.Grid.GetColumn(Windows.UI.Xaml.FrameworkElement)
-api-type: winrt method
---

<!-- Method syntax
public int GetColumn(Windows.UI.Xaml.FrameworkElement element)
-->

# Windows.UI.Xaml.Controls.Grid.GetColumn

## -description
Gets the value of the [Grid.Column](grid_column.md) XAML attached property from the specified [FrameworkElement](../windows.ui.xaml/frameworkelement.md).



## -parameters
### -param element
The element from which to read the property value.

## -returns
The value of the [Grid.Column](grid_column.md) XAML attached property on the target element. This is a zero-based index.

## -remarks
This method is a utility method for the property system, and isn't used in most app scenarios. In most cases you set the [Grid.Column](grid_column.md) XAML attached property in XAML and won't need this method. For more info, see the [Grid.Column](grid_column.md) XAML attached property.

## -examples
The following example shows how to get the row and column of the element that raised an event.


<!--   <p xml:space="preserve">
            <TRANSLATE_MANUALLY>
              <externalLink xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5">
                <linkText>Run this sample</linkText>
                <linkUri>http://go.microsoft.com/fwlink/p/?linkid=139798&amp;sref=GridGetSet</linkUri>
              </externalLink>
            </TRANSLATE_MANUALLY>
          </p>
 -->



[!code-xaml[1](../windows.ui.xaml.controls.primitives/code/GridGetSet/csharp/Page.xaml#Snippet1)]

[!code-csharp[2](../windows.ui.xaml.controls.primitives/code/GridGetSet/csharp/Page.xaml.cs#Snippet2)]
<!--     <desc><p xml:space="preserve">The preceding example produces output that is similar to the following illustration.</p>
      <TRANSLATE_MANUALLY>
        <mediaLink xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5">
          <image p8:href="25325562-3a82-4c66-97e9-3a7330b6a835" xmlns:p8="http://www.w3.org/1999/xlink"/>
        </mediaLink>
      </TRANSLATE_MANUALLY></desc>
 -->

## -see-also

[Grid.Column](grid_column.md), [Attached properties overview](/windows/uwp/xaml-platform/attached-properties-overview)
