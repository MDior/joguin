namespace JogoGenius
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
            components = new System.ComponentModel.Container();
            btVERDE = new Button();
            btAMARELO = new Button();
            btVERMELHO = new Button();
            btAZUL = new Button();
            label1 = new Label();
            lblNivel = new Label();
            btINICIAR = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btVERDE
            // 
            btVERDE.FlatStyle = FlatStyle.Flat;
            btVERDE.Location = new Point(69, 52);
            btVERDE.Name = "btVERDE";
            btVERDE.Size = new Size(135, 114);
            btVERDE.TabIndex = 0;
            btVERDE.UseVisualStyleBackColor = true;
            btVERDE.Click += bt_Click;
            // 
            // btAMARELO
            // 
            btAMARELO.FlatStyle = FlatStyle.Flat;
            btAMARELO.Location = new Point(210, 53);
            btAMARELO.Name = "btAMARELO";
            btAMARELO.Size = new Size(135, 112);
            btAMARELO.TabIndex = 1;
            btAMARELO.UseVisualStyleBackColor = true;
            btAMARELO.Click += bt_Click;
            // 
            // btVERMELHO
            // 
            btVERMELHO.FlatStyle = FlatStyle.Flat;
            btVERMELHO.Location = new Point(69, 172);
            btVERMELHO.Name = "btVERMELHO";
            btVERMELHO.Size = new Size(135, 114);
            btVERMELHO.TabIndex = 2;
            btVERMELHO.UseVisualStyleBackColor = true;
            btVERMELHO.Click += bt_Click;
            // 
            // btAZUL
            // 
            btAZUL.FlatStyle = FlatStyle.Flat;
            btAZUL.Location = new Point(210, 172);
            btAZUL.Name = "btAZUL";
            btAZUL.Size = new Size(135, 114);
            btAZUL.TabIndex = 3;
            btAZUL.UseVisualStyleBackColor = true;
            btAZUL.Click += bt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 321);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 4;
            label1.Text = "Nível:";
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Font = new Font("Segoe UI", 10F);
            lblNivel.Location = new Point(230, 318);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(0, 23);
            lblNivel.TabIndex = 5;
            // 
            // btINICIAR
            // 
            btINICIAR.Location = new Point(158, 354);
            btINICIAR.Name = "btINICIAR";
            btINICIAR.Size = new Size(94, 75);
            btINICIAR.TabIndex = 6;
            btINICIAR.Text = "Iniciar";
            btINICIAR.UseVisualStyleBackColor = true;
            btINICIAR.Click += btINICIAR_Click;
            // 
            // timer1
            // 
            timer1.Interval = 250;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 450);
            Controls.Add(btINICIAR);
            Controls.Add(lblNivel);
            Controls.Add(label1);
            Controls.Add(btAZUL);
            Controls.Add(btVERMELHO);
            Controls.Add(btAMARELO);
            Controls.Add(btVERDE);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btVERDE;
        private Button btAMARELO;
        private Button btVERMELHO;
        private Button btAZUL;
        private Label label1;
        private Label lblNivel;
        private Button btINICIAR;
        private System.Windows.Forms.Timer timer1;
    }
}
