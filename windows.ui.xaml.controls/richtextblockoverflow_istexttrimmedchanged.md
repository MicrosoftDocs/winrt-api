---
-api-id: E:Windows.UI.Xaml.Controls.RichTextBlockOverflow.IsTextTrimmedChanged
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler IsTextTrimmedChanged<RichTextBlockOverflow, IsTextTrimmedChangedEventArgs>
-->

# Windows.UI.Xaml.Controls.RichTextBlockOverflow.IsTextTrimmedChanged

## -description

Occurs when the [IsTextTrimmed](richtextblockoverflow_istexttrimmed.md) property value has changed.



## -xaml-syntax

```xaml
<RichTextBlockOverflow IsTextTrimmedChanged="eventhandler"/>
```

## -remarks

If the TextTrimming property of [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md)/[TextBlock](../windows.ui.xaml.controls/textblock.md) is set to None (default), no trim indicator is drawn and the [IsTextTrimmedChanged](richtextblockoverflow_istexttrimmedchanged.md) event does not fire.

## -see-also

## -examples

In this example, we construct a three column layout using a [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md) and two [RichTextBlockOverflow](richtextblockoverflow.md) controls. We set the [TextTrimming](richtextblock_texttrimming.md) property of the [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md) to CharacterEllipsis and bind it to the first [RichTextBlockOverflow](richtextblockoverflow.md), which is then bound to the second [RichTextBlockOverflow](richtextblockoverflow.md).

Resizing the window causes the columns to resize, which triggers the [IsTextTrimmedChanged](richtextblockoverflow_istexttrimmedchanged.md) event.

``` xaml
<StackPanel>
    <Grid x:Name="ColumnGrid" Height="200">
        <Grid.ColumnDefinitions>
            <ColumnDefinition />
            <ColumnDefinition />
            <ColumnDefinition />
        </Grid.ColumnDefinitions>
        <RichTextBlock Grid.Column="0" Margin="12,0" 
                        OverflowContentTarget="{x:Bind firstOverflowContainer}"
                        TextAlignment="Justify" TextTrimming="CharacterEllipsis"                         
                        IsTextTrimmedChanged="RichTextBlock_IsTextTrimmedChanged">
            <Paragraph>
                Linked text containers allow text which does not fit in one element 
                to overflow into a different element on the page. Creative use of 
                linked text containers enables basic multicolumn support and other 
                advanced page layouts.
            </Paragraph>
            <Paragraph>
                Duis sed nulla metus, id hendrerit velit. Curabitur dolor purus, 
                bibendum eu cursus lacinia, interdum vel augue. Aenean euismod 
                eros et sapien vehicula dictum. Duis ullamcorper, turpis nec 
                feugiat tincidunt, dui erat luctus risus, aliquam accumsan 
                lacus est vel quam. Nunc lacus massa, varius eget accumsan id, 
                congue sed orci. Duis dignissim hendrerit egestas. Proin ut 
                turpis magna, sit amet porta erat. Nunc semper metus nec magna 
                imperdiet nec vestibulum dui fringilla. Sed sed ante libero, 
                nec porttitor mi. Ut luctus, neque vitae placerat egestas, 
                urna leo auctor magna, sit amet ultricies ipsum felis quis 
                sapien. Proin eleifend varius dui, at vestibulum nunc 
                consectetur nec. Mauris nulla elit, ultrices a sodales non, 
                aliquam ac est. Quisque sit amet risus nulla. Quisque 
                vestibulum posuere velit, vitae vestibulum eros scelerisque 
                sit amet. In in risus est, at laoreet dolor. Nullam aliquet 
                pellentesque convallis. Ut vel tincidunt nulla. Mauris auctor 
                tincidunt auctor.
                Aenean orci ante, vulputate ac sagittis sit amet, consequat at mi. 
                Morbi elementum purus consectetur nisi adipiscing vitae blandit 
                sapien placerat. Aliquam adipiscing tortor non sem lobortis 
                consectetur mattis felis rhoncus. Nunc eu nunc rhoncus arcu 
                sollicitudin ultrices. In vulputate eros in mauris aliquam id 
                dignissim nisl laoreet.
            </Paragraph>
        </RichTextBlock>
        <RichTextBlockOverflow x:Name="firstOverflowContainer" Grid.Column="1"  Margin="12,0"
                                IsTextTrimmedChanged="OverflowContainer_IsTextTrimmedChanged"
                                OverflowContentTarget="{x:Bind secondOverflowContainer}" />
        <RichTextBlockOverflow x:Name="secondOverflowContainer" Grid.Column="2" Margin="12,0" 
                                IsTextTrimmedChanged="OverflowContainer_IsTextTrimmedChanged"/>
    </Grid>
</StackPanel>
```

```csharp
namespace TextTrimming1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void RichTextBlock_IsTextTrimmedChanged(RichTextBlock sender, IsTextTrimmedChangedEventArgs args)
        {
            if (sender.IsTextTrimmed)
            {
                //do something
            }
        }

        private void OverflowContainer_IsTextTrimmedChanged(RichTextBlockOverflow sender, IsTextTrimmedChangedEventArgs args)
        {
            if (sender.IsTextTrimmed)
            {
                ColumnGrid.Height += 100;
            }
        }
    }
}
```
