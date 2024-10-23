namespace cena_paliva_za_litr
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
            start_button = new Button();
            nafta = new RadioButton();
            benzin = new RadioButton();
            liters_input = new TextBox();
            price_input = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            output = new Label();
            warning_box = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // start_button
            // 
            start_button.Location = new Point(33, 307);
            start_button.Name = "start_button";
            start_button.Size = new Size(87, 41);
            start_button.TabIndex = 1;
            start_button.Text = "vypočet";
            start_button.UseVisualStyleBackColor = true;
            start_button.Click += button2_Click;
            // 
            // nafta
            // 
            nafta.AutoSize = true;
            nafta.Location = new Point(6, 22);
            nafta.Name = "nafta";
            nafta.Size = new Size(52, 19);
            nafta.TabIndex = 3;
            nafta.TabStop = true;
            nafta.Text = "nafta";
            nafta.UseVisualStyleBackColor = true;
            nafta.CheckedChanged += nafta_CheckedChanged;
            // 
            // benzin
            // 
            benzin.AutoSize = true;
            benzin.Location = new Point(6, 50);
            benzin.Name = "benzin";
            benzin.Size = new Size(60, 19);
            benzin.TabIndex = 4;
            benzin.TabStop = true;
            benzin.Text = "benzín";
            benzin.UseVisualStyleBackColor = true;
            benzin.CheckedChanged += benzin_CheckedChanged;
            // 
            // liters_input
            // 
            liters_input.Location = new Point(33, 178);
            liters_input.Name = "liters_input";
            liters_input.Size = new Size(159, 23);
            liters_input.TabIndex = 5;
            liters_input.TextChanged += liters_input_TextChanged;
            // 
            // price_input
            // 
            price_input.Location = new Point(33, 256);
            price_input.Name = "price_input";
            price_input.Size = new Size(159, 23);
            price_input.TabIndex = 6;
            price_input.TextChanged += price_input_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 238);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 7;
            label1.Text = "cena za litr";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 160);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 8;
            label2.Text = "počet litrů";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nafta);
            groupBox1.Controls.Add(benzin);
            groupBox1.Location = new Point(33, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 73);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "zvolte palivo";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // output
            // 
            output.AutoSize = true;
            output.BackColor = SystemColors.ActiveCaption;
            output.Location = new Point(33, 366);
            output.Name = "output";
            output.Padding = new Padding(12);
            output.Size = new Size(169, 39);
            output.TabIndex = 2;
            output.Text = "zadejte údaje pro výsledek";
            output.Click += label1_Click;
            // 
            // warning_box
            // 
            warning_box.AutoSize = true;
            warning_box.BackColor = Color.OrangeRed;
            warning_box.Location = new Point(33, 402);
            warning_box.Name = "warning_box";
            warning_box.Padding = new Padding(12);
            warning_box.Size = new Size(208, 39);
            warning_box.TabIndex = 10;
            warning_box.Text = "zadejte ve správnem tvaru prosím";
            warning_box.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 450);
            Controls.Add(warning_box);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(price_input);
            Controls.Add(liters_input);
            Controls.Add(output);
            Controls.Add(start_button);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button start_button;
        private RadioButton nafta;
        private RadioButton benzin;
        private TextBox liters_input;
        private TextBox price_input;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label output;
        private Label warning_box;
    }
}
