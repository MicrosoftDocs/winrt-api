---
-api-id: P:Windows.UI.Xaml.FrameworkElement.Name
-api-type: winrt property
---

<!-- Property syntax
public string Name { get;  set; }
-->

# Windows.UI.Xaml.FrameworkElement.Name

## -description
Gets or sets the identifying name of the object. When a XAML processor creates the object tree from XAML markup, run-time code can refer to the XAML-declared object by this name.

## -xaml-syntax
```xaml
<frameworkElement Name="xamlNameString"/>
```


## -property-value
The name of the object, which must be a string that is valid in the XamlName grammar (see table in [x:Name attribute](https://msdn.microsoft.com/library/4ff1f3ed-903a-4305-b2bd-dcd29e0c9e6d) reference). The default is an empty string.

## -remarks
The most common usage of this property is to specify the [x:Name attribute](https://msdn.microsoft.com/library/4ff1f3ed-903a-4305-b2bd-dcd29e0c9e6d) for an object in XAML markup, or to read that value as it was set in markup. In most ways, the **x:Name** attribute and the [Name](frameworkelement_name.md) property are equivalent. On any single element, the **x:Name** attribute and the [Name](frameworkelement_name.md) property are mutually exclusive as XAML attributes; if you attempt to set both **x:Name** and [Name](frameworkelement_name.md) on the same object element in markup, a parser error is thrown.

When you use the default **Page** build actions for XAML, any XAML element that has a [x:Name attribute](https://msdn.microsoft.com/library/4ff1f3ed-903a-4305-b2bd-dcd29e0c9e6d) or [Name](frameworkelement_name.md) generates field references that are eventually populated by **InitializeComponent** when the XAML is loaded. The field references enable a programming model whereby objects can be directly referenced by name in your page-specific code-behind, once the XAML object tree is loaded into a page or app.

Names must be unique in a XAML namescope. Generally, the XAML namescope is defined by the XAML page, but certain features such as templates or calls to API such as [XamlReader.Load](../windows.ui.xaml.markup/xamlreader_load_1077941801.md) can define separate XAML namescopes. For more info, see [XAML namescopes](https://msdn.microsoft.com/library/eb060cbd-a589-475e-b83d-b24068b54c21).

[Name](frameworkelement_name.md) should never be localized. [Name](frameworkelement_name.md) is used as a field name variable in code-behind. Such code is typically inaccessible to the localizer who might otherwise have access to XAML files that define the UI, although this depends on your deployment model and localization procedures. This is one reason why you should not display any strings that come from [Name](frameworkelement_name.md) in your app UI.

### Scenarios for Name

Setting **x:Name** or [Name](frameworkelement_name.md) in the XAML that defines UI elements supports several major scenarios: + **Animation targeting** To apply an animation to an object property, you must target a specific instance. You do that by setting the [Storyboard.TargetName](../windows.ui.xaml.media.animation/storyboard_targetname.md) attached property on any [Timeline](../windows.ui.xaml.media.animation/timeline.md). The value that you set here is the string that you assigned as the **x:Name** or [Name](frameworkelement_name.md). For more info, see [Storyboarded animations](https://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a).
+ **Parts of a control template** In order to support the visual state model and control initialization, control authors should specify **Name** values for the key parts of a templated control. For more info see [Quickstart: Control templates](https://msdn.microsoft.com/library/67c424ae-afb1-4560-a6a8-4a3506775d77).
+ **General run time interaction** For example, code within an event handler might handle an event on an object that provides the change UI, but the change to properties occurs on another nearby UI element. The easiest way to write code for this situation is to use the field reference generated from a **Name**.


### FindName

The utility method [FindName](frameworkelement_findname_634111277.md), which is available from any [FrameworkElement](frameworkelement.md), can find objects by name in the object tree as long as they are in the current XAML namescope. [FindName](frameworkelement_findname_634111277.md) searches the XAML-created object tree in its entirety. Technically, what [FindName](frameworkelement_findname_634111277.md) is actually searching is the XAML namescope, which does not preserve the tree metaphor and is instead represented as a hash table of names. [FindName](frameworkelement_findname_634111277.md) cannot find names that are defined in applied templates. To find items in applied templates, use [VisualTreeHelper.GetChild](../windows.ui.xaml.media/visualtreehelper_getchild_2017450836.md) to get the applied template root object. Then you can call [FindName](frameworkelement_findname_634111277.md) on that root object, and you will be searching the XAML namescope of the template rather than the greater page.

### Name and data binding

You cannot use the string value of [Name](frameworkelement_name.md) as a direct source value for a data binding source. If you have to display the same string value as [Name](frameworkelement_name.md) in UI with binding, you should replicate the same value to the [Tag](frameworkelement_tag.md) property, which can be used as a property binding source. Also don't use [Name](frameworkelement_name.md) as a binding target.

The value of **x:Name** or [Name](frameworkelement_name.md) is the identifier that you use to identify the source element for an [ElementName](../windows.ui.xaml.data/binding_elementname.md) binding. For more info see [Data binding in depth](https://msdn.microsoft.com/library/41e1b4f1-6caf-4128-a61a-4e400b149011).

### Setting Name in code

You can set the value of [Name](frameworkelement_name.md) for an object at run time, but there are some important considerations and limitations that you should be aware of.

Changing the value of [Name](frameworkelement_name.md) in code at run time if the object had a previous **Name** value set in XAML is generally not recommended. This is because setting a name after the object tree is loaded will not create or change the identifying name of the equivalent field reference. If a field reference already exists because **x:Name** is provided in the initial markup, and you change the value of **Name**, the field and the name that you need to use to find the object through [FindName](frameworkelement_findname_634111277.md) are now different because the field remains as the markup-defined name.

Setting a [Name](frameworkelement_name.md) value for an object that was created in code and therefore never had a XAML-defined [Name](frameworkelement_name.md) value is appropriate for certain scenarios. One such scenario is if you want to be able to find either XAML-created or code-created objects in the tree by using [FindName](frameworkelement_findname_634111277.md) as the common utility function. In order to make that scenario work, the Windows Runtime continues to use and add to the XAML namescope hashtable representation at run time. If you are attempting to add new named objects to an existing largely XAML-created object tree, names must be unique, otherwise a duplicate name exception occurs. The duplicate name exception might not occur on the attempt to set [Name](frameworkelement_name.md). Until you attempt to add the duplicate-named object to the main object tree, the new object has its own self-contained XAML namescope. It is only at the moment that you connect the object to a larger object tree that the duplicate name condition can be detected. Or, the exception might occur on the operation that connected objects in the tree, for example on a call to the **Add** method of a collection that connects to the main object tree.

It can be difficult to know which [Name](frameworkelement_name.md) values already exist in the XAML namescope that you will later add the new object to. There is no specific API that reports the full hashtable of existing names in a XAML namescope. If you set [Name](frameworkelement_name.md) values in code extensively, you might need a technique for generating name strings that are unique to your run time usage, or you might need to wrap calls that add newly named objects in a try-catch block to catch the exceptions that could result from a duplicate name. Or you can add your own code to the **InitializeComponent** implementation that reads the XAML-generated name values.

Note that you can only set [Name](frameworkelement_name.md) at run time for objects that are a [FrameworkElement](frameworkelement.md) or an [Inline](../windows.ui.xaml.documents/inline.md). If an object does not have a **Name** property, and setting the name in XAML would have required using the **x:Name** attribute rather than **Name**, there is no run-time API available for setting such an object's run-time name.

## -examples
This example gets a value for [Name](frameworkelement_name.md) from an existing object, and uses that name to retarget an animation. You target an animation by setting the [Storyboard.TargetName](../windows.ui.xaml.media.animation/storyboard_targetname.md) attached property.



[!code-csharp[Change_targetname_1_cs](../windows.ui.xaml/code/change_targetname_1/csharp/Page.xaml.cs#SnippetChange_targetname_1_cs)]

[!code-vb[Change_targetname_1_cs](../windows.ui.xaml/code/change_targetname_1/vbnet/Page.xaml.vb#SnippetChange_targetname_1_cs)]

## -see-also
[x:Name attribute](https://msdn.microsoft.com/library/4ff1f3ed-903a-4305-b2bd-dcd29e0c9e6d), [FindName](frameworkelement_findname_634111277.md), [Storyboard.TargetName](../windows.ui.xaml.media.animation/storyboard_targetname.md), [XAML namescopes](https://msdn.microsoft.com/library/eb060cbd-a589-475e-b83d-b24068b54c21), [XAML overview](https://msdn.microsoft.com/library/48041b37-f1a8-44a4-bb8e-1d4de30e7823)
1b37-f1a8-44a4-bb8e-1d4de30e7823)
