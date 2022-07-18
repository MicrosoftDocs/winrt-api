---
-api-id: T:Windows.UI.Xaml.FrameworkElement
-api-type: winrt class
---

<!-- Class syntax.
public class FrameworkElement : Windows.UI.Xaml.UIElement, Windows.UI.Xaml.IFrameworkElement, Windows.UI.Xaml.IFrameworkElement2, Windows.UI.Xaml.IFrameworkElement3, Windows.UI.Xaml.IFrameworkElement4, Windows.UI.Xaml.IFrameworkElementOverrides, Windows.UI.Xaml.IFrameworkElementOverrides2
-->

# Windows.UI.Xaml.FrameworkElement

## -description
Provides a base element class for Windows Runtime UI objects. FrameworkElement defines common API that support UI interaction and the automatic layout system. FrameworkElement  also defines API related to data binding, defining and examining the object tree, and tracking object lifetime.


## -remarks
FrameworkElement is a base element: it's a class that many other Windows Runtime classes inherit from in order to support the XAML UI element model. Properties, methods and events that FrameworkElement defines are inherited by hundreds of other Windows Runtime classes.

Many common XAML UI classes derive from FrameworkElement, either directly or through intermediate base classes such as [Panel](../windows.ui.xaml.controls/panel.md) or [Control](../windows.ui.xaml.controls/control.md). Typically, you don't derive classes directly from FrameworkElement, because certain expected services for a class that is intended for a UI representation (such as template support) are not fully implemented there. More commonly used base classes for derived custom classes are:

+ Specific controls that are not sealed (for example, [TextBox](../windows.ui.xaml.controls/textbox.md)).
+ Control base classes ([Control](../windows.ui.xaml.controls/control.md), [ContentControl](../windows.ui.xaml.controls/contentcontrol.md), [UserControl](../windows.ui.xaml.controls/usercontrol.md)).
+ Navigation elements ([Page](../windows.ui.xaml.controls/page.md), [Frame](../windows.ui.xaml.controls/frame.md)).
+ Panel classes (the base class [Panel](../windows.ui.xaml.controls/panel.md), or specific non-sealed implementations such as [Grid](../windows.ui.xaml.controls/grid.md)).

### **FrameworkElement** API and features

FrameworkElement extends [UIElement](uielement.md), which is another base element, and adds support for various Windows Runtime feature areas.

### Layout

The layout system recognizes all objects that derive from FrameworkElement to be elements that potentially participate in layout and should have a display area in the app UI. The layout system reads various properties that are defined at FrameworkElement level, such as [MinWidth](frameworkelement_minwidth.md). Most UI elements use the FrameworkElement-defined [Width](frameworkelement_width.md) and [Height](frameworkelement_height.md) for their basic sizing information. FrameworkElement provides extensible methods for specialized layout behavior that panels and controls with content can override in their class implementations. For more info, see [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml).

Prominent API of FrameworkElement that support layout: [Height](frameworkelement_height.md), [Width](frameworkelement_width.md), [ActualHeight](frameworkelement_actualheight.md), [ActualWidth](frameworkelement_actualwidth.md), [Margin](frameworkelement_margin.md), [MeasureOverride](frameworkelement_measureoverride_1586581644.md), [ArrangeOverride](frameworkelement_arrangeoverride_1795048387.md), [HorizontalAlignment](frameworkelement_horizontalalignment.md), [VerticalAlignment](frameworkelement_verticalalignment.md), [LayoutUpdated](frameworkelement_layoutupdated.md).

### Object lifetime events

You often want to know when an object is first loaded (*loaded* is defined as when an object becomes attached to an object tree that connects to the root visual). FrameworkElement defines events related to object lifetime that provide useful hooks for code-behind operations. For example you need object lifetime info to add child objects to a collection or set properties on child objects just prior to use, with assurance that the necessary objects in the object tree have already been instantiated from XAML markup. For more info, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

Prominent API of FrameworkElement that support object lifetime events: [Loaded](frameworkelement_loaded.md), [SizeChanged](frameworkelement_sizechanged.md), [Unloaded](frameworkelement_unloaded.md), [OnApplyTemplate](frameworkelement_onapplytemplate_1955470198.md).

### Data binding

The ability to set a value for a potentially inherited data context for a data binding is implemented by FrameworkElement. FrameworkElement also has API for establishing data binding in code rather than in XAML. For more info, see [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth).

Prominent API of FrameworkElement that support data binding: [DataContext](frameworkelement_datacontext.md), [DataContextChanged](frameworkelement_datacontextchanged.md), [SetBinding](frameworkelement_setbinding_28713777.md), [GetBindingExpression](frameworkelement_getbindingexpression_1210399878.md).

### XAML language and programming model integration

Usually your app's element structure resembles the XAML markup that you defined to create the UI, but sometimes that structure changes after the XAML was parsed. FrameworkElement defines the [Name](frameworkelement_name.md) property and related API, which are useful for finding elements and element relationships at run-time. For more info, see [XAML namescopes](/windows/uwp/xaml-platform/xaml-namescopes).

