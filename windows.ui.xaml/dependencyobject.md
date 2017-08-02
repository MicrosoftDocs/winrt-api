---
-api-id: T:Windows.UI.Xaml.DependencyObject
-api-type: winrt class
---

<!-- Class syntax.
public class DependencyObject : Windows.UI.Xaml.IDependencyObject, Windows.UI.Xaml.IDependencyObject2
-->

# Windows.UI.Xaml.DependencyObject

## -description
Represents an object that participates in the dependency property system. [DependencyObject](dependencyobject.md) is the immediate base class of many important UI-related classes, such as [UIElement](uielement.md), [Geometry](../windows.ui.xaml.media/geometry.md), [FrameworkTemplate](frameworktemplate.md), [Style](style.md), and [ResourceDictionary](resourcedictionary.md). For more info on how [DependencyObject](dependencyobject.md) supports dependency properties, see [Dependency properties overview](http://msdn.microsoft.com/library/ad649e66-f71c-4daa-9994-617c886fda7e).

## -remarks
The [DependencyObject](dependencyobject.md) class enables dependency property system services on its many derived classes. For more info about the dependency property concept, see [Dependency properties overview](http://msdn.microsoft.com/library/ad649e66-f71c-4daa-9994-617c886fda7e).

The dependency property system's primary function is to compute the values of properties, and to provide system notification about values that have changed. Another key class that participates in the dependency property system is [DependencyProperty](dependencyproperty.md). [DependencyProperty](dependencyproperty.md) enables the registration of dependency properties into the property system, whereas [DependencyObject](dependencyobject.md) as a base class enables objects to use and set the dependency properties.

Here are some notable services and characteristics that [DependencyObject](dependencyobject.md) provides or supports:


+ Dependency property hosting support for the existing Windows Runtime dependency properties.
+ Custom dependency property hosting support. You register a dependency property by calling the [Register](dependencyproperty_register.md) method and storing the method's return value as a public static property in your [DependencyObject](dependencyobject.md) class.
+ Attached property hosting support for the existing Windows Runtime attached properties.
+ Custom attached property hosting support. You register a dependency property for the attached property usage by calling the [RegisterAttached](dependencyproperty_registerattached.md) method and storing the method's return value as a public static property in your class.
+ **Get** and **Set** utility methods for values of any dependency properties that exist on a [DependencyObject](dependencyobject.md). You use these when defining custom dependency property "wrappers" and can also use them from app code as an alternative to using existing "wrapper" properties.
+ Advanced-scenario utility for examining metadata or property values (for example [GetAnimationBaseValue](dependencyobject_getanimationbasevalue.md)).
+ Enforcement of thread affinity to the main UI thread of the Windows Runtime for all [DependencyObject](dependencyobject.md) instances.
+ The [Dispatcher](dependencyobject_dispatcher.md) property for advanced threading scenarios. Getting the [Dispatcher](dependencyobject_dispatcher.md) value provides a reference to a [CoreDispatcher](../windows.ui.core/coredispatcher.md) object. With the [CoreDispatcher](../windows.ui.core/coredispatcher.md), a worker thread can run code that use a [DependencyObject](dependencyobject.md) but is not on the UI thread, because the [CoreDispatcher](../windows.ui.core/coredispatcher.md) can defer the execution to an asynchronous operation that won't block or otherwise interfere with the UI thread. See "**DependencyObject** and threading" section below.
+ Basic data binding and styling support, by enabling properties to be set as expressions to be evaluated at some later point in an object's lifetime. These concepts are explained in more detail in [Dependency properties overview](http://msdn.microsoft.com/library/ad649e66-f71c-4daa-9994-617c886fda7e). See also [Data binding in depth](http://msdn.microsoft.com/library/41e1b4f1-6caf-4128-a61a-4e400b149011).


### **DependencyObject** and threading

All [DependencyObject](dependencyobject.md) instances must be created on the UI thread that is associated with the current [Window](window.md) for an app. This is enforced by the system, and there are two important implications of this for your code:
+ Code that uses API from two [DependencyObject](dependencyobject.md) instances will always be run on the same thread, which is always the UI thread. You don't typically run into threading issues in this scenario.
+ Code that is not running on the main UI thread cannot access a [DependencyObject](dependencyobject.md) directly because a [DependencyObject](dependencyobject.md) has thread affinity to the UI thread only. Only code that runs on the UI thread can change or even read the value of a dependency property. For example a worker thread that you've initiated with a .NET **Task** or an explicit [ThreadPool](../windows.system.threading/threadpool.md) thread won't be able to read dependency properties or call other APIs.


You aren't completely blocked from using a [DependencyObject](dependencyobject.md) from a worker thread. But you must get a [CoreDispatcher](../windows.ui.core/coredispatcher.md) object (the value of [DependencyObject.Dispatcher](dependencyobject_dispatcher.md)) from a [DependencyObject](dependencyobject.md) in order to get across the deliberate separation between the app UI thread and any other threads running on the system. The [CoreDispatcher](../windows.ui.core/coredispatcher.md) exposes the [RunAsync](../windows.ui.core/coredispatcher_runasync.md) method. Call [RunAsync](../windows.ui.core/coredispatcher_runasync.md) to run your awaitable code (an [IAsyncAction](../windows.foundation/iasyncaction.md)). If it's simple code you can use a lambda expression, otherwise you can implement as a delegate ([DispatchedHandler](../windows.ui.core/dispatchedhandler.md)). The system determines a time that your code can be run. Because it's enabling access across threads, [DependencyObject.Dispatcher](dependencyobject_dispatcher.md) is the only instance API of [DependencyObject](dependencyobject.md) or any of its subclasses that can be accessed from a non-UI thread without throwing a cross-thread exception. All other [DependencyObject](dependencyobject.md) APIs throw an exception if you attempt to call them from a worker thread or any other non-UI thread.

Threading issues can usually be avoided in typical UI code. However, devices aren't usually associated with the UI thread. If you are using info obtained from a device to update the UI in real-time, you often must get a [CoreDispatcher](../windows.ui.core/coredispatcher.md) so that you can update the UI. Services are another case where the code you use to access the service might not be running on the UI thread.

One code scenario where you might encounter [DependencyObject](dependencyobject.md)-related threading issues if you are defining your own [DependencyObject](dependencyobject.md) types and you attempt to use them for data sources, or other scenarios where a [DependencyObject](dependencyobject.md) isn't necessarily appropriate (because the object is not directly related to the UI). For example, you might be attempting perf optimizations with background threads or other worker threads that are changing values of the objects prior to presentation, or in response to a device, service or other external input. Evaluate whether you really need dependency properties for your scenario; maybe standard properties are adequate.

### **DependencyObject** derived classes

[DependencyObject](dependencyobject.md) is the parent class for several immediately derived classes that are all fundamental to the programming model you use for your app and its XAML UI. Here are some of the notable derived classes:

+ [UIElement](uielement.md): The base class for most visual objects that can process input in the UI. [FrameworkElement](frameworkelement.md) is further in this hierarchy, as is [Control](../windows.ui.xaml.controls/control.md), so there are hundreds of controls and other classes in the Windows Runtime that all have the [UIElement](uielement.md) class in their class hierarchies.
+ XAML style system support classes: [FrameworkTemplate](frameworktemplate.md) (parent of [ControlTemplate](../windows.ui.xaml.controls/controltemplate.md), [DataTemplate](datatemplate.md), [ItemsPanelTemplate](../windows.ui.xaml.controls/itemspaneltemplate.md)), [Style](style.md), [SetterBase](setterbase.md) (parent of [Setter](setter.md)), [ToolTipTemplateSettings](../windows.ui.xaml.controls.primitives/tooltiptemplatesettings.md) and other ***TemplateSettings**.
+ Visual state model: [Transition](../windows.ui.xaml.media.animation/transition.md), [VisualState](visualstate.md), [VisualStateGroup](visualstategroup.md), [VisualStateManager](visualstatemanager.md), [VisualTransition](visualtransition.md).
+ Data binding support: [BindingBase](../windows.ui.xaml.data/bindingbase.md) (parent of [Binding](../windows.ui.xaml.data/binding.md)), [CollectionViewSource](../windows.ui.xaml.data/collectionviewsource.md), [PropertyPath](propertypath.md), [RelativeSource](../windows.ui.xaml.data/relativesource.md).
+ Storyboarded animations: [Timeline](../windows.ui.xaml.media.animation/timeline.md) (parent of [Storyboard](../windows.ui.xaml.media.animation/storyboard.md), typed animations, theme animations), typed keyframes (like [ColorKeyFrame](../windows.ui.xaml.media.animation/colorkeyframe.md)), [KeySpline](../windows.ui.xaml.media.animation/keyspline.md), [EasingFunctionBase](../windows.ui.xaml.media.animation/easingfunctionbase.md).
+ XAML graphics and rendering primitives: [Brush](../windows.ui.xaml.media/brush.md), [Geometry](../windows.ui.xaml.media/geometry.md), [GeneralTransform](../windows.ui.xaml.media/generaltransform.md), [GradientStop](../windows.ui.xaml.media/gradientstop.md), [PathFigure](../windows.ui.xaml.media/pathfigure.md), [PathSegment](../windows.ui.xaml.media/pathsegment.md), [Projection](../windows.ui.xaml.media/projection.md).
+ Imaging and render surface interop: [ImageSource](../windows.ui.xaml.media/imagesource.md) (parent of [BitmapSource](../windows.ui.xaml.media.imaging/bitmapsource.md), [RenderTargetBitmap](../windows.ui.xaml.media.imaging/rendertargetbitmap.md), [SurfaceImageSource](../windows.ui.xaml.media.imaging/surfaceimagesource.md) and others).
+ [Window](window.md): represents the main app window.
+ [FlyoutBase](../windows.ui.xaml.controls.primitives/flyoutbase.md) (parent of [Flyout](../windows.ui.xaml.controls/flyout.md) and [MenuFlyout](../windows.ui.xaml.controls/menuflyout.md)).
+ [ResourceDictionary](resourcedictionary.md): defines keyed resources in XAML.
+ [TextElement](../windows.ui.xaml.documents/textelement.md): parent of [Block](../windows.ui.xaml.documents/block.md) and [Inline](../windows.ui.xaml.documents/inline.md), these in turn are base classes for text elements used for [TextBlock](../windows.ui.xaml.controls/textblock.md) content or the rich text elements.
+ [AutomationPeer](../windows.ui.xaml.automation.peers/automationpeer.md): base class for Microsoft UI Automation peers that represent XAML controls to a Microsoft UI Automation listener. Also, [IRawElementProviderSimple](../windows.ui.xaml.automation.provider/irawelementprovidersimple.md).
+ Miscellaneous: [CacheMode](uielement_cachemode.md), [ColumnDefinition](../windows.ui.xaml.controls/columndefinition.md), [DependencyObjectCollection](dependencyobjectcollection.md), [InputScope](../windows.ui.xaml.input/inputscope.md), [InputScopeName](../windows.ui.xaml.input/inputscopename.md), [PageStackEntry](../windows.ui.xaml.navigation/pagestackentry.md), [PrintDocument](../windows.ui.xaml.printing/printdocument.md), [RowDefinition](../windows.ui.xaml.controls/rowdefinition.md), [TimelineMarker](../windows.ui.xaml.media/timelinemarker.md), [TriggerAction](triggeraction.md), [TriggerBase](triggerbase.md).


## -examples
This example defines a class that derives from [DependencyObject](dependencyobject.md), and defines an attached property along with the identifier field. The scenario for this class is that it is a service class that declares an attached property that other UI elements can set in XAML The service potentially acts on the attached property values on those UI elements at run time.



[!code-csharp[DOMain](../windows.ui.xaml/code/DOandDP/csharp/Class1.cs#SnippetDOMain)]

[!code-vb[DOMain](../windows.ui.xaml/code/DOandDP/vbnet/Class1.vb#SnippetDOMain)]

[!code-csharp[DOCheckClear](../windows.ui.xaml/code/DOandDP/csharp/Class1.cs#SnippetDOCheckClear)]

[!code-vb[DOCheckClear](../windows.ui.xaml/code/DOandDP/vbnet/Class1.vb#SnippetDOCheckClear)]

This example shows a simple dependency property declaration. A call to [GetValue](dependencyobject_getvalue.md) constitutes the entirety of the **get** accessor implementation for the property wrapper of the new dependency property. A call to [SetValue](dependencyobject_setvalue.md) constitutes the entirety of the **set** accessor implementation. For more examples, see [Custom dependency properties](http://msdn.microsoft.com/library/5adf7935-f2cf-4bb6-b1a5-f535c2ed8ef8).



[!code-csharp[DOSimpleDP](../windows.ui.xaml/code/DOandDP/csharp/Class1.cs#DOSimpleDP)]

[!code-vb[DOSimpleDP](../windows.ui.xaml/code/DOandDP/vbnet/Class1.vb#DOSimpleDP)]

## -see-also
[DependencyProperty](dependencyproperty.md), [Dependency properties overview](http://msdn.microsoft.com/library/ad649e66-f71c-4daa-9994-617c886fda7e), [Custom dependency properties](http://msdn.microsoft.com/library/5adf7935-f2cf-4bb6-b1a5-f535c2ed8ef8), [Custom attached properties](http://msdn.microsoft.com/library/e9c0c57e-6098-4875-aa3e-9d7b36e160e0), [Attached properties overview](http://msdn.microsoft.com/library/098c1de0-d640-48b1-9961-d0adf33266e2)
