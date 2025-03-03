
namespace tpmodul3_103022300100
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
            btnKirim = new Button();
            textBox = new TextBox();
            output = new Label();
            SuspendLayout();
            // 
            // btnKirim
            // 
            btnKirim.Location = new Point(700, 55);
            btnKirim.Name = "btnKirim";
            btnKirim.Size = new Size(150, 46);
            btnKirim.TabIndex = 0;
            btnKirim.Text = "Kirim";
            btnKirim.UseVisualStyleBackColor = true;
            btnKirim.Click += btnKirim_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(55, 62);
            textBox.Name = "textBox";
            textBox.Size = new Size(585, 39);
            textBox.TabIndex = 1;
            // 
            // output
            // 
            output.AutoSize = true;
            output.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            output.Location = new Point(313, 190);
            output.Name = "output";
            output.Padding = new Padding(6);
            output.Size = new Size(229, 62);
            output.TabIndex = 2;
            output.Text = "Input Nama";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 338);
            Controls.Add(output);
            Controls.Add(textBox);
            Controls.Add(btnKirim);
            Name = "Form1";
            Text = "Form Nama";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKirim;
        private TextBox textBox;
        private Label output;
    }
}
