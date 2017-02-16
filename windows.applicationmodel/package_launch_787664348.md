---
-api-id: M:Windows.ApplicationModel.Package.Launch(System.String)
-api-type: winrt method
---

<!-- Method syntax
public void Launch(System.String parameters)
-->

# Windows.ApplicationModel.Package.Launch

## -description
Windows Phone only. Launches the specified application.

## -parameters
### -param parameters
The navigation URI that specifies the page to launch and optional parameters. Use an empty string to specify the default page for the app.

## -remarks
The Launch parameter has the same format as the **NavigationUri** format. The following table shows some examples:

<table>
   <tr><th>Scenario</th><th>Launch parameter</th><th>Example</th></tr>
   <tr><td>You just want to launch the app with the default page.</td><td>Specify an empty string.</td><td>`pkg.Launch("");`</td></tr>
   <tr><td>You want to launch to a particular XAML page.</td><td>Start with a forward slash (/) followed by the XAML page name.</td><td>`pkg.Launch("/Page1.xaml");`</td></tr>
   <tr><td>You want to pass parameters to the default page.</td><td>Start with a question mark (?) followed by name/value pairs. Use an equal sign (=) between the name and value. Separate multiple name/value pairs with an ampersand (&amp;).</td><td>`pkg.Launch("?content=1234&param2=test");`</td></tr>
   <tr><td>You want to launch to a particular XAML page and pass in parameters.</td><td>Use a combination of the previous two examples.</td><td>`pkg.Launch("/Page1.xaml?content=1234&param2=test ");`</td></tr>
</table>



> [!IMPORTANT]
> The [Launch](package_launch.md) method only works if it is called from a Windows Phone Silverlight app.

## -examples

## -see-also
