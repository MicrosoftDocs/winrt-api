---
-api-id: T:Windows.UI.ViewManagement.UIViewSettings
-api-type: winrt class
---

<!-- Class syntax.
public class UIViewSettings : Windows.UI.ViewManagement.IUIViewSettings
-->

# Windows.UI.ViewManagement.UIViewSettings

## -description
Represents UI states and behaviors associated with the device mode (Tablet or Desktop) and input device type.

## -remarks
To get an instance of this class, call [GetForCurrentView](uiviewsettings_getforcurrentview_1363600702.md).

### Tablet mode (Windows 10 only)

> [!NOTE]
> In Windows 11, [Tablet mode](/windows-hardware/design/device-experiences/continuum) is removed and new functionality is included for keyboard attach and detach postures.

Some devices (PC, laptop, tablet) support both a Desktop and [Tablet](/windows-hardware/design/device-experiences/continuum) mode.

On Windows 10 only, users can switch between running in Tablet mode and Desktop mode by going to **Settings &gt; System &gt; Tablet mode** and setting **Make Windows more touch-friendly when using your device as a tablet**.

## -examples

Here, we show how to detect and respond to the user interaction mode.

```csharp
using System.ComponentModel;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace SDKTemplate
{
    public sealed partial class Scenario1_Basic : Page, INotifyPropertyChanged
    {
        private MainPage rootPage;

        public Scenario1_Basic()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            rootPage = MainPage.Current;

            // The SizeChanged event is raised when the
            // user interaction mode changes.
            Window.Current.SizeChanged += OnWindowResize;
            UpdateContent();
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            Window.Current.SizeChanged -= OnWindowResize;
        }

        void OnWindowResize(object sender, WindowSizeChangedEventArgs e)
        {
            UpdateContent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #region InteractionMode data binding
        private UserInteractionMode interactionMode;

        public UserInteractionMode InteractionMode
        {
            get { return interactionMode; }
            set
            {
                if (interactionMode != value)
                {
                    interactionMode = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, 
                            new PropertyChangedEventArgs("InteractionMode"));
                    }
                }
            }
        }

        #region CheckBoxStyle data binding
        private Style checkBoxStyle;

        public Style CheckBoxStyle
        {
            get { return checkBoxStyle; }
            set
            {
                if (checkBoxStyle != value)
                {
                    checkBoxStyle = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, 
                            new PropertyChangedEventArgs("CheckBoxStyle"));
                    }
                }
            }
        }

        void UpdateContent()
        {
            InteractionMode = 
                UIViewSettings.GetForCurrentView().UserInteractionMode;

            // Update styles
            CheckBoxStyle = 
                InteractionMode == 
                    UserInteractionMode.Mouse ? 
                        MouseCheckBoxStyle : TouchCheckBoxStyle;
        }
    }
}
```

## -see-also

[User interaction mode sample](https://github.com/microsoft/Windows-universal-samples/tree/fe8567faf2efdea3672c2ba642ba7b925ff6467e/Samples/UserInteractionMode)
