namespace REVISAO2
{
    partial class Divisão
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
            this.tx_num1 = new System.Windows.Forms.TextBox();
            this.tx_num2 = new System.Windows.Forms.TextBox();
            this.bt_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_num1
            // 
            this.tx_num1.Location = new System.Drawing.Point(12, 58);
            this.tx_num1.Name = "tx_num1";
            this.tx_num1.Size = new System.Drawing.Size(100, 20);
            this.tx_num1.TabIndex = 0;
            // 
            // tx_num2
            // 
            this.tx_num2.Location = new System.Drawing.Point(12, 84);
            this.tx_num2.Name = "tx_num2";
            this.tx_num2.Size = new System.Drawing.Size(100, 20);
            this.tx_num2.TabIndex = 1;
            // 
            // bt_calcular
            // 
            this.bt_calcular.Location = new System.Drawing.Point(12, 138);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(158, 40);
            this.bt_calcular.TabIndex = 2;
            this.bt_calcular.Text = "Calcular";
            this.bt_calcular.UseVisualStyleBackColor = true;
            this.bt_calcular.Click += new System.EventHandler(this.bt_calcular_Click);
            // 
            // Divisão
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 201);
            this.Controls.Add(this.bt_calcular);
            this.Controls.Add(this.tx_num2);
            this.Controls.Add(this.tx_num1);
            this.Name = "Divisão";
            this.Text = "Divisão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_num1;
        private System.Windows.Forms.TextBox tx_num2;
        private System.Windows.Forms.Button bt_calcular;
    }
}