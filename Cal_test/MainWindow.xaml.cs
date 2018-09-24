using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Windows.Interop;
using Me.BarcodeSoftware.Barcode;
using Application = System.Windows.Application;

namespace Cal_test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long number1 = 0;
        long number2 = 0;
        string operation = "";
        string theText = ""; 

        RawStuff.InputDevice id;
        int NumberOfKeyboards;
        Message message = new Message();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                Ans.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                Ans.Text = number2.ToString();

            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {

            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                Ans.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                Ans.Text = number2.ToString();

            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                Ans.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                Ans.Text = number2.ToString();

            }
        }



        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                Ans.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                Ans.Text = number2.ToString();

            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                Ans.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                Ans.Text = number2.ToString();

            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                Ans.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                Ans.Text = number2.ToString();

            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                Ans.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) +7;
                Ans.Text = number2.ToString();

            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                Ans.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                Ans.Text = number2.ToString();

            }
        }





        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                Ans.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                Ans.Text = number2.ToString();

            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 0;
                Ans.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 0;
                Ans.Text = number2.ToString();

            }
        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            Ans.Text = "0";
        }

        private void btnmin_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            Ans.Text = "0";
        }

        private void btnmul_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            Ans.Text = "0";
        }

        private void btndiv_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            Ans.Text = "0";
        }

        private void btneq_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    Ans.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    Ans.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    Ans.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    Ans.Text = (number1 / number2).ToString();
                    break;

            }
        }

        private void btnPvNv_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 *= -1;
                Ans.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
                Ans.Text = number2.ToString();

            }
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            if (operation=="")
            {
                number1 = 0;   
            }
            else
            {
                number2 = 0;
            }
            Ans.Text = "0";
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            Ans.Text = "0";

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 / 10);
                Ans.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 / 10);
                Ans.Text = number2.ToString();

            }
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.NumPad1)
            {
                if (operation == "")
                {
                    number1 = (number1 * 10) + 1;
                    Ans.Text = number1.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 1;
                    Ans.Text = number2.ToString();

                }
            }
            if (e.Key == Key.NumPad2)
            {
                if (operation == "")
                {
                    number1 = (number1 * 10) + 2;
                    Ans.Text = number1.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 2;
                    Ans.Text = number2.ToString();

                }
            }
            if (e.Key == Key.NumPad3)
            {
                if (operation == "")
                {
                    number1 = (number1 * 10) + 3;
                    Ans.Text = number1.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 3;
                    Ans.Text = number2.ToString();

                }
            }
            if (e.Key == Key.NumPad4)
            {
                if (operation == "")
                {
                    number1 = (number1 * 10) + 4;
                    Ans.Text = number1.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 4;
                    Ans.Text = number2.ToString();

                }
            }
            if (e.Key == Key.NumPad5)
            {
                if (operation == "")
                {
                    number1 = (number1 * 10) + 5;
                    Ans.Text = number1.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 5;
                    Ans.Text = number2.ToString();

                }
            }
            if (e.Key == Key.NumPad6)
            {
                if (operation == "")
                {
                    number1 = (number1 * 10) + 6;
                    Ans.Text = number1.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 6;
                    Ans.Text = number2.ToString();

                }
            }
            if (e.Key == Key.NumPad7)
            {
                if (operation == "")
                {
                    number1 = (number1 * 10) + 7;
                    Ans.Text = number1.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 7;
                    Ans.Text = number2.ToString();

                }
            }
            if (e.Key == Key.NumPad8)
            {
                if (operation == "")
                {
                    number1 = (number1 * 10) +8;
                    Ans.Text = number1.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 8;
                    Ans.Text = number2.ToString();

                }
            }
            if (e.Key == Key.NumPad9)
            {
                if (operation == "")
                {
                    number1 = (number1 * 10) + 9;
                    Ans.Text = number1.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 9;
                    Ans.Text = number2.ToString();

                }
            }
            if (e.Key == Key.NumPad0)
            {
                if (operation == "")
                {
                    number1 = (number1 * 10) + 0;
                    Ans.Text = number1.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 0;
                    Ans.Text = number2.ToString();

                }
            }

            if (e.Key == Key.Back)
            {
                if (operation == "")
                {
                    number1 = (number1 / 10);
                    Ans.Text = number1.ToString();
                }
                else
                {
                    number2 = (number2 / 10);
                    Ans.Text = number2.ToString();

                }
            }
            if(e.Key == Key.Add)
            {
                operation = "+";
                Ans.Text = "0";
            }
            if (e.Key == Key.Subtract)
            {
                operation = "-";
                Ans.Text = "0";
                //lovin
            }

            if (e.Key == Key.Multiply)
            {
                operation = "*";
                Ans.Text = "0";
            }
            if (e.Key == Key.Divide)
            {
                operation = "/";
                Ans.Text = "0";
            }
            if (e.Key == Key.Enter)
            {
                switch (operation)
                {
                    case "+":
                        Ans.Text = (number1 + number2).ToString();
                        break;
                    case "-":
                        Ans.Text = (number1 - number2).ToString();
                        break;
                    case "*":
                        Ans.Text = (number1 * number2).ToString();
                        break;
                    case "/":
                        Ans.Text = (number1 / number2).ToString();
                        break;

                }
            }

        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }



        public IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            if (id != null)
            {
                message.HWnd = hwnd;
                message.Msg = msg;
                message.LParam = lParam;
                message.WParam = wParam;
                id.ProcessMessage(message);
            }
            return IntPtr.Zero;
        }
    
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
       {
            System.Windows.Controls.TextBox objTextBox = (System.Windows.Controls.TextBox)sender;
             theText = objTextBox.Text;
        }

        private void end(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                /////////////////////////////////////
                // Encode The Data
                /////////////////////////////////////
                Barcodes bb = new Barcodes();
                bb.BarcodeType = Barcodes.BarcodeEnum.Code39;
                bb.Data = theText;
                bb.CheckDigit = Barcodes.YesNoEnum.Yes;
                bb.encode();

                int thinWidth;
                int thickWidth;

                thinWidth = 3;
                thickWidth = 3 * thinWidth;

                string outputString = bb.EncodedData;
                string humanText = bb.HumanText;


                /////////////////////////////////////
                // Draw The Barcode
                /////////////////////////////////////
                int len = outputString.Length;
                int currentPos = 10;
                int currentTop = 10;
                int currentColor = 0;
                for (int i = 0; i < len; i++)
                {
                    Rectangle rect = new Rectangle();
                    rect.Height = 200;
                    if (currentColor == 0)
                    {
                        currentColor = 1;
                        rect.Fill = new SolidColorBrush(Colors.Black);

                    }
                    else
                    {
                        currentColor = 0;
                        rect.Fill = new SolidColorBrush(Colors.White);

                    }
                    Canvas.SetLeft(rect, currentPos);
                    Canvas.SetTop(rect, currentTop);

                    if (outputString[i] == 't')
                    {
                        rect.Width = thinWidth;
                        currentPos += thinWidth;

                    }
                    else if (outputString[i] == 'w')
                    {
                        rect.Width = thickWidth;
                        currentPos += thickWidth;

                    }
                    mainCanvas.Children.Add(rect);

                }


                /////////////////////////////////////
                // Add the Human Readable Text
                /////////////////////////////////////
                TextBlock tb = new TextBlock();
                tb.Text = humanText;
                tb.FontSize = 32;
                tb.FontFamily = new FontFamily("Courier New");
                Rect rx = new Rect(0, 0, 0, 0);
                tb.Arrange(rx);
                Canvas.SetLeft(tb, (currentPos - tb.ActualWidth) / 2);
                Canvas.SetTop(tb, currentTop + 205);
                mainCanvas.Children.Add(tb);
                System.Windows.MessageBox.Show(theText);
                testval.Text = String.Empty;
                mainCanvas.Children.Clear();
            }
        }
    }
}
