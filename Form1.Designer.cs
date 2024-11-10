namespace WinFS_DZ_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            groupBox1 = new GroupBox();
            radioButtonBus = new RadioButton();
            radioButtonTrain = new RadioButton();
            radioButtonPlane = new RadioButton();
            checkBoxInsurance = new CheckBox();
            checkBoxExcursions = new CheckBox();
            checkBoxExtraLuggage = new CheckBox();
            comboBoxDestination = new ComboBox();
            buttonPlanTrip = new Button();
            textBoxSummary = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(82, 67);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 23);
            dateTimePickerStart.TabIndex = 0;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(82, 108);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 23);
            dateTimePickerEnd.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonBus);
            groupBox1.Controls.Add(radioButtonTrain);
            groupBox1.Controls.Add(radioButtonPlane);
            groupBox1.Location = new Point(349, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radioButtonBus
            // 
            radioButtonBus.AutoSize = true;
            radioButtonBus.Location = new Point(6, 70);
            radioButtonBus.Name = "radioButtonBus";
            radioButtonBus.Size = new Size(70, 19);
            radioButtonBus.TabIndex = 2;
            radioButtonBus.TabStop = true;
            radioButtonBus.Text = "Автобус";
            radioButtonBus.UseVisualStyleBackColor = true;
            // 
            // radioButtonTrain
            // 
            radioButtonTrain.AutoSize = true;
            radioButtonTrain.Location = new Point(6, 45);
            radioButtonTrain.Name = "radioButtonTrain";
            radioButtonTrain.Size = new Size(57, 19);
            radioButtonTrain.TabIndex = 1;
            radioButtonTrain.TabStop = true;
            radioButtonTrain.Text = "Потяг";
            radioButtonTrain.UseVisualStyleBackColor = true;
            // 
            // radioButtonPlane
            // 
            radioButtonPlane.AutoSize = true;
            radioButtonPlane.Location = new Point(6, 22);
            radioButtonPlane.Name = "radioButtonPlane";
            radioButtonPlane.Size = new Size(53, 19);
            radioButtonPlane.TabIndex = 0;
            radioButtonPlane.TabStop = true;
            radioButtonPlane.Text = "Літак";
            radioButtonPlane.UseVisualStyleBackColor = true;
            // 
            // checkBoxInsurance
            // 
            checkBoxInsurance.AutoSize = true;
            checkBoxInsurance.Location = new Point(349, 193);
            checkBoxInsurance.Name = "checkBoxInsurance";
            checkBoxInsurance.Size = new Size(83, 19);
            checkBoxInsurance.TabIndex = 3;
            checkBoxInsurance.Text = "Страховка";
            checkBoxInsurance.UseVisualStyleBackColor = true;
            // 
            // checkBoxExcursions
            // 
            checkBoxExcursions.AutoSize = true;
            checkBoxExcursions.Location = new Point(349, 218);
            checkBoxExcursions.Name = "checkBoxExcursions";
            checkBoxExcursions.Size = new Size(75, 19);
            checkBoxExcursions.TabIndex = 4;
            checkBoxExcursions.Text = "Екскурсії";
            checkBoxExcursions.UseVisualStyleBackColor = true;
            // 
            // checkBoxExtraLuggage
            // 
            checkBoxExtraLuggage.AutoSize = true;
            checkBoxExtraLuggage.Location = new Point(349, 243);
            checkBoxExtraLuggage.Name = "checkBoxExtraLuggage";
            checkBoxExtraLuggage.Size = new Size(127, 19);
            checkBoxExtraLuggage.TabIndex = 5;
            checkBoxExtraLuggage.Text = "Додатковий багаж";
            checkBoxExtraLuggage.UseVisualStyleBackColor = true;
            // 
            // comboBoxDestination
            // 
            comboBoxDestination.FormattingEnabled = true;
            comboBoxDestination.Items.AddRange(new object[] { "Париж", "Лондон", "Нью-Йорк" });
            comboBoxDestination.Location = new Point(82, 173);
            comboBoxDestination.Name = "comboBoxDestination";
            comboBoxDestination.Size = new Size(121, 23);
            comboBoxDestination.TabIndex = 6;
            // 
            // buttonPlanTrip
            // 
            buttonPlanTrip.Location = new Point(82, 218);
            buttonPlanTrip.Name = "buttonPlanTrip";
            buttonPlanTrip.Size = new Size(165, 23);
            buttonPlanTrip.TabIndex = 7;
            buttonPlanTrip.Text = "Планувати поїздку";
            buttonPlanTrip.UseVisualStyleBackColor = true;
            buttonPlanTrip.Click += buttonPlanTrip_Click;
            // 
            // textBoxSummary
            // 
            textBoxSummary.Location = new Point(12, 301);
            textBoxSummary.Name = "textBoxSummary";
            textBoxSummary.ReadOnly = true;
            textBoxSummary.Size = new Size(776, 23);
            textBoxSummary.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxSummary);
            Controls.Add(buttonPlanTrip);
            Controls.Add(comboBoxDestination);
            Controls.Add(checkBoxExtraLuggage);
            Controls.Add(checkBoxExcursions);
            Controls.Add(checkBoxInsurance);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private GroupBox groupBox1;
        private RadioButton radioButtonBus;
        private RadioButton radioButtonTrain;
        private RadioButton radioButtonPlane;
        private CheckBox checkBoxInsurance;
        private CheckBox checkBoxExcursions;
        private CheckBox checkBoxExtraLuggage;
        private ComboBox comboBoxDestination;
        private Button buttonPlanTrip;
        private TextBox textBoxSummary;
    }
}
