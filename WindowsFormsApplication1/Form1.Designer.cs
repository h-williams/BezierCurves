namespace WindowsFormsApplication1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			this.point1 = new System.Windows.Forms.PictureBox();
			this.point3 = new System.Windows.Forms.PictureBox();
			this.point2 = new System.Windows.Forms.PictureBox();
			this.renderCurves = new System.Windows.Forms.Button();
			this.smoothnessText = new System.Windows.Forms.TextBox();
			this.lblSmoothness = new System.Windows.Forms.Label();
			this.cbShowPoints = new System.Windows.Forms.CheckBox();
			this.p1x = new System.Windows.Forms.TextBox();
			this.p2x = new System.Windows.Forms.TextBox();
			this.p3x = new System.Windows.Forms.TextBox();
			this.setPositions = new System.Windows.Forms.Button();
			this.txtp1 = new System.Windows.Forms.Label();
			this.txtp2 = new System.Windows.Forms.Label();
			this.txtp3 = new System.Windows.Forms.Label();
			this.p1y = new System.Windows.Forms.TextBox();
			this.p2y = new System.Windows.Forms.TextBox();
			this.p3y = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.point1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.point3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.point2)).BeginInit();
			this.SuspendLayout();
			// 
			// point1
			// 
			this.point1.Image = global::WindowsFormsApplication1.Properties.Resources.curvePoint;
			this.point1.Location = new System.Drawing.Point(10, 10);
			this.point1.Name = "point1";
			this.point1.Size = new System.Drawing.Size(15, 15);
			this.point1.TabIndex = 1;
			this.point1.TabStop = false;
			// 
			// point3
			// 
			this.point3.Image = global::WindowsFormsApplication1.Properties.Resources.curvePoint;
			this.point3.Location = new System.Drawing.Point(500, 100);
			this.point3.Name = "point3";
			this.point3.Size = new System.Drawing.Size(15, 15);
			this.point3.TabIndex = 2;
			this.point3.TabStop = false;
			// 
			// point2
			// 
			this.point2.Image = global::WindowsFormsApplication1.Properties.Resources.curvePoint;
			this.point2.Location = new System.Drawing.Point(100, 400);
			this.point2.Name = "point2";
			this.point2.Size = new System.Drawing.Size(15, 15);
			this.point2.TabIndex = 3;
			this.point2.TabStop = false;
			// 
			// renderCurves
			// 
			this.renderCurves.Location = new System.Drawing.Point(12, 524);
			this.renderCurves.Name = "renderCurves";
			this.renderCurves.Size = new System.Drawing.Size(90, 25);
			this.renderCurves.TabIndex = 4;
			this.renderCurves.Text = "Render Curve";
			this.renderCurves.UseVisualStyleBackColor = true;
			this.renderCurves.Click += new System.EventHandler(this.renderCurves_Click);
			// 
			// smoothnessText
			// 
			this.smoothnessText.Location = new System.Drawing.Point(82, 498);
			this.smoothnessText.Name = "smoothnessText";
			this.smoothnessText.Size = new System.Drawing.Size(20, 20);
			this.smoothnessText.TabIndex = 6;
			this.smoothnessText.Text = "10";
			// 
			// lblSmoothness
			// 
			this.lblSmoothness.Location = new System.Drawing.Point(9, 495);
			this.lblSmoothness.Name = "lblSmoothness";
			this.lblSmoothness.Size = new System.Drawing.Size(70, 25);
			this.lblSmoothness.TabIndex = 7;
			this.lblSmoothness.Text = "Smoothness:";
			this.lblSmoothness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbShowPoints
			// 
			this.cbShowPoints.Checked = true;
			this.cbShowPoints.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbShowPoints.Location = new System.Drawing.Point(12, 466);
			this.cbShowPoints.Name = "cbShowPoints";
			this.cbShowPoints.Size = new System.Drawing.Size(90, 25);
			this.cbShowPoints.TabIndex = 9;
			this.cbShowPoints.Text = "Show Points";
			this.cbShowPoints.UseVisualStyleBackColor = true;
			this.cbShowPoints.CheckedChanged += new System.EventHandler(this.cbShowPoints_CheckedChanged);
			// 
			// p1x
			// 
			this.p1x.Location = new System.Drawing.Point(128, 446);
			this.p1x.Name = "p1x";
			this.p1x.Size = new System.Drawing.Size(34, 20);
			this.p1x.TabIndex = 10;
			this.p1x.Text = "10";
			// 
			// p2x
			// 
			this.p2x.Location = new System.Drawing.Point(128, 472);
			this.p2x.Name = "p2x";
			this.p2x.Size = new System.Drawing.Size(34, 20);
			this.p2x.TabIndex = 11;
			this.p2x.Text = "100";
			// 
			// p3x
			// 
			this.p3x.Location = new System.Drawing.Point(128, 498);
			this.p3x.Name = "p3x";
			this.p3x.Size = new System.Drawing.Size(34, 20);
			this.p3x.TabIndex = 12;
			this.p3x.Text = "500";
			// 
			// setPositions
			// 
			this.setPositions.Location = new System.Drawing.Point(108, 524);
			this.setPositions.Name = "setPositions";
			this.setPositions.Size = new System.Drawing.Size(90, 25);
			this.setPositions.TabIndex = 13;
			this.setPositions.Text = "Set Positions";
			this.setPositions.UseVisualStyleBackColor = true;
			this.setPositions.Click += new System.EventHandler(this.setPositions_Click);
			// 
			// txtp1
			// 
			this.txtp1.Location = new System.Drawing.Point(108, 445);
			this.txtp1.Name = "txtp1";
			this.txtp1.Size = new System.Drawing.Size(20, 20);
			this.txtp1.TabIndex = 14;
			this.txtp1.Text = "1:";
			this.txtp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtp2
			// 
			this.txtp2.Location = new System.Drawing.Point(108, 471);
			this.txtp2.Name = "txtp2";
			this.txtp2.Size = new System.Drawing.Size(20, 20);
			this.txtp2.TabIndex = 15;
			this.txtp2.Text = "2:";
			this.txtp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtp3
			// 
			this.txtp3.Location = new System.Drawing.Point(108, 497);
			this.txtp3.Name = "txtp3";
			this.txtp3.Size = new System.Drawing.Size(20, 20);
			this.txtp3.TabIndex = 16;
			this.txtp3.Text = "3:";
			this.txtp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// p1y
			// 
			this.p1y.Location = new System.Drawing.Point(164, 446);
			this.p1y.Name = "p1y";
			this.p1y.Size = new System.Drawing.Size(34, 20);
			this.p1y.TabIndex = 17;
			this.p1y.Text = "10";
			// 
			// p2y
			// 
			this.p2y.Location = new System.Drawing.Point(164, 472);
			this.p2y.Name = "p2y";
			this.p2y.Size = new System.Drawing.Size(34, 20);
			this.p2y.TabIndex = 18;
			this.p2y.Text = "400";
			// 
			// p3y
			// 
			this.p3y.Location = new System.Drawing.Point(164, 498);
			this.p3y.Name = "p3y";
			this.p3y.Size = new System.Drawing.Size(34, 20);
			this.p3y.TabIndex = 19;
			this.p3y.Text = "100";
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.p3y);
			this.Controls.Add(this.p2y);
			this.Controls.Add(this.p1y);
			this.Controls.Add(this.txtp3);
			this.Controls.Add(this.txtp2);
			this.Controls.Add(this.txtp1);
			this.Controls.Add(this.setPositions);
			this.Controls.Add(this.p3x);
			this.Controls.Add(this.p2x);
			this.Controls.Add(this.p1x);
			this.Controls.Add(this.cbShowPoints);
			this.Controls.Add(this.lblSmoothness);
			this.Controls.Add(this.smoothnessText);
			this.Controls.Add(this.renderCurves);
			this.Controls.Add(this.point2);
			this.Controls.Add(this.point3);
			this.Controls.Add(this.point1);
			this.Name = "Form1";
			this.Text = "Bezier Curves";
			((System.ComponentModel.ISupportInitialize)(this.point1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.point3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.point2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox point1;
        private System.Windows.Forms.PictureBox point3;
        private System.Windows.Forms.PictureBox point2;
		private System.Windows.Forms.Button renderCurves;
		private System.Windows.Forms.TextBox smoothnessText;
		private System.Windows.Forms.Label lblSmoothness;
		private System.Windows.Forms.CheckBox cbShowPoints;
		private System.Windows.Forms.TextBox p1x;
		private System.Windows.Forms.TextBox p2x;
		private System.Windows.Forms.TextBox p3x;
		private System.Windows.Forms.Button setPositions;
		private System.Windows.Forms.Label txtp1;
		private System.Windows.Forms.Label txtp2;
		private System.Windows.Forms.Label txtp3;
		private System.Windows.Forms.TextBox p1y;
		private System.Windows.Forms.TextBox p2y;
		private System.Windows.Forms.TextBox p3y;
	}
}

