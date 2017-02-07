using System;
using Windows.UI.Text;
using Windows.UI.Xaml;
//using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;

namespace StylingTemplatingOverview
{

    //<Snippet2>
    [TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
    [TemplateVisualState(Name = "PointerOver", GroupName = "CommonStates")]
    [TemplateVisualState(Name = "Pressed", GroupName = "CommonStates")]
    [TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
    [TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
    [TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
    public class Button : ButtonBase
    {
        public static readonly DependencyProperty BackgroundProperty;
        public static readonly DependencyProperty BorderBrushProperty;
        public static readonly DependencyProperty BorderThicknessProperty;
        public static readonly DependencyProperty ContentProperty;
        public static readonly DependencyProperty ContentTemplateProperty;
        public static readonly DependencyProperty FontFamilyProperty;
        public static readonly DependencyProperty FontSizeProperty;
        public static readonly DependencyProperty FontStretchProperty;
        public static readonly DependencyProperty FontStyleProperty;
        public static readonly DependencyProperty FontWeightProperty;
        public static readonly DependencyProperty ForegroundProperty;
        public static readonly DependencyProperty HorizontalContentAlignmentProperty;
        public static readonly DependencyProperty PaddingProperty;
        public static readonly DependencyProperty TextAlignmentProperty;
        public static readonly DependencyProperty TextDecorationsProperty;
        public static readonly DependencyProperty TextWrappingProperty;
        public static readonly DependencyProperty VerticalContentAlignmentProperty;

        public Brush Background { get; set; }
        public Brush BorderBrush { get; set; }
        public Thickness BorderThickness { get; set; }
        public object Content { get; set; }
        public DataTemplate ContentTemplate { get; set; }
        public FontFamily FontFamily { get; set; }
        public double FontSize { get; set; }
        public FontStretch FontStretch { get; set; }
        public FontStyle FontStyle { get; set; }
        public FontWeight FontWeight { get; set; }
        public Brush Foreground { get; set; }
        public HorizontalAlignment HorizontalContentAlignment { get; set; }
        public Thickness Padding { get; set; }
        public TextAlignment TextAlignment { get; set; }
        public TextWrapping TextWrapping { get; set; }
        public VerticalAlignment VerticalContentAlignment { get; set; }
    }
    //</Snippet2>


    public class Control : Object
    {

    }

    public class ButtonBase { }
}

namespace contract2
{
    //<SnippetStateContract>
    [TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
    [TemplateVisualState(Name = "PointerOver", GroupName = "CommonStates")]
    [TemplateVisualState(Name = "Pressed", GroupName = "CommonStates")]
    [TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
    [TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
    [TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
    public class Button : ButtonBase
    {
    }
    //</SnippetStateContract>

    //<SnippetComboBoxContract>
    [TemplatePartAttribute(Name = "ContentPresenter", Type = typeof(ContentPresenter))]
    [TemplatePartAttribute(Name = "Popup", Type = typeof(Popup))]
    public class ComboBox : ItemsControl
    {
    }
    //</SnippetComboBoxContract>

    public class Control : Object { }
    public class ContentPresenter { }
    public class Popup : Control { }
    public class ItemsControl : Control { }
    public class ButtonBase { }
}