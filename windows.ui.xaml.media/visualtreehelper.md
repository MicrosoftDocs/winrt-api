---
-api-id: T:Windows.UI.Xaml.Media.VisualTreeHelper
-api-type: winrt class
---

<!-- Class syntax.
public class VisualTreeHelper : Windows.UI.Xaml.Media.IVisualTreeHelper
-->

# Windows.UI.Xaml.Media.VisualTreeHelper

## -description
Provides utility methods that can be used to traverse object relationships (along child-object or parent-object axes) in the visual tree of your app.



## -remarks
### The visual tree

The purpose of the VisualTreeHelper class is to help with discovery of objects that you are looking for in the runtime tree of objects, but there isn't a more direct object-relationship API available for your scenario. Sometimes, you won't know the exact type or name of the object. Or perhaps you know that a specific object appears somewhere in the tree but you don't know the exact position. For these types of scenarios, VisualTreeHelper is helpful because you can recursively find all the objects in the visual tree and then look through this set and look for a match based on your criteria.

The visual tree for an app can be conceptualized as a filtered representation of the larger object tree of an app's objects and properties. Only the objects that have a rendering implication are present in a visual tree. For example, a collection class would not be part of the visual tree. Instead, the visual tree abstracts any collection into a "children" concept.

However, the visual tree can also include objects that are not represented as XAML elements in a page's XAML markup. This is because the visual tree adds objects that are the composited parts of controls. These control parts can come from an applied control template, which is usually XAML from a resource dictionary item, or from a presenter.

XAML markup and a visual tree don't match exactly node-for-node because XAML is designed for markup, and ease of use during markup definition, so it sometimes has extra elements. For example, XAML has property elements, which sets property values if one element is found nested within another. In a visual tree, this would just look like a property on an object being set by another object. XAML also has a concept of a content property, where the property being set is not explicitly designated in markup. For more info on the specific terminology and the rules for XAML, see [XAML overview](/windows/uwp/xaml-platform/xaml-overview).

The visual tree is used internally for the UI rendering process, but knowing the structure of the visual tree is important for certain scenarios, such as writing or replacing a control template, or analysis of a control's structure and parts at run-time. For these scenarios, the Windows Runtime provides the VisualTreeHelper  API that can examine the visual tree in a more generalized way. (You could theoretically construct such a tree using object-specific parent and children properties too, but you'd have to know exactly which properties each element supported, and that's difficult to discover or manage.)

You typically combine several VisualTreeHelper API calls to write your own helper functions that investigate the visual tree in ways that are specific to your own app's scenarios.

### Traversing a visual tree

Traversing the object tree (sometimes known colloquially as *walking the tree*) is a common technique in object models. You use properties that either reference child objects (typically these are collections) or parent relationships to a containing object (usually this is done from within a collection, and returns the collection itself). As a rough description of the process, you call a succession of child properties and parent properties, or perhaps helper methods, to navigate the axes of the object tree until you retrieve a value that contains the object that you were looking for. As a general rule, you should be able to construct your content in XAML such that you do not need to query the structure of the tree extensively. To avoid the need to traverse the tree, you should give XAML elements a value for the **x:Name** / **Name** attribute in the XAML markup that creates them. This creates an immediate reference that is available for run-time code access, and that's a much less error-prone technique for getting object references than walking the tree is. Alternatively, if you are creating objects through code rather than XAML, you should declare private fields or variables that retain object reference at run-time. There's typically no need to traverse the tree to find objects that are created in your own code.

However, there are cases where it is not possible or practical to give an object a name and keep an object reference in scope. One such scenario is if you are adding dynamic content that is supplied by the user or supplied by data binding, or using view models and business objects. In these cases you cannot always predict the number of items added or the structure of a control and its children. Another scenario is examining an applied template for a control, or a composited section of a control or presenter content.

Traversing the tree downwards (away from the root) multiple levels can be done using [GetChildrenCount](visualtreehelper_getchildrencount_1601318699.md) for nonzero values and then [GetChild](visualtreehelper_getchild_2017450836.md) to request a specific index. You might have to use **try/catch** techniques or the equivalent if you are trying to cast elements as specific [UIElement](../windows.ui.xaml/uielement.md) subtypes. Generally the VisualTreeHelper  API return elements as a [DependencyObject](../windows.ui.xaml/dependencyobject.md) and you will need to cast it in order to do anything useful (even for as simple an operation as checking its **Name** value).

### Notes for previous versions

> **Windows 8**

<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 462593-->
#### UI threading

Windows 8 permitted VisualTreeHelper function calls that were referencing objects on the wrong (not the current) UI thread. Starting with Windows 8.1, the function throws an exception if it's not being called from the current UI thread. Accounting for this new behavior should be a very uncommon app migration scenario; it's difficult to get UI elements across threads in the first place.

Apps that were compiled for Windows 8 but running on Windows 8.1 use the Windows 8.1 behavior, and will throw specifically on the VisualTreeHelper function call rather than on any downstream app code that uses a cross-thread object.

<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 461907-->
#### App UI for On-Screen Keyboard

Windows 8 had an internally implemented logic that would associate a [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) with the overall app UI whenever the user invokes the On-Screen Keyboard. This On-Screen Keyboard is a specific accessibility feature that users request through the Ease of Access Center. It's not the same as the soft keyboard that can appear in app UI for text input controls, if the system detects no keyboard device. What the internal [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) does here is to make it possible to scroll the area where the app is, if scrolling it is forced because the keyboard is taking UI space.

Starting with Windows 8.1, the system still has UI/layout behavior when the On-Screen Keyboard appears, but it no longer uses this internally created [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md). Instead it uses a dedicated internal control that app code can't change or inspect.

Most aspects of this behavior change don't affect apps at all. However, your app might have anticipated this behavior, by providing an implicit [Style](../windows.ui.xaml/style.md) for [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) that's meant to change the layout, or by walking the tree with VisualTreeHelper to find this internally created [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) and alter it at run-time. For an app that is compiled for Windows 8.1 that code won't be useful.

Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use the Windows 8 behavior.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1903 | 18362 | GetOpenPopupsForXamlRoot |

## -examples
Here's an example of a utility function that can copy a list of child elements of a particular type from within a visual tree. It uses the basic traversal methods [GetChildrenCount](visualtreehelper_getchildrencount_1601318699.md) and [GetChild](visualtreehelper_getchild_2017450836.md). It uses recursion so that elements can be found no matter what level of nesting within intermediate containers exists. It also uses an **IsSubclassOf** extension method from [System.Reflection](/dotnet/api/system.reflection?view=dotnet-uwp-10.0&preserve-view=true) that extends the type comparison to consider subtypes as a match for a [Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true).

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
[Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10)), [XAML namescopes](/windows/uwp/xaml-platform/xaml-namescopes), [Controls by function](/windows/uwp/controls-and-patterns/controls-by-function)
