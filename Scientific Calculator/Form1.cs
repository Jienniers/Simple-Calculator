using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientific_Calculator
{
    public partial class Form1 : Form
    {
        Double results = 0;
        String operation = "";
        bool enter_value = false;
        float iCelsius, iFahrenheit, iKelvin;
        Char iOperation;
        bool off = false;
        bool sidePanel = false;
        bool dataShow = false;

        public Form1()
        {
            InitializeComponent();
            panel1.Hide();
            panel2.Hide();
            comboBox1.SelectedItem = "Kilobytes";
            comboBox2.SelectedItem = "Kilobytes";
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (enter_value))
                textBox1.Text = "";
            enter_value = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox1.Text.Contains(".") && symbolHolder.Text.EndsWith(operation))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + num.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            symbolHolder.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            symbolHolder.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if (textBox1.Text=="")
            {
                textBox1.Text = textBox1.Text = "0";
            }
        }

        private void Arthmetic_Operators(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;

            if (symbolHolder.Text.EndsWith(operation))
            {
                MessageBox.Show("Syntax error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                symbolHolder.Text = "";
            }
            else
            {
                results = Double.Parse(textBox1.Text);
                textBox1.Text = "";
                symbolHolder.Text = System.Convert.ToString(results) + " " + operation;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    if (symbolHolder.Text.EndsWith(operation))
                    {
                        if (symbolHolder.Text.StartsWith("0"))
                        {
                            MessageBox.Show("Syntax error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            symbolHolder.Text = "";
                        }
                        else
                        {
                            textBox1.Text = (results + Double.Parse(textBox1.Text)).ToString();
                            symbolHolder.Text = "";
                        }
                    }
                    break;

                case "-":
                    if (symbolHolder.Text.EndsWith(operation))
                    {
                        if (symbolHolder.Text.StartsWith("0"))
                        {
                            MessageBox.Show("Syntax error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            symbolHolder.Text = "";
                        }
                        else
                        {
                            textBox1.Text = (results - Double.Parse(textBox1.Text)).ToString();
                            symbolHolder.Text = "";
                        }
                    }
                    break;

                case "*":
                    if (symbolHolder.Text.EndsWith(operation))
                    {
                        if (symbolHolder.Text.StartsWith("0"))
                        {
                            MessageBox.Show("Syntax error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            symbolHolder.Text = "";
                        }
                        else
                        {
                            textBox1.Text = (results * Double.Parse(textBox1.Text)).ToString();
                            symbolHolder.Text = "";
                        }
                    }
                    break;

                case "/":
                    if (symbolHolder.Text.EndsWith(operation))
                    {
                        if (symbolHolder.Text.StartsWith("0"))
                        {
                            MessageBox.Show("Syntax error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            symbolHolder.Text = "";
                        }
                        else
                        {
                            textBox1.Text = (results / Double.Parse(textBox1.Text)).ToString();
                            symbolHolder.Text = "";
                        }
                    }
                    break;

                case "Exp":
                    if (symbolHolder.Text.EndsWith(operation))
                    {
                        if (symbolHolder.Text.StartsWith("0"))
                        {
                            MessageBox.Show("Syntax error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            symbolHolder.Text = "";
                        }
                        else
                        {
                            double i = Double.Parse(textBox1.Text);
                            double q;
                            q = (results);
                            textBox1.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                        }
                    }
                    break;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0)
            {
                MessageBox.Show("Syntax error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Button num = (Button)sender;
                operation = num.Text;
                results = Double.Parse(textBox1.Text);
                textBox1.Text = "";
                symbolHolder.Text = System.Convert.ToString(results) + " " + operation;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text = "3.141592653589793238";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            symbolHolder.Text = System.Convert.ToString("Log" + "(" + (textBox1.Text) + ")");
            ilog = Math.Log10(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            symbolHolder.Text = System.Convert.ToString("Sqrt" + "(" + (textBox1.Text) + ")");
            ilog = Math.Sqrt(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            symbolHolder.Text = System.Convert.ToString("Sinh" + "(" + (textBox1.Text) + ")");
            ilog = Math.Sinh(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            symbolHolder.Text = System.Convert.ToString("Sin" + "(" + (textBox1.Text) + ")");
            ilog = Math.Sin(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            symbolHolder.Text = System.Convert.ToString("Cosh" + "(" + (textBox1.Text) + ")");
            ilog = Math.Cosh(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            symbolHolder.Text = System.Convert.ToString("cos" + "(" + (textBox1.Text) + ")");
            ilog = Math.Cos(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            symbolHolder.Text = System.Convert.ToString("Tanh" + "(" + (textBox1.Text) + ")");
            ilog = Math.Tanh(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            symbolHolder.Text = System.Convert.ToString("Tan" + "(" + (textBox1.Text) + ")");
            ilog = Math.Tan(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("."))
            {
                MessageBox.Show("Syntax error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int a = int.Parse(textBox1.Text);
                textBox1.Text = System.Convert.ToString(a, 2);
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 10)
            {
                MessageBox.Show("The Lenght Of The Numbers Should Not Be Greater Than 10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBox1.Text.Contains("."))
                {
                    MessageBox.Show("Syntax error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int a = int.Parse(textBox1.Text);
                    textBox1.Text = System.Convert.ToString(a, 16);
                }
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(1.0/  Convert.ToDouble(textBox1.Text));
            textBox1.Text = System.Convert.ToString(a);
        }

        private void CeToFaren_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'C';
        }

        private void FarenToCe_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'F';
        }

        private void rbKelvin_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'K';
        }

        private void button41_Click(object sender, EventArgs e)
        {
            switch (iOperation)
            {
                case 'C':
                    iCelsius = float.Parse(txtConvert.Text);
                    txtBoxTempAns.Text = ((((9 * iCelsius) / 5) + 32).ToString());
                    break;

                case 'F':
                    iFahrenheit = float.Parse(txtConvert.Text);
                    txtBoxTempAns.Text = ((((iFahrenheit - 32) * 5) / 9).ToString());
                    break;

                case 'K':
                    iKelvin = float.Parse(txtConvert.Text);
                    txtBoxTempAns.Text = (((((9 * iKelvin) / 5) + 32) + 273.15).ToString());
                    break;
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            txtConvert.Clear();
            txtBoxTempAns.Clear();
            CeToFaren.Checked = false;
            FarenToCe.Checked = false;
            rbKelvin.Checked = false;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 10)
            {
                MessageBox.Show("The Lenght Of The Numbers Should Not Be Greater Than 10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBox1.Text.Contains("."))
                {
                    MessageBox.Show("Syntax error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int a = int.Parse(textBox1.Text);
                    textBox1.Text = System.Convert.ToString(a, 8);
                }
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Syntax error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Double a;
                a = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(100);
                textBox1.Text = System.Convert.ToString(a);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.NumPad0)
            {
                button17.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.NumPad1)
            {
                button13.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.NumPad2)
            {
                button14.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.NumPad3)
            {
                button15.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.NumPad4)
            {
                button9.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.NumPad5)
            {
                button10.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.NumPad6)
            {
                button11.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.NumPad7)
            {
                button5.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.NumPad8)
            {
                button6.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.NumPad9)
            {
                button7.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.Back)
            {
                button1.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.Enter)
            {
                button19.PerformClick();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (off == false)
            {
                textBox1.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button29.Enabled = false;
                button34.Enabled = false;
                button38.Enabled = false;
                button40.Enabled = false;
                button27.Enabled = false;
                button32.Enabled = false;
                button36.Enabled = false;
                button39.Enabled = false;
                button25.Enabled = false;
                button30.Enabled = false;
                button33.Enabled = false;
                button37.Enabled = false;
                button23.Enabled = false;
                button26.Enabled = false;
                button28.Enabled = false;
                button35.Enabled = false;
                btnpi.Enabled = false;
                button22.Enabled = false;
                button24.Enabled = false;
                button31.Enabled = false;
                button4.Text = "ON";
                off = true;
                textBox1.Text = "";
            }
            else
            {
                textBox1.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button29.Enabled = true;
                button34.Enabled = true;
                button38.Enabled = true;
                button40.Enabled = true;
                button27.Enabled = true;
                button32.Enabled = true;
                button36.Enabled = true;
                button39.Enabled = true;
                button25.Enabled = true;
                button30.Enabled = true;
                button33.Enabled = true;
                button37.Enabled = true;
                button23.Enabled = true;
                button26.Enabled = true;
                button28.Enabled = true;
                button35.Enabled = true;
                btnpi.Enabled = true;
                button22.Enabled = true;
                button24.Enabled = true;
                button31.Enabled = true;
                button4.Text = "Off";
                off = false;
                textBox1.Text = "0";
                symbolHolder.Text = "";
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            this.Width = 338;
            textBox1.Width = 299;
            panel1.Hide();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (dataShow == false)
            {
                this.Width = 684;
                textBox1.Width = 642;
                panel1.Hide();
                dataShow = true;
            }
            else
            {
                panel2.Hide();
                this.Width = 684;
                textBox1.Width = 642;
                panel1.Hide();
            }
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            if (sidePanel == false)
            {
                panel1.Show();
                sidePanel = true;
            }
            else
            {
                panel1.Hide();
                sidePanel = false;
            }
            
        }

        private void button45_Click(object sender, EventArgs e)
        {
            this.Width = 1060;
            textBox1.Width = 642;
            panel1.Hide();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (dataShow == false)
            {
                panel2.Show();
                button44.PerformClick();
                textBox1.Width = 299;
                dataShow = true;

            }
            else
            {
                panel2.Hide();
                dataShow = false;
            }
        }

        private void data_Button_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox2.Text.Contains("."))
                    textBox2.Text = textBox2.Text + num.Text;
            }
            else
            {
                textBox2.Text = textBox2.Text + num.Text;
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem == "Gigabytes")
            {
                if (comboBox2.SelectedItem == "Megabytes")
                {
                    if (textBox2.Text.Length == 0)
                    {
                        MessageBox.Show("Text Was Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Int32 a = Convert.ToInt32(textBox2.Text);
                        Int32 b = a * 1000;
                        textBox3.Text = b.ToString();
                    }
                }
            }
            else if (comboBox1.SelectedItem == "Megabytes")
            {
                if (comboBox2.SelectedItem == "Gigabytes")
                {
                    if (textBox2.Text.Length == 0)
                    {
                        MessageBox.Show("Text Was Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Int32 c = Convert.ToInt32(textBox2.Text);
                        Int32 d = c / 1000;
                        textBox3.Text = d.ToString();
                    }
                }
            }
            else if (comboBox1.SelectedItem == "Kilobytes")
            {
                if (comboBox2.SelectedItem == "Megabytes")
                {
                    if (textBox2.Text.Length == 0)
                    {
                        MessageBox.Show("Text Was Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Int32 g = Convert.ToInt32(textBox2.Text);
                        Int32 f = g / 1000;
                        textBox3.Text = f.ToString();
                    }
                }
            }
            else if (comboBox1.SelectedItem == "Terabyte")
            {
                if (comboBox2.SelectedItem == "Gigabytes")
                {
                    if (textBox2.Text.Length == 0)
                    {
                        MessageBox.Show("Text Was Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Int32 h = Convert.ToInt32(textBox2.Text);
                        Int32 i = h * 1000;
                        textBox3.Text = i.ToString();
                    }
                }
            }
            if (comboBox1.SelectedItem == "Kilobytes")
            {
                if (comboBox2.SelectedItem == "Gigabytes")
                {
                    if (textBox2.Text.Length == 0)
                    {
                        MessageBox.Show("Text Was Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Int32 j = Convert.ToInt32(textBox2.Text);
                        Int32 k = j * 1000 * 1000;
                        textBox3.Text = k.ToString();
                    }
                }
            }
            if (comboBox1.SelectedItem == "Kilobytes")
            {
                if (comboBox2.SelectedItem == "Terabyte")
                {
                    if (textBox2.Text.Length == 0)
                    {
                        MessageBox.Show("Text Was Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Int32 l = Convert.ToInt32(textBox2.Text);
                        Int32 m = l / 1000 / 1000;
                        textBox3.Text = m.ToString();
                    }
                }
            }
            if (comboBox1.SelectedItem == "Megabytes")
            {
                if (comboBox2.SelectedItem == "Kilobytes")
                {
                    if (textBox2.Text.Length == 0)
                    {
                        MessageBox.Show("Text Was Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Int32 o = Convert.ToInt32(textBox2.Text);
                        Int32 p = o / 1000;
                        textBox3.Text = p.ToString();
                    }
                }
            }
            if (comboBox1.SelectedItem == "Megabytes")
            {
                if (comboBox2.SelectedItem == "Megabytes")
                {
                    if (textBox2.Text.Length == 0)
                    {
                        MessageBox.Show("Text Was Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Int32 q = Convert.ToInt32(textBox2.Text);
                        Int32 r = q;
                        textBox3.Text = r.ToString();
                    }
                }
            }
            if (comboBox1.SelectedItem == "Megabytes")
            {
                if (comboBox2.SelectedItem == "Terabyte")
                {
                    if (textBox2.Text.Length == 0)
                    {
                        MessageBox.Show("Text Was Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Int32 s = Convert.ToInt32(textBox2.Text);
                        Int32 t = s / 1000 / 1000;
                        textBox3.Text = t.ToString();
                    }
                }
            }
            if (comboBox1.SelectedItem == "Gigabytes")
            {
                if (comboBox2.SelectedItem == "Gigabytes")
                {
                    if (textBox2.Text.Length == 0)
                    {
                        MessageBox.Show("Text Was Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Int32 u = Convert.ToInt32(textBox2.Text);
                        Int32 v = u;
                        textBox3.Text = v.ToString();
                    }
                }
            }
            if (comboBox1.SelectedItem == "Gigabytes")
            {
                if (comboBox2.SelectedItem == "Terabyte")
                {
                    if (textBox2.Text.Length == 0)
                    {
                        MessageBox.Show("Text Was Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Int32 w = Convert.ToInt32(textBox2.Text);
                        Int32 yz = w / 1000;
                        textBox3.Text = yz.ToString();
                    }
                }
            }
            if (comboBox1.SelectedItem == "Terabyte")
            {
                if (comboBox2.SelectedItem == "Kilobytes")
                {
                    if (textBox2.Text.Length == 0)
                    {
                        MessageBox.Show("Text Was Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Int32 ww = Convert.ToInt32(textBox2.Text);
                        Int32 tt = ww * 1000000000;
                        textBox3.Text = tt.ToString();
                    }
                }
            }
            if (comboBox1.SelectedItem == "Terabyte")
            {
                if (comboBox2.SelectedItem == "Megabytes")
                {
                    if (textBox2.Text.Length == 0)
                    {
                        MessageBox.Show("Text Was Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Int32 ss = Convert.ToInt32(textBox2.Text);
                        Int32 tt = ss * 1000000;
                        textBox3.Text = tt.ToString();
                    }
                }
            }
            if (comboBox1.SelectedItem == "Terabyte")
            {
                if (comboBox2.SelectedItem == "Gigabytes")
                {
                    if (textBox2.Text.Length == 0)
                    {
                        MessageBox.Show("Text Was Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Int32 uu = Convert.ToInt32(textBox2.Text);
                        Int32 vv = uu * 1000;
                        textBox3.Text = vv.ToString();
                    }
                }
            }
            if (comboBox1.SelectedItem == "Terabyte")
            {
                if (comboBox2.SelectedItem == "Terabyte")
                {
                    if (textBox2.Text.Length == 0)
                    {
                        MessageBox.Show("Text Was Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Int32 uuds = Convert.ToInt32(textBox2.Text);
                        Int32 vvds = uuds;
                        textBox3.Text = vvds.ToString();
                    }
                }
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void txtConvert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((!Char.IsNumber(e.KeyChar)) && (!Char.IsControl(e.KeyChar))){
                e.Handled = true;
            }
        }
        private void button39_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            symbolHolder.Text = System.Convert.ToString("Log" + "(" + (textBox1.Text) + ")");
            ilog = Math.Log(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0)
            {    
            MessageBox.Show("Syntax error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Double a;
                a = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(100);
                textBox1.Text = System.Convert.ToString(a);
            }
        }
    }
}
//button22.Hide();
//button24.Hide();
//button31.Hide();
//button23.Hide();
//button26.Hide();
//button28.Hide();
//button35.Hide();
//button25.Hide();
//button30.Hide();
//button33.Hide();
//button37.Hide();
//button27.Hide();
//button32.Hide();
//button36.Hide();
//button39.Hide();
//button29.Hide();
//button34.Hide();
//button38.Hide();
//button40.Hide();