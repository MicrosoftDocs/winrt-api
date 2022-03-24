---
-api-id: M:Windows.ApplicationModel.Core.CoreApplication.CreateNewView(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Core.CoreApplicationView CreateNewView(System.String runtimeType, System.String entryPoint)
-->

# Windows.ApplicationModel.Core.CoreApplication.CreateNewView

## -description
Creates a new view for the app.

## -parameters
### -param runtimeType
The class ID of the view provider for the new view. If this parameter is null, use the current view provider.

### -param entryPoint
Additional info about the view, such as its class name in the app code.

## -returns
The view.

## -remarks
You cannot create a new view while the app is suspending or resuming.

## -examples

## -see-also
[CreateNewView](coreapplication_createnewview_888060163.md)