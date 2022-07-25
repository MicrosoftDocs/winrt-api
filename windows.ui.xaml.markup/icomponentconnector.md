---
-api-id: T:Windows.UI.Xaml.Markup.IComponentConnector
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IComponentConnector : 
-->

# Windows.UI.Xaml.Markup.IComponentConnector

## -description
Provides infrastructure support for event wiring and build actions.



## -remarks


> **Windows 10**
> Apps compiled by the XAML compiler for Windows 10 implement [IComponentConnector2](icomponentconnector2.md). Apps will fall back to IComponentConnector for compatibility if necessary.

Unless you are substantially extending the capabilities of a XAML framework or XAML design tools, you probably won't need to generate or implement IComponentConnector. The remainder of the remarks here are intended to orient you to the purpose of IComponentConnector in the [Application](../windows.ui.xaml/application.md)-based app model and to explain the role of IComponentConnector in the generated code that Microsoft Visual Studio infrastructure creates as part of a typical XAML project.

By default, when you add a XAML page to a UWP app project in Microsoft Visual Studio, its **BuildAction** is **Page**. When you build the project, all project items with that build action are processed, and code files that match the programming language choice of the project are generated. The generated code files all contain the string ".g" in their name and can be observed in the obj folder of the project after compilation. The generated files implement one part of the partial class definition that the [Application](../windows.ui.xaml/application.md)-based app model uses to connect XAML and code aspects of an app definition. The process of generating partial classes from XAML is sometimes referred to as *markup compilation.*

Every element in XAML that has a XAML name ([x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) or [Name](../windows.ui.xaml/frameworkelement_name.md) attribute applied) or an event handler declared generates a call to [IComponentConnector.Connect](icomponentconnector_connect_1098159912.md) within the generated code file. The infrastructure code for XAML build actions then defines fields that match the names on the elements. If there's event wiring done in XAML, the build actions attach the event handlers to the XAML-created instances. The fields provide the access point that both app code and infrastructure code can use to reference the object that is created as a result of parsing the XAML.

For example, if there is a XAML element for a [Button](../windows.ui.xaml.controls/button.md) named "button1" in the XAML file and it has an attribute for the Click event that references a named handler method, Microsoft Visual Studio will autogenerate an implementation of [Connect](icomponentconnector_connect_1098159912.md) method from the IComponentConnector interface. The *connectionId* parameter is an identifier token to distinguish calls, and the *target* parameter is the target to connect events and names to.

## -examples
The Microsoft Visual Studio generated code for IComponentConnector that parallels the "button1" scenario described above might resemble the following:

```csharp
partial class MainPage : Windows.UI.Xaml.Controls.Page, IComponentConnector
    {
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 21 "..\..\MainPage.xaml"
                ((Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.button1_Click_1;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
```



## -see-also
[XAML overview](/windows/uwp/xaml-platform/xaml-overview), [x:Class attribute](/windows/uwp/xaml-platform/x-class-attribute)
