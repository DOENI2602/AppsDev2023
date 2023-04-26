namespace WinFormsApp1
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
            panel1 = new Panel();
            paneButton1 = new Button();
            panelButton2 = new Button();
            panel2 = new Panel();
            label3 = new Label();
            inputOne = new Label();
            Inputtwo_textBox = new TextBox();
            Input1_textBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2Control1 = new Panel2Control();
            panel1Control1 = new Panel1Control();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(paneButton1);
            panel1.Controls.Add(panelButton2);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 448);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // paneButton1
            // 
            paneButton1.Location = new Point(60, 150);
            paneButton1.Name = "paneButton1";
            paneButton1.Size = new Size(92, 47);
            paneButton1.TabIndex = 0;
            paneButton1.Text = "Panel 1";
            paneButton1.UseVisualStyleBackColor = true;
            paneButton1.Click += button1_Click;
            // 
            // panelButton2
            // 
            panelButton2.Location = new Point(60, 248);
            panelButton2.Name = "panelButton2";
            panelButton2.Size = new Size(92, 46);
            panelButton2.TabIndex = 1;
            panelButton2.Text = "Panel 2";
            panelButton2.UseVisualStyleBackColor = true;
            panelButton2.Click += panelButton2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(inputOne);
            panel2.Controls.Add(Inputtwo_textBox);
            panel2.Controls.Add(Input1_textBox);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(604, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 448);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 230);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 7;
            label3.Text = "Input 2:";
            // 
            // inputOne
            // 
            inputOne.AutoSize = true;
            inputOne.Location = new Point(13, 122);
            inputOne.Name = "inputOne";
            inputOne.Size = new Size(47, 15);
            inputOne.TabIndex = 6;
            inputOne.Text = "Input 1:";
            // 
            // Inputtwo_textBox
            // 
            Inputtwo_textBox.Location = new Point(13, 248);
            Inputtwo_textBox.Name = "Inputtwo_textBox";
            Inputtwo_textBox.Size = new Size(150, 23);
            Inputtwo_textBox.TabIndex = 5;
            // 
            // Input1_textBox
            // 
            Input1_textBox.Location = new Point(13, 140);
            Input1_textBox.Name = "Input1_textBox";
            Input1_textBox.Size = new Size(150, 23);
            Input1_textBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 40);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 3;
            label2.Text = "Data:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(220, 13);
            label1.Name = "label1";
            label1.Size = new Size(338, 32);
            label1.TabIndex = 2;
            label1.Text = "User Control Panel Application";
            // 
            // panel2Control1
            // 
            panel2Control1.BackColor = Color.LightSteelBlue;
            panel2Control1.Location = new Point(207, 54);
            panel2Control1.Name = "panel2Control1";
            panel2Control1.Size = new Size(395, 400);
            panel2Control1.TabIndex = 3;
            // 
            // panel1Control1
            // 
            panel1Control1.BackColor = Color.LightSteelBlue;
            panel1Control1.Location = new Point(207, 54);
            panel1Control1.Name = "panel1Control1";
            panel1Control1.Size = new Size(395, 417);
            panel1Control1.TabIndex = 4;
            panel1Control1.Load += panel1Control1_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1Control1);
            Controls.Add(panel2Control1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button panelButton2;
        private Button paneButton1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label inputOne;
        private TextBox Inputtwo_textBox;
        private TextBox Input1_textBox;
        private Panel1Control panel1Control1;
        private Panel2Control panel2Control1;
    }
}