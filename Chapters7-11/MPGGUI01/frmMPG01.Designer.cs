namespace MPGGUI01
{
    partial class frmMPG01
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMilesDriven = new System.Windows.Forms.Label();
            this.lblGallonsUsed = new System.Windows.Forms.Label();
            this.lblMilesPerGallon = new System.Windows.Forms.Label();
            this.txtMilesDriven = new System.Windows.Forms.TextBox();
            this.txtGallonsUsed = new System.Windows.Forms.TextBox();
            this.txtMilesPerGallon = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMilesDriven
            // 
            this.lblMilesDriven.BackColor = System.Drawing.Color.Fuchsia;
            this.lblMilesDriven.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilesDriven.ForeColor = System.Drawing.Color.White;
            this.lblMilesDriven.Location = new System.Drawing.Point(122, 36);
            this.lblMilesDriven.Name = "lblMilesDriven";
            this.lblMilesDriven.Size = new System.Drawing.Size(277, 44);
            this.lblMilesDriven.TabIndex = 6;
            this.lblMilesDriven.Text = "Miles Driven:";
            this.lblMilesDriven.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGallonsUsed
            // 
            this.lblGallonsUsed.BackColor = System.Drawing.Color.Fuchsia;
            this.lblGallonsUsed.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGallonsUsed.ForeColor = System.Drawing.Color.White;
            this.lblGallonsUsed.Location = new System.Drawing.Point(122, 149);
            this.lblGallonsUsed.Name = "lblGallonsUsed";
            this.lblGallonsUsed.Size = new System.Drawing.Size(277, 41);
            this.lblGallonsUsed.TabIndex = 7;
            this.lblGallonsUsed.Text = "Gallons Used:";
            this.lblGallonsUsed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMilesPerGallon
            // 
            this.lblMilesPerGallon.BackColor = System.Drawing.Color.Fuchsia;
            this.lblMilesPerGallon.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilesPerGallon.ForeColor = System.Drawing.Color.White;
            this.lblMilesPerGallon.Location = new System.Drawing.Point(122, 250);
            this.lblMilesPerGallon.Name = "lblMilesPerGallon";
            this.lblMilesPerGallon.Size = new System.Drawing.Size(277, 44);
            this.lblMilesPerGallon.TabIndex = 8;
            this.lblMilesPerGallon.Text = "Miles Per Gallon:";
            this.lblMilesPerGallon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMilesDriven
            // 
            this.txtMilesDriven.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMilesDriven.Location = new System.Drawing.Point(427, 36);
            this.txtMilesDriven.Name = "txtMilesDriven";
            this.txtMilesDriven.Size = new System.Drawing.Size(266, 44);
            this.txtMilesDriven.TabIndex = 0;
            this.txtMilesDriven.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGallonsUsed
            // 
            this.txtGallonsUsed.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGallonsUsed.Location = new System.Drawing.Point(427, 146);
            this.txtGallonsUsed.Name = "txtGallonsUsed";
            this.txtGallonsUsed.Size = new System.Drawing.Size(266, 44);
            this.txtGallonsUsed.TabIndex = 1;
            this.txtGallonsUsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMilesPerGallon
            // 
            this.txtMilesPerGallon.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMilesPerGallon.Location = new System.Drawing.Point(427, 250);
            this.txtMilesPerGallon.Name = "txtMilesPerGallon";
            this.txtMilesPerGallon.ReadOnly = true;
            this.txtMilesPerGallon.Size = new System.Drawing.Size(266, 44);
            this.txtMilesPerGallon.TabIndex = 5;
            this.txtMilesPerGallon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(66, 340);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(202, 61);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(302, 340);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(202, 61);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(541, 340);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(202, 61);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMPG01
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtMilesPerGallon);
            this.Controls.Add(this.txtGallonsUsed);
            this.Controls.Add(this.txtMilesDriven);
            this.Controls.Add(this.lblMilesPerGallon);
            this.Controls.Add(this.lblGallonsUsed);
            this.Controls.Add(this.lblMilesDriven);
            this.Name = "frmMPG01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# Miles Per Gallon Program - GUI 01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMilesDriven;
        private System.Windows.Forms.Label lblGallonsUsed;
        private System.Windows.Forms.Label lblMilesPerGallon;
        private System.Windows.Forms.TextBox txtMilesDriven;
        private System.Windows.Forms.TextBox txtGallonsUsed;
        private System.Windows.Forms.TextBox txtMilesPerGallon;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

