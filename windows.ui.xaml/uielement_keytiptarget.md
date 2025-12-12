---
-api-id: P:Windows.UI.Xaml.UIElement.KeyTipTarget
-api-type: winrt property
---

<!-- Property syntax.
public DependencyObject KeyTipTarget { get;  set; }
-->

# Windows.UI.Xaml.UIElement.KeyTipTarget

## -description

Gets or sets a value that indicates the element targeted by the access key keytip.

## -property-value

The element targeted by the keytip.

## -remarks

Keytips are badges displayed next to controls that support access keys when the user presses the Alt key. Each keytip contains the alphanumeric keys that activate the associated control.

The [KeyTipPlacementMode](uielement_keytipplacementmode.md) property is used to specify the location of the access key keytip relative to the boundary of the targeted element.

## -examples

In this example, we specify the access key for a Grid element, but we target the text heading of the Grid.

```xaml
<StackPanel> 
  <TextBlock x:Name="Heading1">Heading 1</TextBlock> 
  <Grid 
    AccessKey="1" 
    AccessKeyInvoked="Invoke1" 
    KeyTipTarget="{x:Bind Heading1}"> 
      <!-- ... -->
  </Grid> 

  <TextBlock x:Name="Heading2">Heading 2</TextBlock> 
    <Grid 
      AccessKey="2" 
      AccessKeyInvoked="Invoke2" 
      KeyTipTarget="{x:Bind Heading2}"> 
        <!-- ... --> 
    </Grid> 
</StackPanel>  
```

## -see-also

[Access keys](/windows/apps/design/input/access-keys), [KeyTipPlacementMode](uielement_keytipplacementmode.md)

