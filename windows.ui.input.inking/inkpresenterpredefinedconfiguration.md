---
-api-id: T:Windows.UI.Input.Inking.InkPresenterPredefinedConfiguration
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.UI.Input.Inking.InkPresenterPredefinedConfiguration : int
-->

# InkPresenterPredefinedConfiguration

## -description
Specifies the inking behavior of one or more contact points. Used with [SetPredefinedConfiguration](inkpresenter_setpredefinedconfiguration.md).

## -enum-fields
### -field SimpleSinglePointer:0
A single, primary contact point is used to draw an [InkStroke](inkstroke.md).

### -field SimpleMultiplePointer:1
Each contact point is used to draw an [InkStroke](inkstroke.md). 

> [!NOTE]
> Multi-pointer inking requires ink input to be processed in custom drying mode. [ActivateCustomDrying](inkpresenter_activatecustomdrying.md) must be called before setting [SetPredefinedConfiguration](inkpresenter_setpredefinedconfiguration.md) to [SimpleMultiplePointer](inkpresenterpredefinedconfiguration.md).


## -remarks

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)