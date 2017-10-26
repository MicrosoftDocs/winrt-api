---
-api-id: T:Windows.UI.Xaml.FrameworkElement
-api-type: winrt class
---

<!-- Class syntax.
public class FrameworkElement : Windows.UI.Xaml.UIElement, Windows.UI.Xaml.IFrameworkElement, Windows.UI.Xaml.IFrameworkElement2, Windows.UI.Xaml.IFrameworkElement3, Windows.UI.Xaml.IFrameworkElement4, Windows.UI.Xaml.IFrameworkElementOverrides, Windows.UI.Xaml.IFrameworkElementOverrides2
-->

# Windows.UI.Xaml.FrameworkElement

## -description
Provides a base element class for Windows Runtime UI objects. [FrameworkElement](frameworkelement.md) defines common API that support UI interaction and the automatic layout system. [FrameworkElement](frameworkelement.md)  also defines API related to data binding, defining and examining the object tree, and tracking object lifetime.

## -remarks
[FrameworkElement](frameworkelement.md) is a base element: it's a class that many other Windows Runtime classes inherit from in order to support the XAML UI element model. Properties, methods and events that [FrameworkElement](frameworkelement.md) defines are inherited by hundreds of other Windows Runtime classes.

Many common XAML UI classes derive from [FrameworkElement](frameworkelement.md), either directly or through intermediate base classes such as [Panel](../windows.ui.xaml.controls/panel.md) or [Control](../windows.ui.xaml.controls/control.md). Typically, you don't derive classes directly from [FrameworkElement](frameworkelement.md), because certain expected services for a class that is intended for a UI representation (such as template support) are not fully implemented there. More commonly used base classes for derived custom classes are:


+ Specific controls that are not sealed (for example, [TextBox](../windows.ui.xaml.controls/textbox.md)).
+ Control base classes ([Control](../windows.ui.xaml.controls/control.md), [ContentControl](../windows.ui.xaml.controls/contentcontrol.md), [UserControl](../windows.ui.xaml.controls/usercontrol.md)).
+ Navigation elements ([Page](../windows.ui.xaml.controls/page.md), [Frame](../windows.ui.xaml.controls/frame.md)).
+ Panel classes (the base class [Panel](../windows.ui.xaml.controls/panel.md), or specific non-sealed implementations such as [Grid](../windows.ui.xaml.controls/grid.md)).


### **FrameworkElement** API and features

[FrameworkElement](frameworkelement.md) extends [UIElement](uielement.md), which is another base element, and adds support for various Windows Runtime feature areas.

### Layout

