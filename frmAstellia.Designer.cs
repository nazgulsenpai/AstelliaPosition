namespace AstelliaPosition
{
    partial class frmAstellia
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
            this.components = new System.ComponentModel.Container();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonSet = new System.Windows.Forms.Button();
            this.curZ = new System.Windows.Forms.Label();
            this.curY = new System.Windows.Forms.Label();
            this.curX = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.threadSignatureScan = new System.ComponentModel.BackgroundWorker();
            this.threadUpdater = new System.ComponentModel.BackgroundWorker();
            this.checkSignature = new System.Windows.Forms.Timer(this.components);
            this.numX = new System.Windows.Forms.TextBox();
            this.numY = new System.Windows.Forms.TextBox();
            this.numZ = new System.Windows.Forms.TextBox();
            this.buttonReload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(80, 88);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 20;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.ButtonApply_Click);
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(0, 88);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(75, 23);
            this.buttonSet.TabIndex = 19;
            this.buttonSet.Text = "Set";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.ButtonSet_Click);
            // 
            // curZ
            // 
            this.curZ.Location = new System.Drawing.Point(152, 56);
            this.curZ.Name = "curZ";
            this.curZ.Size = new System.Drawing.Size(72, 13);
            this.curZ.TabIndex = 18;
            // 
            // curY
            // 
            this.curY.Location = new System.Drawing.Point(152, 32);
            this.curY.Name = "curY";
            this.curY.Size = new System.Drawing.Size(72, 13);
            this.curY.TabIndex = 17;
            // 
            // curX
            // 
            this.curX.Location = new System.Drawing.Point(152, 8);
            this.curX.Name = "curX";
            this.curX.Size = new System.Drawing.Size(72, 13);
            this.curX.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Z:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "X: ";
            // 
            // threadSignatureScan
            // 
            this.threadSignatureScan.WorkerReportsProgress = true;
            this.threadSignatureScan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ThreadSignatureScan_DoWork);
            this.threadSignatureScan.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.ThreadSignatureScan_ProgressChanged);
            this.threadSignatureScan.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ThreadSignatureScan_RunWorkerCompleted);
            // 
            // threadUpdater
            // 
            this.threadUpdater.WorkerReportsProgress = true;
            this.threadUpdater.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ThreadUpdater_DoWork);
            this.threadUpdater.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.ThreadUpdater_ProgressChanged);
            // 
            // checkSignature
            // 
            this.checkSignature.Enabled = true;
            this.checkSignature.Interval = 1000;
            this.checkSignature.Tick += new System.EventHandler(this.CheckSignature_Tick);
            // 
            // numX
            // 
            this.numX.Location = new System.Drawing.Point(24, 8);
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(120, 20);
            this.numX.TabIndex = 21;
            // 
            // numY
            // 
            this.numY.Location = new System.Drawing.Point(24, 32);
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(120, 20);
            this.numY.TabIndex = 22;
            // 
            // numZ
            // 
            this.numZ.Location = new System.Drawing.Point(24, 56);
            this.numZ.Name = "numZ";
            this.numZ.Size = new System.Drawing.Size(120, 20);
            this.numZ.TabIndex = 23;
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(160, 88);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(75, 23);
            this.buttonReload.TabIndex = 24;
            this.buttonReload.Text = "Reload";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.ButtonReload_Click);
            // 
            // frmAstellia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 120);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.numZ);
            this.Controls.Add(this.numY);
            this.Controls.Add(this.numX);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.curZ);
            this.Controls.Add(this.curY);
            this.Controls.Add(this.curX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAstellia";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Astellia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Label curZ;
        private System.Windows.Forms.Label curY;
        private System.Windows.Forms.Label curX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.ComponentModel.BackgroundWorker threadSignatureScan;
        public System.ComponentModel.BackgroundWorker threadUpdater;
        private System.Windows.Forms.Timer checkSignature;
        private System.Windows.Forms.TextBox numX;
        private System.Windows.Forms.TextBox numY;
        private System.Windows.Forms.TextBox numZ;
        private System.Windows.Forms.Button buttonReload;
    }
}

