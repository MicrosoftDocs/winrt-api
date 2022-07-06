---
-api-id: P:Windows.UI.Xaml.Data.Binding.RelativeSource
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Data.RelativeSource RelativeSource { get;  set; }
-->

# Windows.UI.Xaml.Data.Binding.RelativeSource

## -description
Gets or sets the binding source by specifying its location relative to the position of the binding target. This is most often used in bindings within XAML control templates.



## -xaml-syntax
```xaml
<Binding RelativeSource="{RelativeSource TemplatedParent}"/>
-or-
<Binding RelativeSource="{RelativeSource Self}"/>

```


## -xaml-values
<dl><dt>{RelativeSource TemplatedParent}</dt><dd>{RelativeSource TemplatedParent}The control where a ControlTemplate is applied is the source for this binding. This is useful for applying validation error information in bindings at the template level.</dd>
<dt>{RelativeSource Self}</dt><dd>{RelativeSource Self}The target element should be used as the source for this binding. This is useful for binding one property of an element to another property on the same element.</dd>
</dl>
## -property-value
The relative location of the binding source to use. The default is **null**.

## -remarks
[Source](binding_source.md), RelativeSource, and [ElementName](binding_elementname.md) are mutually exclusive in a binding. If you have set one of these attributes, then setting either of the other two in a binding (through XAML or through code) will cause an exception. Setting RelativeSource in XAML always requires the use of the [{RelativeSource} markup extension](/windows/uwp/xaml-platform/relativesource-markup-extension). This is also true if you are creating the entire binding as a [{Binding} markup extension](/windows/uwp/xaml-platform/binding-markup-extension), in which case the [{RelativeSource} markup extension](/windows/uwp/xaml-platform/relativesource-markup-extension) is nested within the RelativeSource component of the expression.

You can't set the property values of a [Binding](binding.md) object after that binding has been attached to a target element and target property. If you attempt this you'll get a run-time exception.

## -examples
This XAML example is taken from the generic.xaml file that defines the default visual states for all XAML controls. This particular segment is one of the visual states for the [ToggleSwitch](../windows.ui.xaml.controls/toggleswitch.md) control. Here, one of the animations defined by the visual state references properties of the control that exist specifically so that templates can access them and get run-time values that modify the animation. For the template XAML to get properties from the control where the template is applied, the binding must use `{RelativeSource TemplatedParent}` as the RelativeSource value.

```xaml
<VisualStateGroup x:Name="ToggleStates">
  <VisualStateGroup.Transitions>
    <VisualTransition x:Name="DraggingToOnTransition"
      From="Dragging"
      To="On"
      GeneratedDuration="0">
      <Storyboard>
        <RepositionThemeAnimation TargetName="SwitchKnob" 
          FromHorizontalOffset="
          {Binding RelativeSource={RelativeSource TemplatedParent}, Path=TemplateSettings.KnobCurrentToOnOffset}"
        />
        <RepositionThemeAnimation TargetName="SwitchCurtain"
          FromHorizontalOffset="
          {Binding RelativeSource={RelativeSource TemplatedParent}, Path=TemplateSettings.CurtainCurrentToOnOffset}"
        />
      </Storyboard>
    </VisualTransition>
...
  </VisualStateGroup.Transitions>
</VisualStateGroup>
```



## -see-also
[XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth), [{Binding} markup extension](/windows/uwp/xaml-platform/binding-markup-extension), [{RelativeSource} markup extension](/windows/uwp/xaml-platform/relativesource-markup-extension)
