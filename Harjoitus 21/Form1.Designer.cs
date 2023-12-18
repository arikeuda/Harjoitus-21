namespace Harjoitus_21
{
    partial class harjoitus1Form
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
            otsikkoLB = new Label();
            vaihdaBT = new Button();
            SuspendLayout();
            // 
            // otsikkoLB
            // 
            otsikkoLB.AutoSize = true;
            otsikkoLB.Location = new Point(12, 9);
            otsikkoLB.Name = "otsikkoLB";
            otsikkoLB.Size = new Size(47, 15);
            otsikkoLB.TabIndex = 0;
            otsikkoLB.Text = "Otsikko";
            // 
            // vaihdaBT
            // 
            vaihdaBT.Location = new Point(12, 27);
            vaihdaBT.Name = "vaihdaBT";
            vaihdaBT.Size = new Size(75, 48);
            vaihdaBT.TabIndex = 1;
            vaihdaBT.Text = "Vaihda teksti";
            vaihdaBT.UseVisualStyleBackColor = true;
            vaihdaBT.Click += vaihdaBT_Click;
            // 
            // harjoitus1Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 212);
            Controls.Add(vaihdaBT);
            Controls.Add(otsikkoLB);
            Name = "harjoitus1Form";
            Text = "Harjoitus 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label otsikkoLB;
        private Button vaihdaBT;
    }
}
