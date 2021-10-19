
namespace PulseOxim
{
    partial class Alerta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alerta));
            this.reciever = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mesaj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.tip_alerta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reciever
            // 
            this.reciever.FormattingEnabled = true;
            this.reciever.Location = new System.Drawing.Point(311, 72);
            this.reciever.Name = "reciever";
            this.reciever.Size = new System.Drawing.Size(261, 23);
            this.reciever.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(219, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-mail pacient:";
            // 
            // mesaj
            // 
            this.mesaj.Location = new System.Drawing.Point(311, 160);
            this.mesaj.Multiline = true;
            this.mesaj.Name = "mesaj";
            this.mesaj.Size = new System.Drawing.Size(261, 194);
            this.mesaj.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(219, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mesaj de alerta:";
            // 
            // send
            // 
            this.send.AutoSize = true;
            this.send.BackColor = System.Drawing.Color.Indigo;
            this.send.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.send.Location = new System.Drawing.Point(619, 386);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(97, 25);
            this.send.TabIndex = 4;
            this.send.Text = "Trimitere Alerta";
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // tip_alerta
            // 
            this.tip_alerta.FormattingEnabled = true;
            this.tip_alerta.Items.AddRange(new object[] {
            "Recomandare",
            "Pericol"});
            this.tip_alerta.Location = new System.Drawing.Point(311, 115);
            this.tip_alerta.Name = "tip_alerta";
            this.tip_alerta.Size = new System.Drawing.Size(261, 23);
            this.tip_alerta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(219, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tip de alerta:";
            // 
            // Alerta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tip_alerta);
            this.Controls.Add(this.send);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mesaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reciever);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alerta";
            this.Text = "Alerta";
            this.Load += new System.EventHandler(this.Alerta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox reciever;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mesaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.ComboBox tip_alerta;
        private System.Windows.Forms.Label label3;
    }
}