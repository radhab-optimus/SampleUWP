using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace UIPages.Controls
{
    public sealed partial class MessageTemplate : UserControl
    {


        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // using a DependencyProperty as the backing store for text.  this enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(MessageTemplate), new PropertyMetadata(null));



        public string DateProvided
        {
            get { return (string)GetValue(DateProperty); }
            set { SetValue(DateProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Date.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DateProperty =
            DependencyProperty.Register("DateProvided", typeof(string), typeof(MessageTemplate), new PropertyMetadata(null));



        public string Sender
        {
            get { return (string)GetValue(SenderProperty); }
            set { SetValue(SenderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Sender.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SenderProperty =
            DependencyProperty.Register("Sender", typeof(string), typeof(MessageTemplate), new PropertyMetadata(null));



        public bool IsSender
        {
            get { return (bool)GetValue(IsSenderProperty); }
            set { SetValue(IsSenderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsSender.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsSenderProperty =
            DependencyProperty.Register("IsSender", typeof(bool), typeof(MessageTemplate), new PropertyMetadata(false));

        public MessageTemplate()
        {
            this.InitializeComponent();
        }
    }
}
