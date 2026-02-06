using System.Drawing;
using System.Windows.Forms;

namespace FactAutoHacienda47
{
    partial class VeriFactu
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
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtReenvio = new System.Windows.Forms.TextBox();
            this.txtTienda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtJson = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtQueue = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.SystemColors.Window;
            this.txtTipo.Location = new System.Drawing.Point(18, 39);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(93, 20);
            this.txtTipo.TabIndex = 5;
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(116, 39);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(93, 20);
            this.txtFactura.TabIndex = 2;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(311, 39);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(93, 20);
            this.txtYear.TabIndex = 3;
            // 
            // txtReenvio
            // 
            this.txtReenvio.Location = new System.Drawing.Point(409, 39);
            this.txtReenvio.Name = "txtReenvio";
            this.txtReenvio.Size = new System.Drawing.Size(93, 20);
            this.txtReenvio.TabIndex = 4;
            // 
            // txtTienda
            // 
            this.txtTienda.Location = new System.Drawing.Point(213, 39);
            this.txtTienda.Name = "txtTienda";
            this.txtTienda.Size = new System.Drawing.Size(93, 20);
            this.txtTienda.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label5.Location = new System.Drawing.Point(409, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Reenviar";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label4.Location = new System.Drawing.Point(311, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Año";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label3.Location = new System.Drawing.Point(213, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Codigo de Tienda";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label2.Location = new System.Drawing.Point(116, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Codigo de Factura";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tipo F FA T TA D S";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(18, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1, 20);
            this.textBox1.TabIndex = 4;
            // 
            // txtJson
            // 
            this.txtJson.Location = new System.Drawing.Point(18, 64);
            this.txtJson.Multiline = true;
            this.txtJson.Name = "txtJson";
            this.txtJson.Size = new System.Drawing.Size(541, 107);
            this.txtJson.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(563, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txtQueue
            // 
            this.txtQueue.Location = new System.Drawing.Point(508, 39);
            this.txtQueue.Name = "txtQueue";
            this.txtQueue.Size = new System.Drawing.Size(93, 20);
            this.txtQueue.TabIndex = 26;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(508, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(93, 13);
            this.textBox2.TabIndex = 25;
            this.textBox2.Text = "Queue";
            // 
            // VeriFactu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 201);
            this.Controls.Add(this.txtQueue);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtJson);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTienda);
            this.Controls.Add(this.txtReenvio);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.txtTipo);
            this.Name = "VeriFactu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtTipo;
        private TextBox txtFactura;
        private TextBox txtYear;
        private TextBox txtReenvio;
        private TextBox txtTienda;
        private TextBox label5;
        private TextBox label4;
        private TextBox label3;
        private TextBox label2;
        private TextBox label1;
        private TextBox textBox1;
        private TextBox txtJson;
        private PictureBox pictureBox1;
        private TextBox txtQueue;
        private TextBox textBox2;
    }
}