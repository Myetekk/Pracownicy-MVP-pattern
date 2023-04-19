using Newtonsoft.Json;
using Pracownicy_MVP.Model;
using Pracownicy_MVP.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pracownicy_MVP.View
{
    public partial class Form1 : Form
    {
        public bool was_error = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Read?.Invoke();
        }





        #region Public interface of view

        public event Action<string> Add_info;
        public event Action Serialize;
        public event Action Read;
        public string DisplayText
        {
            set
            {
                textBox_data.Text = value;
            }
            get
            {
                return textBox_data.Text;
            }
        }
        //public void ShowMessage(string message) => MessageBox.Show(message);
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
            was_error = true;
        }

        #endregion





        private void button_add_Click(object sender, EventArgs e)
        {
            Add_info?.Invoke(textBox_name.Text);

            Add_info?.Invoke(textBox_surname.Text);

            string date = dateTimePicker_date.Value.ToString();
            date = date.Substring(0, 10);
            Add_info?.Invoke(date);

            string salary = numericUpDown_salary.Value.ToString();
            Add_info?.Invoke(salary);

            Add_info?.Invoke(comboBox_job_title.Text);

            int index = checkedListBox_contract.SelectedIndex;
            int count = checkedListBox_contract.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (i != index) checkedListBox_contract.SetItemChecked(i, false);
            }
            Add_info?.Invoke(index.ToString());



            Serialize?.Invoke();
            if (was_error == false) clear_view();
            was_error = false;
        }



        private void clear_view()
        {
            textBox_name.Text = "";
            textBox_surname.Text = "";
            dateTimePicker_date.Value = DateTime.Today;
            numericUpDown_salary.Value = 3490;
            comboBox_job_title.Text = null;
            for (int i = 0; i < 3; i++)
                checkedListBox_contract.SetItemChecked(i, false);
        }





        private void checkedListBox_contract_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox_contract.SelectedIndex;
            int count = checkedListBox_contract.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (i != index) checkedListBox_contract.SetItemChecked(i, false);
            }
        }



        private void textBox_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBox_surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }



    }
}
