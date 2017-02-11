---
-api-id: T:Windows.UI.Input.RadialController
-api-type: winrt class
---

<!-- Class syntax.
public class RadialController : Windows.UI.Input.IRadialController, Windows.UI.Input.IRadialController2
-->

# Windows.UI.Input.RadialController

## -description
Represents a wheel input device or accessory such as the Surface Dial.

> [!NOTE]
> Wheel devices are a new category of input device (supported in Windows 10, version 1607 and newer).

<img src="images/dial-pen-studio-600px.png" alt="Surface Dial with Surface Studio and Pen " />

With a form factor based on a rotate action (or gesture), the Surface Dial is intended as a secondary, multi-modal input device that complements input from a primary device. In most cases, the device is manipulated by a user's non-dominant hand while performing a task with their dominant hand (such as inking with a pen). It is not designed for precision pointer input (like touch, pen, or mouse).

The Surface Dial also supports both a press and hold action and a click action. Press and hold has a single function: display a menu of commands. If the menu is active, the rotate and click input is processed by the menu. Otherwise, the input is passed to your app for processing.

The [RadialController](radialcontroller.md) and related APIs (see end of topic) enable you to customize both the integrated command menu and the interaction experience supported by your app.

## -remarks

## -examples

In this example, we add a custom tool to the Surface Dial menu and declare the [RadialController](radialcontroller.md) input handlers.

1. First, we create a reference to the [RadialController](radialcontroller.md) object for the Surface Dial (`myController`) by calling [CreateForCurrentView](radialcontroller_createforcurrentview.md).
1. We then create an instance of a [RadialControllerMenuItem](radialcontrollermenuitem.md) (`myItem`) by calling [RadialControllerMenuItem.CreateFromIcon](radialcontrollermenuitem_createfromicon.md).
1. Next, we append that item to the collection of menu items.
1. We declare the input event handlers ([ButtonClicked](radialcontroller_buttonclicked.md) and [RotationChanged](radialcontroller_rotationchanged.md)) for the [RadialController](radialcontroller.md) object.
1. Finally, we define the event handlers.


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

     // Handler for rotation input from the RadialController.
     private void MyController_RotationChanged(RadialController sender,
       RadialControllerRotationChangedEventArgs args)
     {
         if (RotationSlider.Value + args.RotationDeltaInDegrees > 100)
         {
             RotationSlider.Value = 100;
             return;
         }
         else if (RotationSlider.Value + args.RotationDeltaInDegrees < 0)
         {
             RotationSlider.Value = 0;
             return;
         }
         RotationSlider.Value += args.RotationDeltaInDegrees;
     }

     // Handler for click input from the RadialController.
     private void MyController_ButtonClicked(RadialController sender,
       RadialControllerButtonClickedEventArgs args)
     {
         ButtonToggle.IsOn = !ButtonToggle.IsOn;
     }
 }
```

In the initialization function shown here, we declare the various input event handlers for the [RadialController](radialcontroller.md) object.



[TODO:AUTO_SNIPPET (SAMPLE_ID:RadialController)(SNIPPET_ID:InitializeController)]Finally, we define the event handlers for our app.

In the [ButtonClicked](radialcontroller_buttonclicked.md) handler, the interaction sets the state of a toggle button to checked or unchecked.



[TODO:AUTO_SNIPPET (SAMPLE_ID:RadialController)(SNIPPET_ID:ButtonClickedHandler)]In the [RotationChanged](radialcontroller_rotationchanged.md) handler, the interaction modifies the value of a slider.



[TODO:AUTO_SNIPPET (SAMPLE_ID:RadialController)(SNIPPET_ID:RotationChangedHandler)]

## -see-also
[Windows.UI.Input Classes](windows_ui_input_classes.md), [RadialController class](radialcontroller.md), [RadialControllerButtonClickedEventArgs class](radialcontrollerbuttonclickedeventargs.md), [RadialControllerConfiguration class](radialcontrollerconfiguration.md), [RadialControllerControlAcquiredEventArgs class](radialcontrollercontrolacquiredeventargs.md), [RadialControllerMenu class](radialcontrollermenu.md), [RadialControllerMenuItem class](radialcontrollermenuitem.md), [RadialControllerRotationChangedEventArgs class](radialcontrollerrotationchangedeventargs.md), [RadialControllerScreenContact class](radialcontrollerscreencontact.md), [RadialControllerScreenContactContinuedEventArgs class](radialcontrollerscreencontactcontinuedeventargs.md), [RadialControllerScreenContactStartedEventArgs class](radialcontrollerscreencontactstartedeventargs.md), [RadialControllerMenuKnownIcon enum](radialcontrollermenuknownicon.md), [RadialControllerSystemMenuItemKind enum](radialcontrollersystemmenuitemkind.md), [Surface Dial interactions](https://msdn.microsoft.com/en-us/windows/uwp/input-and-devices/windows-wheel-interactions), [Universal Windows Platform samples (C# and C++)](https://go.microsoft.com/fwlink/?linkid=832713), [Windows classic desktop sample](https://aka.ms/radialcontrollerclassicsample)