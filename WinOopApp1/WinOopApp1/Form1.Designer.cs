namespace WinOopApp1
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
            btnTest = new Button();
            textOutput = new TextBox();
            SuspendLayout();
            // 
            // btnTest
            // 
            btnTest.Location = new Point(310, 564);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(92, 51);
            btnTest.TabIndex = 0;
            btnTest.Text = "Test";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // textOutput
            // 
            textOutput.BorderStyle = BorderStyle.FixedSingle;
            textOutput.Location = new Point(23, 14);
            textOutput.Multiline = true;
            textOutput.Name = "textOutput";
            textOutput.ScrollBars = ScrollBars.Vertical;
            textOutput.Size = new Size(720, 528);
            textOutput.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 627);
            Controls.Add(textOutput);
            Controls.Add(btnTest);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTest;
        private TextBox textOutput;
    }
}