The layout system recognizes all objects that derive from [FrameworkElement](frameworkelement.md) to be elements that potentially participate in layout and should have a display area in the app UI. The layout system reads various properties that are defined at [FrameworkElement](frameworkelement.md) level, such as [MinWidth](frameworkelement_minwidth.md). Most UI elements use the [FrameworkElement](frameworkelement.md)-defined [Width](frameworkelement_width.md) and [Height](frameworkelement_height.md) for their basic sizing information. [FrameworkElement](frameworkelement.md) provides extensible methods for specialized layout behavior that panels and controls with content can override in their class implementations. For more info, see [Define layouts with XAML](http://msdn.microsoft.com/library/8d4e4162-1c9c-48f4-8a94-34976fb17079).

Prominent API of [FrameworkElement](frameworkelement.md) that support layout: [Height](frameworkelement_height.md), [Width](frameworkelement_width.md), [ActualHeight](frameworkelement_actualheight.md), [ActualWidth](frameworkelement_actualwidth.md), [Margin](frameworkelement_margin.md), [MeasureOverride](frameworkelement_measureoverride.md), [ArrangeOverride](frameworkelement_arrangeoverride.md), [HorizontalAlignment](frameworkelement_horizontalalignment.md), [VerticalAlignment](frameworkelement_verticalalignment.md), [LayoutUpdated](frameworkelement_layoutupdated.md).

### Object lifetime events

You often want to know when an object is first loaded (*loaded* is defined as when an object becomes attached to an object tree that connects to the root visual). [FrameworkElement](frameworkelement.md) defines events related to object lifetime that provide useful hooks for code-behind operations. For example you need object lifetime info to add child objects to a collection or set properties on child objects just prior to use, with assurance that the necessary objects in the object tree have already been instantiated from XAML markup. For more info, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

Prominent API of [FrameworkElement](frameworkelement.md) that support object lifetime events: [Loaded](frameworkelement_loaded.md), [SizeChanged](frameworkelement_sizechanged.md), [Unloaded](frameworkelement_unloaded.md), [OnApplyTemplate](frameworkelement_onapplytemplate.md).

### Data binding

The ability to set a value for a potentially inherited data context for a data binding is implemented by [FrameworkElement](frameworkelement.md). [FrameworkElement](frameworkelement.md) also has API for establishing data binding in code rather than in XAML. For more info, see [Data binding in depth](http://msdn.microsoft.com/library/41e1b4f1-6caf-4128-a61a-4e400b149011).

Prominent API of [FrameworkElement](frameworkelement.md) that support data binding: [DataContext](frameworkelement_datacontext.md), [DataContextChanged](frameworkelement_datacontextchanged.md), [SetBinding](frameworkelement_setbinding.md), [GetBindingExpression](frameworkelement_getbindingexpression.md).

### XAML language and programming model integration

Usually your app's element structure resembles the XAML markup that you defined to create the UI, but sometimes that structure changes after the XAML was parsed. [FrameworkElement](frameworkelement.md) defines the [Name](frameworkelement_name.md) property and related API, which are useful for finding elements and element relationships at run-time. For more info, see [XAML namescopes](http://msdn.microsoft.com/library/eb060cbd-a589-475e-b83d-b24068b54c21).

Prominent API of [FrameworkElement](frameworkelement.md) that support XAML and programming model: [Name](frameworkelement_name.md), [FindName](frameworkelement_findname.md), [Parent](frameworkelement_parent.md), [BaseUri](frameworkelement_baseuri.md), [OnApplyTemplate](frameworkelement_onapplytemplate.md).

### Globalization

The [FrameworkElement](frameworkelement.md) class defines the [Language](frameworkelement_language.md) property and the [FlowDirection](frameworkelement_flowdirection.md) property. For more info, see [Globalizing your app](http://msdn.microsoft.com/library/fc8fa294-98ac-4fd0-a445-cd252e84cd65).

### Style and theme support

The [FrameworkElement](frameworkelement.md) class defines the [Style](style.md) property and the [RequestedTheme](frameworkelement_requestedtheme.md) property. Also, the [Resources](frameworkelement_resources.md) property is used to define the page-level XAML resource dictionaries that typically define styles and templates, as well as other shared resources. For more info, see [Styling controls](http://msdn.microsoft.com/library/ab469a46-faf5-42d0-9340-948d0edf4150) and [ResourceDictionary and XAML resource references](http://msdn.microsoft.com/library/e3cbfa3d-6af5-44e1-b9f9-c3d3ea8a25ce).
<!--link for req theme?-->

### **FrameworkElement** dependency properties

Many of the read-write properties of the [FrameworkElement](frameworkelement.md) base element class are dependency properties. Dependency properties support some of the basic programming model features for a UWP app using C++, C#, or Visual Basic, such as styles and templates, data binding, XAML resource references, and property-changed logic. For more info on dependency properties and the features they support, see [Dependency properties overview](http://msdn.microsoft.com/library/ad649e66-f71c-4daa-9994-617c886fda7e).

### **FrameworkElement** derived classes

[FrameworkElement](frameworkelement.md) is the parent class for several immediately derived classes that distinguish several broad classifications of UI elements. Here are some of the notable derived classes:

+ [Control](../windows.ui.xaml.controls/control.md): [Control](../windows.ui.xaml.controls/control.md) has many more derived control classes, basically all of the XAML controls that you use for a Windows Runtime UI are derived from [Control](../windows.ui.xaml.controls/control.md).
+ Presenters: A presenter is a class that imparts a visual appearance, usually by contributing to some control scenario, but the presenter itself isn't typically interactive. For example: [Border](../windows.ui.xaml.controls/border.md), [ContentPresenter](../windows.ui.xaml.controls/contentpresenter.md) (parent of [ScrollContentPresenter](../windows.ui.xaml.controls/scrollcontentpresenter.md) and others), [ItemsPresenter](../windows.ui.xaml.controls/itemspresenter.md), [Viewbox](../windows.ui.xaml.controls/viewbox.md).
+ Media and web elements: [Image](../windows.ui.xaml.controls/image.md), [WebView](../windows.ui.xaml.controls/webview.md), [MediaElement](../windows.ui.xaml.controls/mediaelement.md), [CaptureElement](../windows.ui.xaml.controls/captureelement.md). These display content and have some level of interactivity that happens within their content, but they aren't actually controls.
+ Text display elements: [TextBlock](../windows.ui.xaml.controls/textblock.md), [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md), [RichTextBlockOverflow](../windows.ui.xaml.controls/richtextblockoverflow.md), [Glyphs](../windows.ui.xaml.documents/glyphs.md). (Text elements like [Run](../windows.ui.xaml.documents/run.md) and [Hyperlink](../windows.ui.xaml.documents/hyperlink.md), which often declare the content of a text display element, are not derived from [FrameworkElement](frameworkelement.md).)
+ The [Panel](../windows.ui.xaml.controls/panel.md) base class: [Panel](../windows.ui.xaml.controls/panel.md) is the parent class for the common panels such as [Grid](../windows.ui.xaml.controls/grid.md), [StackPanel](../windows.ui.xaml.controls/stackpanel.md) and so on.
+ The [Shape](../windows.ui.xaml.shapes/shape.md) base class: [Shape](../windows.ui.xaml.shapes/shape.md) is the parent class for [Path](../windows.ui.xaml.shapes/path.md), [Rectangle](../windows.ui.xaml.shapes/rectangle.md) and so on.
+ The [IconElement](../windows.ui.xaml.controls/iconelement.md) base class: parent class for [FontIcon](../windows.ui.xaml.controls/fonticon.md), [SymbolIcon](../windows.ui.xaml.controls/symbolicon.md) and so on.
+ Miscellaneous UI elements: [Popup](../windows.ui.xaml.controls.primitives/popup.md), [TickBar](../windows.ui.xaml.controls.primitives/tickbar.md), [Viewbox](../windows.ui.xaml.controls/viewbox.md).


## -examples

## -see-also
[UIElement](uielement.md), [Creating a UI](XREF:TODO:nodepage.creating_an_app_ui_xaml), [Dependency properties overview](http://msdn.microsoft.com/library/ad649e66-f71c-4daa-9994-617c886fda7e)