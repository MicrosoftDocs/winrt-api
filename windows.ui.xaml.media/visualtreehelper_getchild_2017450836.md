---
-api-id: M:Windows.UI.Xaml.Media.VisualTreeHelper.GetChild(Windows.UI.Xaml.DependencyObject,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.DependencyObject GetChild(Windows.UI.Xaml.DependencyObject reference, System.Int32 childIndex)
-->

# Windows.UI.Xaml.Media.VisualTreeHelper.GetChild

## -description
Using the provided index, obtains a specific child object of the provided object by examining the visual tree.



## -parameters
### -param reference
The object that holds the child collection.

### -param childIndex
The index of the requested child object in the *reference* child collection.

## -returns
The child object as referenced by *childIndex*.

## -remarks

## -examples
Here's an example of a utility function that can copy a list of child elements of a particular type from within a visual tree. It uses the basic traversal methods [GetChildrenCount](visualtreehelper_getchildrencount_1601318699.md) and GetChild. It uses recursion so that elements can be found no matter what level of nesting within intermediate containers exists. It also uses an **IsSubclassOf** extension method from [System.Reflection](/dotnet/api/system.reflection?view=dotnet-uwp-10.0&preserve-view=true) that extends the type comparison to consider subtypes as a match for a [Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true).

```csharp
internal static void FindChildren<T>(List<T> results, DependencyObject startNode)
  where T : DependencyObject
{
    int count = VisualTreeHelper.GetChildrenCount(startNode);
    for (int i = 0; i < count; i++)
    {
        DependencyObject current = VisualTreeHelper.GetChild(startNode, i);
        if ((current.GetType()).Equals(typeof(T)) || (current.GetType().GetTypeInfo().IsSubclassOf(typeof(T))))
        {
            T asType = (T)current;
            results.Add(asType);
        }
        FindChildren<T>(results, current);
    }
}
```



## -see-also
