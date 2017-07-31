---
-api-id: M:Windows.UI.Input.Inking.InkPresenter.SetPredefinedConfiguration(Windows.UI.Input.Inking.InkPresenterPredefinedConfiguration)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void SetPredefinedConfiguration(Windows.UI.Input.Inking.InkPresenterPredefinedConfiguration value)
-->

# Windows.UI.Input.Inking.InkPresenter.SetPredefinedConfiguration

## -description
Sets the inking behavior of one or more contact points on the associated [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control.

## -parameters
### -param value
The inking behavior of one or more contact points. The default is [SimpleSinglePointer](inkpresenterpredefinedconfiguration.md).

[SimpleSinglePointer](inkpresenterpredefinedconfiguration.md) specifies that single pointer inking is supported.

[SimpleMultiplePointer](inkpresenterpredefinedconfiguration.md) specifies that multi-pointer inking is supported. 

> [!NOTE]
> Multi-pointer inking requires ink input to be processed in custom drying mode. [ActivateCustomDrying](inkpresenter_activatecustomdrying.md) must be called before setting [SetPredefinedConfiguration](inkpresenter_setpredefinedconfiguration.md) to [SimpleMultiplePointer](inkpresenterpredefinedconfiguration.md).

## -remarks
#### Error codes
##### E_ILLEGAL_METHOD_CALL  (0x8000000E)
Thrown if multi-pointer inking is enabled through [SetPredefinedConfiguration](inkpresenter_setpredefinedconfiguration.md) before [ActivateCustomDrying](inkpresenter_activatecustomdrying.md) is called.

##### E_INVALIDARG  (0x80070057)
An invalid parameter was specified. 

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)