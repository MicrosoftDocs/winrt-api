---
-api-id: T:Windows.UI.Input.Inking.InkInputConfiguration
-api-type: winrt class
---

<!-- Class syntax.
public class InkInputConfiguration 
-->

# Windows.UI.Input.Inking.InkInputConfiguration

## -description
Manages which types of secondary input can be processed by the the [InkPresenter](inkpresenter.md) object.

## -remarks
To manage how secondary input is processed by your app, see [InkInputProcessingConfiguration](inkinputprocessingconfiguration.md).

## -examples
Here, we show how to accept input as ink from pen, touch, and mouse devices, but ignore all input from pen barrel buttons and eraser tips. 

```csharp
public ScenarioBarrelEraserIgnore() 
{ 
    this.InitializeComponent(); 
    var inkPresenter = inkCanvas.InkPresenter; 
    inkPresenter.InputDeviceTypes = 
        Windows.UI.Core.CoreInputDeviceTypes.Pen |  
        Windows.UI.Core.CoreInputDeviceTypes.Touch | 
        Windows.UI.Core.CoreInputDeviceTypes.Mouse; 

    InkInputConfiguration inkInputConfiguration = 
        inkPresenter.InputConfiguration; 
    inkInputConfiguration.IsEraserInputEnabled = false; 
    inkInputConfiguration.IsPrimaryBarrelButtonInputEnabled = false; 
} 
```

## -see-also
[InkPresenter.InputConfiguration](inkpresenter_inputconfiguration.md), [Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)