Prominent API of FrameworkElement that support XAML and programming model: [Name](frameworkelement_name.md), [FindName](frameworkelement_findname_634111277.md), [Parent](frameworkelement_parent.md), [BaseUri](frameworkelement_baseuri.md), [OnApplyTemplate](frameworkelement_onapplytemplate_1955470198.md).

### Globalization

The FrameworkElement class defines the [Language](frameworkelement_language.md) property and the [FlowDirection](frameworkelement_flowdirection.md) property. For more info, see [Globalizing your app](/previous-versions/windows/apps/hh965328(v=win.10)).

### Style and theme support

The FrameworkElement class defines the [Style](style.md) property and the [RequestedTheme](frameworkelement_requestedtheme.md) property. Also, the [Resources](frameworkelement_resources.md) property is used to define the page-level XAML resource dictionaries that typically define styles and templates, as well as other shared resources. For more info, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls) and [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary).
<!--link for req theme?-->

### **FrameworkElement** dependency properties

Many of the read-write properties of the FrameworkElement base element class are dependency properties. Dependency properties support some of the basic programming model features for a UWP app using C++, C#, or Visual Basic, such as styles and templates, data binding, XAML resource references, and property-changed logic. For more info on dependency properties and the features they support, see [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview).

### **FrameworkElement** derived classes

FrameworkElement is the parent class for several immediately derived classes that distinguish several broad classifications of UI elements. Here are some of the notable derived classes:

+ [Control](../windows.ui.xaml.controls/control.md): [Control](../windows.ui.xaml.controls/control.md) has many more derived control classes, basically all of the XAML controls that you use for a Windows Runtime UI are derived from [Control](../windows.ui.xaml.controls/control.md).
+ Presenters: A presenter is a class that imparts a visual appearance, usually by contributing to some control scenario, but the presenter itself isn't typically interactive. For example: [Border](../windows.ui.xaml.controls/border.md), [ContentPresenter](../windows.ui.xaml.controls/contentpresenter.md) (parent of [ScrollContentPresenter](../windows.ui.xaml.controls/scrollcontentpresenter.md) and others), [ItemsPresenter](../windows.ui.xaml.controls/itemspresenter.md), [Viewbox](../windows.ui.xaml.controls/viewbox.md).
+ Media and web elements: [Image](../windows.ui.xaml.controls/image.md), [WebView](../windows.ui.xaml.controls/webview.md), [MediaElement](../windows.ui.xaml.controls/mediaelement.md), [CaptureElement](../windows.ui.xaml.controls/captureelement.md). These display content and have some level of interactivity that happens within their content, but they aren't actually controls.
+ Text display elements: [TextBlock](../windows.ui.xaml.controls/textblock.md), [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md), [RichTextBlockOverflow](../windows.ui.xaml.controls/richtextblockoverflow.md), [Glyphs](../windows.ui.xaml.documents/glyphs.md). (Text elements like [Run](../windows.ui.xaml.documents/run.md) and [Hyperlink](../windows.ui.xaml.documents/hyperlink.md), which often declare the content of a text display element, are not derived from FrameworkElement.)
+ The [Panel](../windows.ui.xaml.controls/panel.md) base class: [Panel](../windows.ui.xaml.controls/panel.md) is the parent class for the common panels such as [Grid](../windows.ui.xaml.controls/grid.md), [StackPanel](../windows.ui.xaml.controls/stackpanel.md) and so on.
+ The [Shape](../windows.ui.xaml.shapes/shape.md) base class: [Shape](../windows.ui.xaml.shapes/shape.md) is the parent class for [Path](../windows.ui.xaml.shapes/path.md), [Rectangle](../windows.ui.xaml.shapes/rectangle.md) and so on.
+ The [IconElement](../windows.ui.xaml.controls/iconelement.md) base class: parent class for [FontIcon](../windows.ui.xaml.controls/fonticon.md), [SymbolIcon](../windows.ui.xaml.controls/symbolicon.md) and so on.
+ Miscellaneous UI elements: [Popup](../windows.ui.xaml.controls.primitives/popup.md), [TickBar](../windows.ui.xaml.controls.primitives/tickbar.md), [Viewbox](../windows.ui.xaml.controls/viewbox.md).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | AllowFocusOnInteraction |
| 1607 | 14393 | AllowFocusWhenDisabled |
| 1607 | 14393 | FocusVisualMargin |
| 1607 | 14393 | FocusVisualPrimaryBrush |
| 1607 | 14393 | FocusVisualPrimaryThickness |
| 1607 | 14393 | FocusVisualSecondaryBrush |
| 1607 | 14393 | FocusVisualSecondaryThickness |
| 1703 | 15063 | DeferTree |
| 1709 | 16299 | ActualTheme |
| 1709 | 16299 | ActualThemeChanged |
| 1809 | 17763 | EffectiveViewportChanged |
| 1809 | 17763 | InvalidateViewport |
| 1809 | 17763 | IsLoaded |

## -examples

## -see-also
[UIElement](uielement.md), [Creating a UI](XREF:TODO:nodepage.creating_an_app_ui_xaml), [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview)
