---
-api-id: T:Windows.UI.Xaml.Controls.ContentControl
-api-type: winrt class
---

<!-- Class syntax.
public class ContentControl : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.IContentControl, Windows.UI.Xaml.Controls.IContentControl2, Windows.UI.Xaml.Controls.IContentControlOverrides
-->

# Windows.UI.Xaml.Controls.ContentControl

## -description
Represents a control with a single piece of content. Controls such as [Button](button.md), [CheckBox](checkbox.md), and [ScrollViewer](scrollviewer.md) directly or indirectly inherit from this class.



## -xaml-syntax
```xaml
<ContentControl .../>
-or-
<contentControl>
    singleObject
</contentControl>
-or-
<contentControl>stringContent</contentControl>
```


## -remarks
The [Content](contentcontrol_content.md) property of a ContentControl can be any type of object, such as a string, a [UIElement](../windows.ui.xaml/uielement.md), or a [DateTime](/windows/desktop/api/windows.foundation/ns-windows-foundation-datetime). By default, when the [Content](contentcontrol_content.md) property is set to a [UIElement](../windows.ui.xaml/uielement.md), the [UIElement](../windows.ui.xaml/uielement.md) is displayed in the ContentControl. When [Content](contentcontrol_content.md) is set to another type of object, a string representation of the object is displayed in the ContentControl. A ContentControl has a limited default style. If you want to enhance the appearance of the control, you can create a new [DataTemplate](../windows.ui.xaml/datatemplate.md) and set it to the [ContentTemplate](contentcontrol_contenttemplate.md) property of the control.

A ContentControl can use a string as the value for its [Content](contentcontrol_content.md) property. However, whether a string is useful as content, and how it displays, is potentially handled differently by each control that derives from ContentControl. Specifically, the ability to display a content string is related to how a control uses a [ContentPresenter](contentpresenter.md) in its compositing. This behavior can also change by applying a custom control template to an existing control. Examples of content controls where string content displays by default include [Button](button.md) and related button controls. [Frame](frame.md) is an example of a ContentControl that does not display string content. If a ContentControl doesn't have a [ContentPresenter](contentpresenter.md) within it that has a [{TemplateBinding} markup extension](/windows/uwp/xaml-platform/templatebinding-markup-extension) for [ContentControl.Content](contentcontrol_content.md) to [ContentPresenter.Content](contentpresenter_content.md), then the value of [ContentControl.Content](contentcontrol_content.md) might not display anywhere.

Note that string content is specifically enabled only on ContentControl, not [Control](control.md). For example, [TextBox](textbox.md) does not support string content like this: `<TextBox>Initial text</TextBox>`, because it is not derived from ContentControl.

Rather than using a literal string, a ContentControl might use a reference to a string that is defined in a resource dictionary, or a binding. Either of these techniques can simplify the task of localizing the parts of the UI that are defined in Extensible Application Markup Language (XAML), by gathering the necessary string resources in one location rather than scattered throughout various Extensible Application Markup Language (XAML) files. Because apps usually need a way to maintain strings as resources for localization reasons or for general versatility, it is more common to not use string content, and to instead set [Content](contentcontrol_content.md) as an attribute, with a value that is a **{Binding}** or **{StaticResource}**.

Instead of text, a ContentControl might also display a single element for its own visual root, but using some container or panel so that there can be further UI compositing within. For example, if you really wanted to, you could declare a [StackPanel](stackpanel.md) for adaptive layout within a [Button](button.md) as its [Content](contentcontrol_content.md), and then the [Button](button.md) would appear to have multiple UI child elements that are children of the [StackPanel](stackpanel.md).

### **ContentControl** derived classes

ContentControl is the parent class for these immediately derived control classes:
+ [AppBar](appbar.md)
+ [ButtonBase](../windows.ui.xaml.controls.primitives/buttonbase.md)
+ [FlyoutPresenter](flyoutpresenter.md)
+ [Frame](frame.md)
+ [GroupItem](groupitem.md)
+ [ListViewBaseHeaderItem](listviewbaseheaderitem.md)
+ [ScrollViewer](scrollviewer.md)
+ [SelectorItem](../windows.ui.xaml.controls.primitives/selectoritem.md)
+ [SettingsFlyout](settingsflyout.md)
+ [ToolTip](tooltip.md)


> [!NOTE]
> [Page](page.md) is a [UserControl](usercontrol.md), not a ContentControl. [ListView](listview.md) and [GridView](gridview.md) (and others) descend from [ItemsControl](itemscontrol.md).

## -examples
The following example shows how to set different types of content for two [Button](button.md) controls and a [CheckBox](checkbox.md), which inherit from ContentControl.

```xaml
  <!-- Create a Button with a string as its content. -->
  <Button Content="This is string content of a Button"/>

  <!-- Create a Button with a single UIElement as its content. -->
  <Button>
    <Rectangle Height="40" Width="40" Fill="Blue"/>
  </Button>

  <!-- Create a CheckBox with a panel that contains 
       multiple objects as its content. -->
  <CheckBox>
    <StackPanel Margin="3,0,0,0" Orientation="Horizontal">
      <Ellipse Height="10" Width="10" Fill="Green"/>
      <TextBlock Text="A string of text" TextAlignment="Center"></TextBlock>
    </StackPanel>
  </CheckBox>
```



## -see-also
[Control](control.md)
