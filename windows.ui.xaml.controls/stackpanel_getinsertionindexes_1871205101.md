---
-api-id: M:Windows.UI.Xaml.Controls.StackPanel.GetInsertionIndexes(Windows.Foundation.Point,System.Int32@,System.Int32@)
-api-type: winrt method
---

<!-- Method syntax
public void GetInsertionIndexes(Windows.Foundation.Point position, System.Int32 first, System.Int32 second)
-->

# Windows.UI.Xaml.Controls.StackPanel.GetInsertionIndexes

## -description
Returns the index values of the items that the specified point is between.



## -parameters
### -param position
The point for which to get insertion indexes.

### -param first
The index of the item before the specified point.

### -param second
The index of the item after the specified point.

## -remarks
Call this method when handling a [DragOver](../windows.ui.xaml/uielement_dragover.md) event to return the indices of the two items between which the [DragOver](../windows.ui.xaml/uielement_dragover.md) is happening and where a potential drop and insertion would happen.

### Version compatibility

The GetInsertionIndexes method is not available prior to Windows 10, version 1607. If your app’s 'minimum platform version' setting in Microsoft Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you must design and test your app to account for this. For more info, see [Version adaptive code](/windows/uwp/debug-test-perf/version-adaptive-code).

To avoid exceptions when your app runs on previous versions of Windows 10, do not call this method without first performing a runtime check. This example shows how to use the [ApiInformation](../windows.foundation.metadata/apiinformation.md) class to check for the presence of this method before you use it.

```xaml
<StackPanel AllowDrop="True" DragOver="StackPanel_DragOver">
```

```csharp
private void StackPanel_DragOver(object sender, DragEventArgs e)
{
    if (ApiInformation.IsMethodPresent("Windows.UI.Xaml.Controls.StackPanel", "GetInsertionIndexes"))
    {
        StackPanel stackPanel = sender as StackPanel;
        if (stackPanel != null)
        {
            int preceedingIndex;
            int subsequentIndex;
            stackPanel.GetInsertionIndexes(e.GetPosition(stackPanel), out preceedingIndex, out subsequentIndex);
        }
    }
}

```



## -examples

## -see-also
