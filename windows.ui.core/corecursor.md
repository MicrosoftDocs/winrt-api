---
-api-id: T:Windows.UI.Core.CoreCursor
-api-type: winrt class
---

<!-- Class syntax.
public class CoreCursor : Windows.UI.Core.ICoreCursor
-->

# Windows.UI.Core.CoreCursor

## -description
Defines a cursor (visual pointer) object.

## -remarks

To create a CoreCursor instance using a pre-defined Windows cursor, use any of the cursor types available in the [CoreCursorType](corecursortype.md) enumeration other than **Custom**. In this case, the **Id** property is ignored.

To use a custom cursor, use the **CoreCursorType.Custom** enumeration option, and specify the **Id** of the custom cursor. You can add a _.res_ resource file that contains the custom cursor to your project and include it in your assembly with the [/win32res](/dotnet/articles/csharp/language-reference/compiler-options/win32res-compiler-option) compiler option. The **Id** is the [Cursor Resource ID](/windows/desktop/menurc/cursor-resource) specified in the _.res_ file.

## -examples

This example shows how to set a "hand" cursor when the pointer is over a button.

```xaml
<Grid Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">
    <Button Content="Button 1"
            PointerEntered="Button_PointerEntered"
            PointerExited="Button_PointerExited"/>
</Grid>
```

```csharp
public sealed partial class MainPage : Page
{
    CoreCursor buttonCursor = null;
    CoreCursor cursorBeforePointerEntered = null;

    public MainPage()
    {
        this.InitializeComponent();
        buttonCursor = new CoreCursor(CoreCursorType.Hand, 0);
    }

    private void Button_PointerEntered(object sender, PointerRoutedEventArgs e)
    {
        // Cache the cursor set before pointer enter on button.
        cursorBeforePointerEntered = Window.Current.CoreWindow.PointerCursor;
        // Set button cursor.
        Window.Current.CoreWindow.PointerCursor = buttonCursor;
    }

    private void Button_PointerExited(object sender, PointerRoutedEventArgs e)
    {
        // Change the cursor back.
        Window.Current.CoreWindow.PointerCursor = cursorBeforePointerEntered;
    }
}
```

## -see-also