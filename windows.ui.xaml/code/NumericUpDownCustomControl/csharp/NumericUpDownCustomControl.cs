using System;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Controls.Primitives;

namespace NumericUpDownCustomControl
{
    //<SnippetClassAttributes>
    [TemplatePart(Name = "TextElement", Type = typeof(TextBlock))]
    [TemplatePart(Name = "UpButtonElement", Type = typeof(RepeatButton))]
    [TemplatePart(Name = "DownButtonElement", Type = typeof(RepeatButton))]
    [TemplateVisualState(Name = "Positive", GroupName = "ValueStates")]
    [TemplateVisualState(Name = "Negative", GroupName = "ValueStates")]
    [TemplateVisualState(Name = "Focused", GroupName = "FocusedStates")]
    [TemplateVisualState(Name = "Unfocused", GroupName = "FocusedStates")]
    public class NumericUpDown : Control
    //</SnippetClassAttributes>
    {
        public NumericUpDown()
        {
            this.DefaultStyleKey = typeof(NumericUpDown);
            this.IsTabStop = true;
        }
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(Int32), typeof(NumericUpDown),
                            new PropertyMetadata(0,new PropertyChangedCallback(ValueChangedCallback)));


        //<SnippetEntireValueChangedCallback>
        //<SnippetValueChangedCallback>
        private static void ValueChangedCallback(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            NumericUpDown ctl = (NumericUpDown)obj;
            Int32 newValue = (Int32)args.NewValue;

            // Update the TextElement to the new value.
            if (ctl.TextElement != null)
            {
                ctl.TextElement.Text = newValue.ToString();
            }

            //</SnippetValueChangedCallback>
            // Call UpdateStates because the Value might have caused the
            // control to change ValueStates.
            ctl.UpdateStates(true);

            // Raise the ValueChanged event so applications can be alerted
            // when Value changes.
            ValueChangedEventArgs e = new ValueChangedEventArgs(newValue);
            ctl.OnValueChanged(e);
            //<SnippetValueChangedCallbackEnd>
        }
        //</SnippetValueChangedCallbackEnd>
        //</SnippetEntireValueChangedCallback>


        public event ValueChangedEventHandler ValueChanged;

        protected virtual void OnValueChanged(ValueChangedEventArgs e)
        {
            ValueChangedEventHandler handler = ValueChanged;

            if (handler != null)
            {
                handler(this, e);
            }
        }

        //<SnippetUpdateStates>
        private void UpdateStates(bool useTransitions)
        {
            //<SnippetValueStateChange>
            if (Value >= 0)
            {
                VisualStateManager.GoToState(this, "Positive", useTransitions);
            }
            else
            {
                VisualStateManager.GoToState(this, "Negative", useTransitions);
            }
            //</SnippetValueStateChange>

            if (isFocused)
            {
                VisualStateManager.GoToState(this, "Focused", useTransitions);
            }
            else
            {
                VisualStateManager.GoToState(this, "Unfocused", useTransitions);
            }

        }
        //</SnippetUpdateStates>

        public Int32 Value
        {
            get
            {
                return (Int32)GetValue(ValueProperty);
            }

            set
            {
                SetValue(ValueProperty, value);

            }
        }


        //<SnippetApplyTemplate>
        protected override void OnApplyTemplate()
        {
            UpButtonElement = GetTemplateChild("UpButton") as RepeatButton;
            DownButtonElement = GetTemplateChild("DownButton") as RepeatButton;
            TextElement = GetTemplateChild("TextBlock") as TextBlock;

            UpdateStates(false);
        }
        //</SnippetApplyTemplate>

        private TextBlock textElement;

        private TextBlock TextElement
        {
            get { return textElement; }

            set
            {
                textElement = value;

                if (textElement != null)
                {
                    textElement.Text = Value.ToString();
                    textElement.IsHitTestVisible = true;
                }
            }

        }

        private RepeatButton downButtonElement;

        private RepeatButton DownButtonElement
        {
            get
            {
                return downButtonElement;
            }

            set
            {
                if (downButtonElement != null)
                {
                    downButtonElement.Click -=
                        new RoutedEventHandler(downButtonElement_Click);
                }
                downButtonElement = value;

                if (downButtonElement != null)
                {
                    downButtonElement.Click +=
                        new RoutedEventHandler(downButtonElement_Click);
                }
            }
        }

        void downButtonElement_Click(object sender, RoutedEventArgs e)
        {
            Value--;
        }

        //<SnippetUpButtonProperty>
        private RepeatButton upButtonElement;

        private RepeatButton UpButtonElement
        {
            get
            {
                return upButtonElement;
            }

            set
            {
                if (upButtonElement != null)
                {
                    upButtonElement.Click -=
                        new RoutedEventHandler(upButtonElement_Click);
                }
                upButtonElement = value;

                if (upButtonElement != null)
                {
                    upButtonElement.Click +=
                        new RoutedEventHandler(upButtonElement_Click);
                }
            }
        }
        //</SnippetUpButtonProperty>

        void upButtonElement_Click(object sender, RoutedEventArgs e)
        {
            Value++;
        }

        //<SnippetControlFocus>
        protected override void OnPointerPressed(PointerRoutedEventArgs e)
        {
            base.OnPointerPressed(e);
            Focus(Windows.UI.Xaml.FocusState.Programmatic);
        }
        //</SnippetControlFocus>

        //<SnippetFocusProperty>
        bool isFocused;

        //<SnippetOnGotFocus>
        protected override void OnGotFocus(RoutedEventArgs e)
        {
            base.OnGotFocus(e);
            isFocused = true;
            UpdateStates(true);
        }
        //</SnippetOnGotFocus>

        protected override void OnLostFocus(RoutedEventArgs e)
        {
            base.OnLostFocus(e);
            isFocused = false;
            UpdateStates(true);
        }
        //</SnippetFocusProperty>

    }


    public delegate void ValueChangedEventHandler(object sender, ValueChangedEventArgs e);

    public class ValueChangedEventArgs : EventArgs
    {
        private int _value;

        public ValueChangedEventArgs(int num)
        {
            _value = num;
        }

        public int Value
        {
            get { return _value; }
        }
    }
}
//</SnippetControlLogic>
