namespace WinFormsApp1
{
    partial class Panel1Control
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Inputone_textbox = new TextBox();
            InputTwo_textbox = new TextBox();
            Submit_Button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(130, 32);
            label1.TabIndex = 3;
            label1.Text = "Panel One!";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 76);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "Input one:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 154);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 5;
            label3.Text = "Input two:";
            // 
            // Inputone_textbox
            // 
            Inputone_textbox.Location = new Point(45, 110);
            Inputone_textbox.Name = "Inputone_textbox";
            Inputone_textbox.PlaceholderText = "Input one....";
            Inputone_textbox.Size = new Size(217, 23);
            Inputone_textbox.TabIndex = 6;
            // 
            // InputTwo_textbox
            // 
            InputTwo_textbox.Location = new Point(45, 192);
            InputTwo_textbox.Name = "InputTwo_textbox";
            InputTwo_textbox.PlaceholderText = "Input two....";
            InputTwo_textbox.Size = new Size(217, 23);
            InputTwo_textbox.TabIndex = 7;
            // 
            // Submit_Button
            // 
            Submit_Button.BackColor = Color.White;
            Submit_Button.Location = new Point(45, 267);
            Submit_Button.Name = "Submit_Button";
            Submit_Button.Size = new Size(103, 42);
            Submit_Button.TabIndex = 8;
            Submit_Button.Text = "Submit";
            Submit_Button.UseVisualStyleBackColor = false;
            Submit_Button.Click += Submit_Button_Click;
            // 
            // Panel1Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            Controls.Add(Submit_Button);
            Controls.Add(InputTwo_textbox);
            Controls.Add(Inputone_textbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Panel1Control";
            Size = new Size(639, 423);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Inputone_textbox;
        private TextBox InputTwo_textbox;
        private Button Submit_Button;
    }
}
