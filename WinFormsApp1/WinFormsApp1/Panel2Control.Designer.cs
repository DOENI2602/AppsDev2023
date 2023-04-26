namespace WinFormsApp1
{
    partial class Panel2Control
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
            textbox1 = new TextBox();
            label3 = new Label();
            textbox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(128, 32);
            label1.TabIndex = 4;
            label1.Text = "Panel Two!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 96);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 5;
            label2.Text = "Input one:";
            label2.Click += label2_Click;
            // 
            // textbox1
            // 
            textbox1.Location = new Point(35, 132);
            textbox1.Name = "textbox1";
            textbox1.PlaceholderText = "Input one....";
            textbox1.Size = new Size(217, 23);
            textbox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 196);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 8;
            label3.Text = "Input two:";
            // 
            // textbox2
            // 
            textbox2.Location = new Point(35, 246);
            textbox2.Name = "textbox2";
            textbox2.PlaceholderText = "Input two....";
            textbox2.Size = new Size(217, 23);
            textbox2.TabIndex = 9;
            // 
            // Panel2Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            Controls.Add(textbox2);
            Controls.Add(label3);
            Controls.Add(textbox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Panel2Control";
            Size = new Size(503, 391);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textbox1;
        private Label label3;
        private TextBox textbox2;
    }
}
