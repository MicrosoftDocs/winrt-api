---
-api-id: M:Windows.UI.Xaml.Media.VisualTreeHelper.GetChildrenCount(Windows.UI.Xaml.DependencyObject)
-api-type: winrt method
---

<!-- Method syntax
public int GetChildrenCount(Windows.UI.Xaml.DependencyObject reference)
-->

# Windows.UI.Xaml.Media.VisualTreeHelper.GetChildrenCount

## -description
Returns the number of children that exist in an object's child collection in the visual tree.



## -parameters
### -param reference
The source visual.

## -returns
The number of visual children for the provided source visual.

## -remarks

## -examples
Here's an example of a utility function that can copy a list of child elements of a particular type from within a visual tree. It uses the basic traversal methods GetChildrenCount and [GetChild](visualtreehelper_getchild_2017450836.md). It uses recursion so that elements can be found no matter what level of nesting within intermediate containers exists. It also uses an **IsSubclassOf** extension method from [System.Reflection](/dotnet/api/system.reflection?view=dotnet-uwp-10.0&preserve-view=true) that extends the type comparison to consider subtypes as a match for a [Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true).

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
