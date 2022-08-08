---
-api-id: M:Windows.UI.Xaml.Markup.XamlReader.Load(System.String)
-api-type: winrt method
---

<!-- Method syntax
public object Load(System.String xaml)
-->

# Windows.UI.Xaml.Markup.XamlReader.Load

## -description
Parses a well-formed XAML fragment and creates a corresponding object tree, and returns the root of the object tree.


## -parameters
### -param xaml
A string that contains a valid XAML fragment.

## -returns
The root object of the created object tree.

## -remarks
[XamlReader](xamlreader.md) provides object construction behavior that parallels how XAML is parsed by the Windows Runtime XAML parser and the use of XAML for defining the UI of a UWP app. Parsing the XAML input with XamlReader.Load generates run-time object trees of Windows Runtime objects. The object tree provides a way to program against those objects at run time, by walking through parts of the complete tree.

There are several concepts that are important to understand, when you create objects from XAML with the XamlReader.Load method:


+ The XAML content string must define a single root element.
+ The XAML content string must be well-formed XML, as well as being valid XAML.
+ The XAML content must define a default xmlns. Typically this is the Windows Runtime XAML vocabulary, as identified by `http://schemas.microsoft.com/winfx/2006/xaml/presentation`.
+ Any custom assemblies referenced in a XAML namespace mapping must already be available to the application.
+ The XAML should not attempt to specify [x:Class attribute](/windows/uwp/xaml-platform/x-class-attribute), or include any XAML-defined attributes for event handlers.
+ You can't use [FindName](../windows.ui.xaml/frameworkelement_findname_634111277.md) in the general XAML namescope to find a runtime object added, but you can search within the specific XAML namescope of the object created. For more info, see [XAML namescopes](/windows/uwp/xaml-platform/xaml-namescopes).
+ Object creation logic cannot integrate the loaded XAML with code-behind classes at run time. If you want to add event handlers, you must do so in code by referencing objects obtained from within the object tree structure of the Load result, and using language-specific syntax for attaching handlers (such as `+=`).
+ There must be existing XAML content; you cannot replace the entire tree of content. You must at the very least preserve the original root element so that the app model implications of a loaded XAML page remain active.
+ The object that is created from Load can be assigned to only one location in the primary object tree. If you want to add objects created from identical XAML to different areas of the application's primary object tree, you must parse the XAML multiple times using the same input string, using different destinations for the return value.
+ The primary object tree remaining must support an appropriate property to set.


## -examples
This example creates a single [Ellipse](../windows.ui.xaml.shapes/ellipse.md) from a XAML string, calling Load. Then it connects the created but disconnected [Ellipse](../windows.ui.xaml.shapes/ellipse.md) to the [Children](../windows.ui.xaml.controls/panel_children.md) collection of an element that already existed in the running UWP app. Finally the example accesses the [Ellipse](../windows.ui.xaml.shapes/ellipse.md) again in the location where it was added by using a query, and changes one of its properties.

```csharp
string xaml =
"<Ellipse Name=\"EllipseAdded\" Width=\"300.5\" Height=\"200\" 
Fill=\"Red\" xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"/>";
object ellipse = XamlReader.Load(xaml);
//stackPanelRoot is the visual root of a Page in existing XAML markup already loaded by the appmodel
stackPanelRoot.Children.Add(ellipse as UIElement);
//walk the tree using XLinq result and cast back to a XAML type to set a property on it at runtime
var result = (from item in stackPanelRoot.Children
  where (item is FrameworkElement) 
  && ((FrameworkElement) item).Name == "EllipseAdded"
  select item as FrameworkElement).FirstOrDefault();
((Ellipse) result).Fill = new SolidColorBrush(Colors.Yellow);
```



## -see-also
[XAML syntax guide](/windows/uwp/xaml-platform/xaml-syntax-guide), [XAML overview](/windows/uwp/xaml-platform/xaml-overview)
