namespace PruebaJr.Views
{
    partial class AllData
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
            this.dgvCarro = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCarro
            // 
            this.dgvCarro.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvCarro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarro.Location = new System.Drawing.Point(12, 65);
            this.dgvCarro.MultiSelect = false;
            this.dgvCarro.Name = "dgvCarro";
            this.dgvCarro.ReadOnly = true;
            this.dgvCarro.RowHeadersWidth = 51;
            this.dgvCarro.RowTemplate.Height = 24;
            this.dgvCarro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarro.Size = new System.Drawing.Size(964, 373);
            this.dgvCarro.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(78, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(213, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Nuevo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AllData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(988, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvCarro);
            this.Name = "AllData";
            this.Text = "AllData";
            this.Load += new System.EventHandler(this.AllData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}