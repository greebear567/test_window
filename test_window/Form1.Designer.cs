
namespace test_window
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
            this.data = new System.Windows.Forms.TextBox();
            this.area_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(12, 12);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(206, 27);
            this.data.TabIndex = 0;
            // 
            // area_but
            // 
            this.area_but.Location = new System.Drawing.Point(224, 10);
            this.area_but.Name = "area_but";
            this.area_but.Size = new System.Drawing.Size(142, 29);
            this.area_but.TabIndex = 1;
            this.area_but.Text = "Найти площадь";
            this.area_but.UseVisualStyleBackColor = true;
            this.area_but.Click += new System.EventHandler(this.area_but_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.area_but);
            this.Controls.Add(this.data);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox data;
        private System.Windows.Forms.Button area_but;
    }
}

