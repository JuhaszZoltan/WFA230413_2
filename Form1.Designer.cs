namespace WFA230413_2
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
            lblSzoveg = new Label();
            btnKoszonj = new Button();
            SuspendLayout();
            // 
            // lblSzoveg
            // 
            lblSzoveg.BackColor = Color.DarkSeaGreen;
            lblSzoveg.Font = new Font("Snap ITC", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSzoveg.Location = new Point(12, 9);
            lblSzoveg.Name = "lblSzoveg";
            lblSzoveg.Size = new Size(481, 135);
            lblSzoveg.TabIndex = 0;
            lblSzoveg.Text = "###";
            lblSzoveg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnKoszonj
            // 
            btnKoszonj.BackColor = Color.DeepSkyBlue;
            btnKoszonj.Location = new Point(12, 147);
            btnKoszonj.Name = "btnKoszonj";
            btnKoszonj.Size = new Size(481, 89);
            btnKoszonj.TabIndex = 1;
            btnKoszonj.Text = "Köszönj!";
            btnKoszonj.UseVisualStyleBackColor = false;
            btnKoszonj.Click += btnKoszonj_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 248);
            Controls.Add(btnKoszonj);
            Controls.Add(lblSzoveg);
            Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label lblSzoveg;
        private Button btnKoszonj;
    }
}