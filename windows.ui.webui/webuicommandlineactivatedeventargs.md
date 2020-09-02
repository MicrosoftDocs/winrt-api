---
-api-id: T:Windows.UI.WebUI.WebUICommandLineActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class WebUICommandLineActivatedEventArgs : IActivatedEventArgs, IActivatedEventArgsWithUser, ICommandLineActivatedEventArgs, IActivatedEventArgsDeferral
-->

# Windows.UI.WebUI.WebUICommandLineActivatedEventArgs

## -description
Provides information, such as the command-line arguments, when an app is activated from the command line.

## -remarks
A UWP app may be activated from **Start|Run** in Windows, from the command line in PowerShell, the DOS command prompt, or from another Win32 process that calls [CreateProcess](/windows/desktop/api/processthreadsapi/nf-processthreadsapi-createprocessa).

To be activated from the command line, your app must register for the "AppExecutionAlias" extension category in its manifest.

## -see-also

## -examples

