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
The map of qualifiers. Here are the possible string qualifier names that you can map to string qualifier values. <termdeflist layout="termdef"><termdef><name>"Language"</name>This qualifier name can be mapped to a string value that represents the language, such as, "en-us" for United States English.</termdef><termdef><name>"Contrast"</name>This qualifier name can be mapped to one of these values:<termdeflist layout="termdef"><termdef><name>"standard"</name></termdef><termdef><name>"high"</name></termdef><termdef><name>"black"</name></termdef><termdef><name>"white"</name></termdef></termdeflist></termdef><termdef><name>"Scale"</name>This qualifier name can be mapped to one of these values for scale of the display as a percentage:<termdeflist layout="termdef"><termdef><name>"80"</name></termdef><termdef><name>"100"</name></termdef><termdef><name>"120"</name></termdef><termdef><name>"125" (Windows 10 only)</name></termdef><termdef><name>"140"</name></termdef><termdef><name>"150" (Windows 10 only)</name></termdef><termdef><name>"160"</name></termdef><termdef><name>"175" (Windows 10 only)</name></termdef><termdef><name>"180"</name></termdef><termdef><name>"200"</name></termdef><termdef><name>"225" (Windows 10 only)</name></termdef><termdef><name>"250" (Windows 10 only)</name></termdef><termdef><name>"300" (Windows 10 only)</name></termdef><termdef><name>"350" (Windows 10 only)</name></termdef><termdef><name>"400" (Windows 10 only)</name></termdef><termdef><name>"450" (Windows 10 only)</name></termdef></termdeflist></termdef><termdef><name>"DeviceFamily"</name>This qualifier name can be mapped to a string value that represents the device family of the device that your app is currently running on, such as, "Desktop", "Mobile", and the names of the other device families. You can use the "DeviceFamily" qualifier name in your markup or Resource.resw filenames. For example, when your app is running on the mobile device family device family, the UI element `<TextBlock x:Uid="DeviceFriendlyName"/>` will use the text and foreground resources defined in your Resources.DeviceFamily-Mobile.resw file if it contains: `<data name="DeviceFriendlyName.Foreground" xml:space="preserve"><value>Red</value></data><data name="DeviceFriendlyName.Text" xml:space="preserve"><value>Mobile device</value></data>`.</termdef><termdef><name>"HomeRegion"</name>This qualifier name can be mapped to a string value that represents the region, such as, "021" for North America.</termdef><termdef><name>"TargetSize"</name>This qualifier name can be mapped to a string value that represents the size of the target, such as, "256".</termdef><termdef><name>"LayoutDirection"</name>This qualifier name can be mapped to one of these values:<termdeflist layout="termdef"><termdef><name>"LTR"</name>Layout direction is left to right.</termdef><termdef><name>"RTL"</name>Layout direction is right to left.</termdef><termdef><name>"TTBLTR"</name>Layout direction is top to bottom and left to right.</termdef><termdef><name>"TTBRTL"</name>Layout direction is top to bottom and right to left.</termdef></termdeflist></termdef><termdef><name>"Configuration"</name>This qualifier name can be mapped to a string value that represents the configuration.</termdef><termdef><name>"AlternateForm"</name>This qualifier name can be mapped to a string value that represents the alternate form.</termdef><termdef><name>"DXFeatureLevel"</name>This qualifier name can be mapped to one of these values for the [DirectX feature level](http://msdn.microsoft.com/library/5ad0525c-249f-452d-950b-df8fa2addde2):<termdeflist layout="termdef"><termdef><name>"DX9"</name>Targets features supported by Direct3D 9.x.</termdef><termdef><name>"DX10"</name>Targets features supported by Direct3D 10.x.</termdef><termdef><name>"DX11"</name>Targets features supported by Direct3D 11.x.</termdef></termdeflist></termdef></termdeflist>

## -remarks

## -examples

## -see-also
