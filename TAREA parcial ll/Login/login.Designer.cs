namespace Login
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.correotextBox = new System.Windows.Forms.TextBox();
            this.clavetextBox = new System.Windows.Forms.TextBox();
            this.aceptarbutton = new System.Windows.Forms.Button();
            this.cancelarnutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave:";
            // 
            // correotextBox
            // 
            this.correotextBox.Location = new System.Drawing.Point(90, 41);
            this.correotextBox.Name = "correotextBox";
            this.correotextBox.Size = new System.Drawing.Size(178, 23);
            this.correotextBox.TabIndex = 2;
            // 
            // clavetextBox
            // 
            this.clavetextBox.Location = new System.Drawing.Point(90, 78);
            this.clavetextBox.Name = "clavetextBox";
            this.clavetextBox.Size = new System.Drawing.Size(178, 23);
            this.clavetextBox.TabIndex = 3;
            // 
            // aceptarbutton
            // 
            this.aceptarbutton.Location = new System.Drawing.Point(66, 132);
            this.aceptarbutton.Name = "aceptarbutton";
            this.aceptarbutton.Size = new System.Drawing.Size(85, 33);
            this.aceptarbutton.TabIndex = 4;
            this.aceptarbutton.Text = "Aceptar";
            this.aceptarbutton.UseVisualStyleBackColor = true;
            this.aceptarbutton.Click += new System.EventHandler(this.aceptarbutton_Click);
            // 
            // cancelarnutton
            // 
            this.cancelarnutton.Location = new System.Drawing.Point(194, 132);
            this.cancelarnutton.Name = "cancelarnutton";
            this.cancelarnutton.Size = new System.Drawing.Size(84, 33);
            this.cancelarnutton.TabIndex = 5;
            this.cancelarnutton.Text = "Cancelar";
            this.cancelarnutton.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 203);
            this.Controls.Add(this.cancelarnutton);
            this.Controls.Add(this.aceptarbutton);
            this.Controls.Add(this.clavetextBox);
            this.Controls.Add(this.correotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox correotextBox;
        private TextBox clavetextBox;
        private Button aceptarbutton;
        private Button cancelarnutton;
        private ErrorProvider errorProvider1;
    }
}