---
-api-id: T:Windows.Graphics.Printing.PrintSupport.PrintSupportEnterpriseManagementUIEventArgs
-api-type: winrt class
---

# Windows.Graphics.Printing.PrintSupport.PrintSupportEnterpriseManagementUIEventArgs

<!--
public sealed class PrintSupportEnterpriseManagementUIEventArgs
-->


## -description

Provides activation args that allow print support apps to query and update properties of Internet Printing Protocol (IPP) printer devices.

## -remarks

Get an instance of this class by casting the [IActivatedEventArgs](/uwp/api/windows.applicationmodel.activation.iactivatedeventargs) passed into the [OnActivated](/uwp/api/windows.ui.xaml.application.onactivated) event. Verify that the activation [Kind](/uwp/api/windows.applicationmodel.activation.iactivatedeventargs.kind) is [PrintSupportEnterpriseManagementUI](/uwp/api/windows.applicationmodel.activation.activationkind) before casting the args object.

## -see-also

## -examples

The following example illustrates the use of **PrintSupportEnterpriseManagementUIEventArgs** to get a reference to an IPP printer and then obtain the device properties associated with the printer. In this example, app-defined logic navigates the user to different UI depending on current state of the device properties.

```csharp
protected override void OnActivated(IActivatedEventArgs args) 
{ 
    if (args.Kind == ActivationKind.PrintSupportEnterpriseManagementUI) 
    { 
        var managementUIArgs = (PrintSupportEnterpriseManagementUIEventArgs)args; 
        IppPrintDevice ippPrintDevice = managementUIArgs.Printer; 
        ValueSet deviceProperties = ippPrintDevice.GetDeviceProperties(); 

        var rootFrame = new Frame(); 

        if (AreDevicePropertiesIntialized(deviceProperties)) 
        { 
            rootFrame.Navigate(typeof(PrinterManagementView), ippPrintDevice); 
        } 
        else   
        { 
            rootFrame.Navigate(typeof(PrinterManagementIntializeView), ippPrintDevice); 
        }

        Window.Current.Content = rootFrame; 
    }     
}
```


