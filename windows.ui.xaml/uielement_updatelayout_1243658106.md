---
-api-id: M:Windows.UI.Xaml.UIElement.UpdateLayout
-api-type: winrt method
---

<!-- Method syntax
public void UpdateLayout()
-->

# Windows.UI.Xaml.UIElement.UpdateLayout

## -description
Ensures that all positions of child objects of a [UIElement](uielement.md) are properly updated for layout.

## -remarks
[UpdateLayout](uielement_updatelayout.md) is basically equivalent to calling [InvalidateMeasure](uielement_invalidatemeasure.md) and [InvalidateArrange](uielement_invalidatearrange.md) in sequence.

Layout updates can be forced by app code rather than relying on the built-in layout system behavior by using the [UpdateLayout](uielement_updatelayout.md) method. However, that is not generally recommended. It is usually unnecessary and can cause poor performance if overused. In many situations where calling [UpdateLayout](uielement_updatelayout.md) from app code might be appropriate because of changes to properties, the layout system will probably already be processing updates. The layout system also has optimizations for dealing with cascades of layout changes through parent-child relationships, and calling [UpdateLayout](uielement_updatelayout.md) can work against such optimizations. Nevertheless, it's possible that layout situations exist in more complicated scenarios where calling [UpdateLayout](uielement_updatelayout.md) is the best option for resolving a timing issue or other issue with layout. Just use it deliberately and sparingly. In the cases where you do need to call [UpdateLayout](uielement_updatelayout.md) you're probably going to call it just after calling `Children.Add` on some collection of child elements of a common layout parent, then calling [UpdateLayout](uielement_updatelayout.md) on that parent to make the layout system recognize the new added child.

One scenario for [UpdateLayout](uielement_updatelayout.md) is when you have linked containers like [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md) and [RichTextBlockOverflow](../windows.ui.xaml.controls/richtextblockoverflow.md), you've made run-time changes to the content, and you want to make sure that operations not specifically tied to displaying the UI have a chance to run the layout and trigger the content rebalance between the linked containers. For example, you might want to do this to prepare a layout for printing. For an example of this scenario, see the #5 scenario in [Print sample](http://go.microsoft.com/fwlink/p/?linkid=242999).



> [!TIP]
> If you have a scenario where you use data binding to UI and you aren't seeing the layout reflect updates in your data source collections, calling [UpdateLayout](uielement_updatelayout.md) probably isn't going to help. It's more likely that you have issues with your binding declarations, the data context, or with the **INotifyPropertyChanged** or **INotifyCollectionChanged** support in your data source.

## -examples

## -see-also
[Arrange](uielement_arrange.md), [ArrangeOverride](frameworkelement_arrangeoverride.md), [InvalidateArrange](uielement_invalidatearrange.md), [Define layouts with XAML](http://msdn.microsoft.com/library/8d4e4162-1c9c-48f4-8a94-34976fb17079)