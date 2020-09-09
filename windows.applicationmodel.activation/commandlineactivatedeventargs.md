---
-api-id: T:Windows.ApplicationModel.Activation.CommandLineActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class CommandLineActivatedEventArgs : IActivatedEventArgs, IActivatedEventArgsWithUser, ICommandLineActivatedEventArgs
-->

# Windows.ApplicationModel.Activation.CommandLineActivatedEventArgs

## -description
Provides information, such as the command-line arguments, when an app is activated from the command line.

## -remarks
A UWP app may be activated from **Start|Run** in Windows, from the command line in PowerShell, the DOS command prompt, or from another Win32 process that calls [CreateProcess()](/windows/desktop/api/processthreadsapi/nf-processthreadsapi-createprocessa).

To be activated from the command line, your app must register for the "AppExecutionAlias" extension category in its manifest.

```xml
<uap5:Extension Category="windows.appExecutionAlias" Executable="FruitSalad.exe" EntryPoint="Windows.FruitSalad.Bananas.App">
    <uap5:AppExecutionAlias >
        <uap5:ExecutionAlias Alias="Fs.exe" />
    </uap5:AppExecutionAlias>
</uap5:Extension>
```
After you register in your manifest, your app can be activated from the command line. When your app is activated, you can use the event information to identify the call activation and extract the parameters that help you complete the call for the user.

## -examples
Here is an example of handling a command-line launch:

```csharp
protected override void OnActivated(IActivatedEventArgs args)
{
    string activationArgString = string.Empty;
    string activationPath = string.Empty;
    string cmdLineString = string.Empty;
    
    // Existing behavior to differentiate different activation kinds,
    // and to extract any argument payload.
    switch (args.Kind)
    {
        case ActivationKind.Launch:
            var launchArgs = args as LaunchActivatedEventArgs;
            activationArgString = launchArgs.Arguments;
            break;

        // A new ActivationKind for console activation of a windowed app.
        case ActivationKind.CommandLineLaunch:
            CommandLineActivatedEventArgs cmdLineArgs = args as CommandLineActivatedEventArgs;
            CommandLineActivationOperation operation = cmdLineArgs.Operation;
            cmdLineString = operation.Arguments;
            activationPath = operation.CurrentDirectoryPath;
            break;
    }

    // Parse the trusted activation arguments.
    ParseTrustedArgs(activationArgString);

    // Parse the untrusted command-line arguments.
    ParseUntrustedArgs(activationPath, cmdLineString);

    // Since we did not take a deferral, the calling app gets the result
    // as soon as this method returns. Since we did not set an exit code,
    // the calling app gets a default exit code as the result.
}    
```

## -see-also
