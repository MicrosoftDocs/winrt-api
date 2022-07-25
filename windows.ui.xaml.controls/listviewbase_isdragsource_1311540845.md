---
-api-id: M:Windows.UI.Xaml.Controls.ListViewBase.IsDragSource
-api-type: winrt method
---

<!-- Method syntax
public bool IsDragSource()
-->

# Windows.UI.Xaml.Controls.ListViewBase.IsDragSource

## -description
Returns a value that indicates whether the list view is both the drag source and drop target in a drag-and-drop operation.



## -returns
**true** if the list view is both the drag source and drop target; otherwise, **false**.

## -remarks
For more info, see [Drag and drop](/windows/uwp/design/input/drag-and-drop).

### Version compatibility

The IsDragSource method is not available prior to Windows 10, version 1607. If your app’s 'minimum platform version' setting in Microsoft Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you must design and test your app to account for this. For more info, see [Version adaptive code](/windows/uwp/debug-test-perf/version-adaptive-code).

To avoid exceptions when your app runs on previous versions of Windows 10, do not call this method without first performing a runtime check. This example shows how to use the [ApiInformation](../windows.foundation.metadata/apiinformation.md) class to check for the presence of this method before you use it.

```csharp
if (ApiInformation.IsMethodPresent("Windows.UI.Xaml.Controls.ListViewBase", "IsDragSource"))
{
    bool isDragSource = listView1.IsDragSource();
}

```



## -examples

## -see-also
