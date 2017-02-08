---
-api-id: P:Windows.UI.Xaml.Interop.NotifyCollectionChangedEventArgs.NewStartingIndex
-api-type: winrt property
---

<!-- Property syntax
public int NewStartingIndex { get; }
-->

# Windows.UI.Xaml.Interop.NotifyCollectionChangedEventArgs.NewStartingIndex

## -description
Gets the index at which the change occurred.

## -property-value
The index at which the change occurred.

## -remarks
When programming with .NET, this class is hidden and developers should use the [System.Collections.Specialized.NotifyCollectionChangedEventArgs](https://msdn.microsoft.com/library/system.collections.specialized.notifycollectionchangedeventargs.aspx) class.

[NewStartingIndex](notifycollectionchangedeventargs_newstartingindex.md) will contain the following values, depending on the [Action](notifycollectionchangedeventargs_action.md) being reported in the event data. <table>
   <tr><th>Action</th><th>Value</th></tr>
   <tr><td>**Add**</td><td>The index of the newly added item.</td></tr>
   <tr><td>**Move**</td><td>The index of the newly added item. Because a **Move** can logically be considered a virtual **Remove** followed by a virtual **Add**, the index reported here might already be adjusted for the virtual **Remove**.</td></tr>
   <tr><td>**Remove**</td><td>-1</td></tr>
   <tr><td>**Replace**</td><td>The index of the replaced item.</td></tr>
   <tr><td>**Reset**</td><td>-1</td></tr>
</table>

Note that this value is signed. This enables the -1 value cases.

## -examples

## -see-also
[XAML data binding sample](http://go.microsoft.com/fwlink/p/?linkid=226854)