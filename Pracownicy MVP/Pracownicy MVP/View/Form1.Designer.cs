
namespace Pracownicy_MVP.View
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_data = new System.Windows.Forms.TextBox();
            this.groupBox_dane = new System.Windows.Forms.GroupBox();
            this.textBox_errors = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.checkedListBox_contract = new System.Windows.Forms.CheckedListBox();
            this.label_contract = new System.Windows.Forms.Label();
            this.comboBox_job_title = new System.Windows.Forms.ComboBox();
            this.label_job_title = new System.Windows.Forms.Label();
            this.numericUpDown_salary = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.label_salary = new System.Windows.Forms.Label();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.label_date = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.groupBox_dane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salary)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_data
            // 
            this.textBox_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_data.Location = new System.Drawing.Point(393, 12);
            this.textBox_data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_data.Multiline = true;
            this.textBox_data.Name = "textBox_data";
            this.textBox_data.ReadOnly = true;
            this.textBox_data.Size = new System.Drawing.Size(776, 458);
            this.textBox_data.TabIndex = 4;
            this.textBox_data.TabStop = false;
            // 
            // groupBox_dane
            // 
            this.groupBox_dane.Controls.Add(this.textBox_errors);
            this.groupBox_dane.Controls.Add(this.button_add);
            this.groupBox_dane.Controls.Add(this.checkedListBox_contract);
            this.groupBox_dane.Controls.Add(this.label_contract);
            this.groupBox_dane.Controls.Add(this.comboBox_job_title);
            this.groupBox_dane.Controls.Add(this.label_job_title);
            this.groupBox_dane.Controls.Add(this.numericUpDown_salary);
            this.groupBox_dane.Controls.Add(this.dateTimePicker_date);
            this.groupBox_dane.Controls.Add(this.label_salary);
            this.groupBox_dane.Controls.Add(this.textBox_surname);
            this.groupBox_dane.Controls.Add(this.label_date);
            this.groupBox_dane.Controls.Add(this.textBox_name);
            this.groupBox_dane.Controls.Add(this.label_surname);
            this.groupBox_dane.Controls.Add(this.label_name);
            this.groupBox_dane.Location = new System.Drawing.Point(12, 11);
            this.groupBox_dane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_dane.Name = "groupBox_dane";
            this.groupBox_dane.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_dane.Size = new System.Drawing.Size(375, 458);
            this.groupBox_dane.TabIndex = 3;
            this.groupBox_dane.TabStop = false;
            this.groupBox_dane.Text = "Dane pracowników";
            // 
            // textBox_errors
            // 
            this.textBox_errors.Location = new System.Drawing.Point(5, 369);
            this.textBox_errors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_errors.MaxLength = 100;
            this.textBox_errors.Name = "textBox_errors";
            this.textBox_errors.ReadOnly = true;
            this.textBox_errors.ShortcutsEnabled = false;
            this.textBox_errors.Size = new System.Drawing.Size(353, 22);
            this.textBox_errors.TabIndex = 0;
            this.textBox_errors.TabStop = false;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(5, 406);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(353, 36);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "Dodaj";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // checkedListBox_contract
            // 
            this.checkedListBox_contract.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox_contract.CheckOnClick = true;
            this.checkedListBox_contract.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.checkedListBox_contract.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_contract.Items.AddRange(new object[] {
            "umowa na czas nieokreślony",
            "umowa na czas określony",
            "umowa zlecenie"});
            this.checkedListBox_contract.Location = new System.Drawing.Point(125, 286);
            this.checkedListBox_contract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox_contract.Name = "checkedListBox_contract";
            this.checkedListBox_contract.Size = new System.Drawing.Size(233, 80);
            this.checkedListBox_contract.TabIndex = 5;
            this.checkedListBox_contract.ThreeDCheckBoxes = true;
            this.checkedListBox_contract.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_contract_SelectedIndexChanged);
            // 
            // label_contract
            // 
            this.label_contract.AutoSize = true;
            this.label_contract.Location = new System.Drawing.Point(5, 286);
            this.label_contract.Name = "label_contract";
            this.label_contract.Size = new System.Drawing.Size(103, 17);
            this.label_contract.TabIndex = 0;
            this.label_contract.Text = "Rodzaj umowy:";
            // 
            // comboBox_job_title
            // 
            this.comboBox_job_title.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_job_title.FormattingEnabled = true;
            this.comboBox_job_title.Items.AddRange(new object[] {
            "Tester",
            "Projektant",
            "Inżynier",
            "Młodszy programista",
            "Starszy programista"});
            this.comboBox_job_title.Location = new System.Drawing.Point(125, 235);
            this.comboBox_job_title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_job_title.Name = "comboBox_job_title";
            this.comboBox_job_title.Size = new System.Drawing.Size(233, 24);
            this.comboBox_job_title.TabIndex = 4;
            // 
            // label_job_title
            // 
            this.label_job_title.AutoSize = true;
            this.label_job_title.Location = new System.Drawing.Point(5, 235);
            this.label_job_title.Name = "label_job_title";
            this.label_job_title.Size = new System.Drawing.Size(83, 17);
            this.label_job_title.TabIndex = 0;
            this.label_job_title.Text = "Stanowisko:";
            // 
            // numericUpDown_salary
            // 
            this.numericUpDown_salary.Location = new System.Drawing.Point(125, 185);
            this.numericUpDown_salary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_salary.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.numericUpDown_salary.Name = "numericUpDown_salary";
            this.numericUpDown_salary.Size = new System.Drawing.Size(129, 22);
            this.numericUpDown_salary.TabIndex = 3;
            this.numericUpDown_salary.Value = new decimal(new int[] {
            3490,
            0,
            0,
            0});
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_date.Location = new System.Drawing.Point(125, 135);
            this.dateTimePicker_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(233, 22);
            this.dateTimePicker_date.TabIndex = 2;
            // 
            // label_salary
            // 
            this.label_salary.AutoSize = true;
            this.label_salary.Location = new System.Drawing.Point(5, 185);
            this.label_salary.Name = "label_salary";
            this.label_salary.Size = new System.Drawing.Size(55, 17);
            this.label_salary.TabIndex = 0;
            this.label_salary.Text = "Pensja:";
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(125, 86);
            this.textBox_surname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_surname.MaxLength = 32;
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(233, 22);
            this.textBox_surname.TabIndex = 1;
            this.textBox_surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_surname_KeyPress);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(5, 135);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(109, 17);
            this.label_date.TabIndex = 0;
            this.label_date.Text = "Data urodzenia:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(125, 34);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_name.MaxLength = 32;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(233, 22);
            this.textBox_name.TabIndex = 0;
            this.textBox_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_name_KeyPress);
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(5, 85);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(71, 17);
            this.label_surname.TabIndex = 0;
            this.label_surname.Text = "Nazwisko:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(5, 34);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(37, 17);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Imię:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 481);
            this.Controls.Add(this.textBox_data);
            this.Controls.Add(this.groupBox_dane);
            this.MaximumSize = new System.Drawing.Size(1199, 528);
            this.MinimumSize = new System.Drawing.Size(1199, 528);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_dane.ResumeLayout(false);
            this.groupBox_dane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_data;
        private System.Windows.Forms.GroupBox groupBox_dane;
        private System.Windows.Forms.TextBox textBox_errors;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.CheckedListBox checkedListBox_contract;
        private System.Windows.Forms.Label label_contract;
        private System.Windows.Forms.ComboBox comboBox_job_title;
        private System.Windows.Forms.Label label_job_title;
        private System.Windows.Forms.NumericUpDown numericUpDown_salary;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.Label label_salary;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_name;
    }
}

