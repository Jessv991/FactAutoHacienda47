using System.Drawing;
using System.Windows.Forms;

namespace FactAutoHacienda47
{
    partial class TicketBai
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

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.txtTienda = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtReenvio = new System.Windows.Forms.TextBox();
            this.txtJson = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtQueue = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tipo F FA T TA D S";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label2.Location = new System.Drawing.Point(120, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Codigo de Factura";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label3.Location = new System.Drawing.Point(218, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Codigo de Tienda";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label4.Location = new System.Drawing.Point(315, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Año";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label5.Location = new System.Drawing.Point(413, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Reenviar";
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.SystemColors.Window;
            this.txtTipo.Location = new System.Drawing.Point(21, 46);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(93, 20);
            this.txtTipo.TabIndex = 16;
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(120, 46);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(93, 20);
            this.txtFactura.TabIndex = 17;
            // 
            // txtTienda
            // 
            this.txtTienda.Location = new System.Drawing.Point(218, 46);
            this.txtTienda.Name = "txtTienda";
            this.txtTienda.Size = new System.Drawing.Size(93, 20);
            this.txtTienda.TabIndex = 18;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(315, 46);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(93, 20);
            this.txtYear.TabIndex = 19;
            // 
            // txtReenvio
            // 
            this.txtReenvio.Location = new System.Drawing.Point(413, 46);
            this.txtReenvio.Name = "txtReenvio";
            this.txtReenvio.Size = new System.Drawing.Size(93, 20);
            this.txtReenvio.TabIndex = 20;
            // 
            // txtJson
            // 
            this.txtJson.Location = new System.Drawing.Point(21, 82);
            this.txtJson.Multiline = true;
            this.txtJson.Name = "txtJson";
            this.txtJson.Size = new System.Drawing.Size(541, 107);
            this.txtJson.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(566, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 107);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // txtQueue
            // 
            this.txtQueue.Location = new System.Drawing.Point(512, 46);
            this.txtQueue.Name = "txtQueue";
            this.txtQueue.Size = new System.Drawing.Size(93, 20);
            this.txtQueue.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(512, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(93, 13);
            this.textBox2.TabIndex = 23;
            this.textBox2.Text = "Queue";
            // 
            // TicketBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 228);
            this.Controls.Add(this.txtQueue);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtJson);
            this.Controls.Add(this.txtReenvio);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtTienda);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TicketBai";
            this.Text = "TicketBai";
            this.Load += new System.EventHandler(this.TicketBai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private TextBox label1;
        private TextBox label2;
        private TextBox label3;
        private TextBox label4;
        private TextBox label5;
        private TextBox txtTipo;
        private TextBox txtFactura;
        private TextBox txtTienda;
        private TextBox txtYear;
        private TextBox txtReenvio;
        private TextBox txtJson;
        private PictureBox pictureBox1;
        private TextBox txtQueue;
        private TextBox textBox2;
    }
}