---
-api-id: T:Windows.UI.Input.RadialControllerMenu
-api-type: winrt class
---

<!-- Class syntax.
public class RadialControllerMenu : Windows.UI.Input.IRadialControllerMenu
-->

# Windows.UI.Input.RadialControllerMenu

## -description

Represents the integrated menu of contextual tools associated with the [RadialController](radialcontroller.md) object.

> [!NOTE]
> Tools added to a [RadialController](radialcontroller.md) menu in support of a specific app context are only displayed in that context. They are not displayed for other [RadialController](radialcontroller.md) instances.

## -remarks

## -examples

In this example, we add a custom tool (`Sample`) with a standard icon to the Surface Dial menu.

1. First, we get a reference to the [RadialController](radialcontroller.md) object for the Surface Dial (`myController`) by calling [CreateForCurrentView](radialcontroller_createforcurrentview_1186319000.md).
1. We then create an instance of a [RadialControllerMenuItem](radialcontrollermenuitem.md) (`myItem`) by calling [RadialControllerMenuItem.CreateFromIcon](radialcontrollermenuitem_createfromicon_2066467533.md).
1. Finally, we append that item to the collection of menu items.

```csharp
public sealed partial class MainPage : Page
 {
     RadialController myController;

     public MainPage()
     {
         this.InitializeComponent();
         // Create a reference to the RadialController.
         myController = RadialController.CreateForCurrentView();

         // Create an icon for the custom tool.
         RandomAccessStreamReference icon =
           RandomAccessStreamReference.CreateFromUri(
             new Uri("ms-appx:///Assets/StoreLogo.png"));

         // Create a menu item for the custom tool.
         RadialControllerMenuItem myItem =
           RadialControllerMenuItem.CreateFromIcon("Sample", icon);

         // Add the custom tool to the RadialController menu.
         myController.Menu.Items.Add(myItem);

         // Declare input handlers for the RadialController.
         myController.ButtonClicked += MyController_ButtonClicked;
         myController.RotationChanged += MyController_RotationChanged;
     }
 }
```

## -see-also

[Windows.UI.Input Classes](windows_ui_input_classes.md), [Surface Dial interactions](/windows/uwp/input-and-devices/windows-wheel-interactions), [Universal Windows Platform samples (C# and C++)](https://go.microsoft.com/fwlink/?linkid=832713), [Windows desktop sample](https://aka.ms/radialcontrollerclassicsample), [Radial controller sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/RadialController)