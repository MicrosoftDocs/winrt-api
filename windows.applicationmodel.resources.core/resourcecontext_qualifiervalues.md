---
-api-id: P:Windows.ApplicationModel.Resources.Core.ResourceContext.QualifierValues
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IObservableMap<string, string> QualifierValues { get; }
-->

# Windows.ApplicationModel.Resources.Core.ResourceContext.QualifierValues

## -description
Gets a writable, observable map of all supported qualifiers, indexed by name.

## -property-value
The map of qualifiers. 

Here are the possible string qualifier names that you can map to string qualifier values. 

| Qualifier name | Qualifier value |
|----------|------------|
| "Language" | This qualifier name can be mapped to a string value that represents the language, such as, "en-us" for United States English. |
| "Contrast" | This qualifier name can be mapped to one of these values:<br> "standard" <br>"high" <br>"black" <br>"white" |
| "Scale" | This qualifier name can be mapped to one of these values for scale of the display as a percentage: <br>"80" <br>"100" <br>"120" <br>"125" (Windows 10 only) <br>"140" <br>"150" (Windows 10 only) <br>"160" <br>"175" (Windows 10 only) <br>"180" <br>"200" <br>"225" (Windows 10 only) <br>"250" (Windows 10 only) <br>"300" (Windows 10 only) <br>"350" (Windows 10 only) <br>"400" (Windows 10 only) <br>"450" (Windows 10 only) |
| "DeviceFamily" | This qualifier name can be mapped to a string value that represents the device family of the device that your app is currently running on, such as, "Desktop", "Mobile", and the names of the other device families. You can use the "DeviceFamily" qualifier name in your markup or Resource.resw filenames. For example, when your app is running on the mobile device family device family, the UI element `<TextBlock x:Uid="DeviceFriendlyName"/>` will use the text and foreground resources defined in your Resources.DeviceFamily-Mobile.resw file if it contains: `<data name="DeviceFriendlyName.Foreground" xml:space="preserve"><value>Red</value></data><data name="DeviceFriendlyName.Text" xml:space="preserve"><value>Mobile device</value></data>` |
| "HomeRegion" | This qualifier name can be mapped to a string value that represents the region, such as, "021" for North America. |
| "TargetSize" | This qualifier name can be mapped to a string value that represents the size of the target, such as, "256". |
| "LayoutDirection" | This qualifier name can be mapped to one of these values: <br>"LTR" (layout direction is left to right.) <br>"RTL" (layout direction is right to left.) <br>"TTBLTR" (layout direction is top to bottom and left to right.) <br>"TTBRTL" (layout direction is top to bottom and right to left.) |
| "Configuration" | This qualifier name can be mapped to a string value that represents the configuration. |
| "AlternateForm" | This qualifier name can be mapped to a string value that represents the alternate form. |
| "DXFeatureLevel" | This qualifier name can be mapped to one of these values for the [DirectX feature level](http://msdn.microsoft.com/library/5ad0525c-249f-452d-950b-df8fa2addde2): <br>"DX9" (targets features supported by Direct3D 9.x.) <br>"DX10" (targets features supported by Direct3D 10.x.) <br>"DX11" (targets features supported by Direct3D 11.x.) |

## -remarks

## -examples

## -see-also
