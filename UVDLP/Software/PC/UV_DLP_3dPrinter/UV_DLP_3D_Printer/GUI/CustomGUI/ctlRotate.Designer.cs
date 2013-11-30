﻿namespace UV_DLP_3D_Printer.GUI.CustomGUI
{
    partial class ctlRotate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.buttRotateXMinus = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.textRotateX = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox();
            this.buttRotateXPlus = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.buttRotateYMinus = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.textRotateY = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox();
            this.buttRotateYPlus = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.buttRotateZMinus = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.textRotateZ = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox();
            this.buttRotateZPlus = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Navy;
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel10);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(170, 156);
            this.flowLayoutPanel2.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "Rotate (deg)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel7.Controls.Add(this.label9);
            this.flowLayoutPanel7.Controls.Add(this.buttRotateXMinus);
            this.flowLayoutPanel7.Controls.Add(this.textRotateX);
            this.flowLayoutPanel7.Controls.Add(this.buttRotateXPlus);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 34);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(164, 38);
            this.flowLayoutPanel7.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 32);
            this.label9.TabIndex = 1;
            this.label9.Text = "X";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttRotateXMinus
            // 
            this.buttRotateXMinus.BackColor = System.Drawing.Color.Navy;
            this.buttRotateXMinus.Gapx = 5;
            this.buttRotateXMinus.Gapy = 5;
            this.buttRotateXMinus.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRotateXMinus.Image = global::UV_DLP_3D_Printer.Properties.Resources.butMinus;
            this.buttRotateXMinus.Location = new System.Drawing.Point(32, 5);
            this.buttRotateXMinus.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttRotateXMinus.Name = "buttRotateXMinus";
            this.buttRotateXMinus.Size = new System.Drawing.Size(28, 28);
            this.buttRotateXMinus.TabIndex = 2;
            this.buttRotateXMinus.Text = "ctlImageButton2";
            this.buttRotateXMinus.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRotateXMinus.Click += new System.EventHandler(this.buttRotateXMinus_Click);
            // 
            // textRotateX
            // 
            this.textRotateX.BackColor = System.Drawing.Color.Navy;
            this.textRotateX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRotateX.ErrorColor = System.Drawing.Color.Red;
            this.textRotateX.FloatVal = 90F;
            this.textRotateX.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textRotateX.ForeColor = System.Drawing.Color.White;
            this.textRotateX.IntVal = 1;
            this.textRotateX.Location = new System.Drawing.Point(66, 5);
            this.textRotateX.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textRotateX.MaxFloat = 360F;
            this.textRotateX.MaxInt = 1000;
            this.textRotateX.MinFloat = 0F;
            this.textRotateX.MinInt = 1;
            this.textRotateX.Name = "textRotateX";
            this.textRotateX.Size = new System.Drawing.Size(60, 28);
            this.textRotateX.TabIndex = 4;
            this.textRotateX.Text = "90";
            this.textRotateX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textRotateX.ValidColor = System.Drawing.Color.White;
            this.textRotateX.ValueType = UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox.EValueType.Float;
            // 
            // buttRotateXPlus
            // 
            this.buttRotateXPlus.BackColor = System.Drawing.Color.Navy;
            this.buttRotateXPlus.Gapx = 5;
            this.buttRotateXPlus.Gapy = 5;
            this.buttRotateXPlus.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRotateXPlus.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttPlus;
            this.buttRotateXPlus.Location = new System.Drawing.Point(132, 5);
            this.buttRotateXPlus.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttRotateXPlus.Name = "buttRotateXPlus";
            this.buttRotateXPlus.Size = new System.Drawing.Size(28, 28);
            this.buttRotateXPlus.TabIndex = 3;
            this.buttRotateXPlus.Text = "ctlImageButton8";
            this.buttRotateXPlus.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRotateXPlus.Click += new System.EventHandler(this.buttRotateXPlus_Click);
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel8.Controls.Add(this.label10);
            this.flowLayoutPanel8.Controls.Add(this.buttRotateYMinus);
            this.flowLayoutPanel8.Controls.Add(this.textRotateY);
            this.flowLayoutPanel8.Controls.Add(this.buttRotateYPlus);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(3, 75);
            this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(164, 38);
            this.flowLayoutPanel8.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 32);
            this.label10.TabIndex = 1;
            this.label10.Text = "Y";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttRotateYMinus
            // 
            this.buttRotateYMinus.BackColor = System.Drawing.Color.Navy;
            this.buttRotateYMinus.Gapx = 5;
            this.buttRotateYMinus.Gapy = 5;
            this.buttRotateYMinus.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRotateYMinus.Image = global::UV_DLP_3D_Printer.Properties.Resources.butMinus;
            this.buttRotateYMinus.Location = new System.Drawing.Point(32, 5);
            this.buttRotateYMinus.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttRotateYMinus.Name = "buttRotateYMinus";
            this.buttRotateYMinus.Size = new System.Drawing.Size(28, 28);
            this.buttRotateYMinus.TabIndex = 2;
            this.buttRotateYMinus.Text = "ctlImageButton9";
            this.buttRotateYMinus.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRotateYMinus.Click += new System.EventHandler(this.buttRotateYMinus_Click);
            // 
            // textRotateY
            // 
            this.textRotateY.BackColor = System.Drawing.Color.Navy;
            this.textRotateY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRotateY.ErrorColor = System.Drawing.Color.Red;
            this.textRotateY.FloatVal = 90F;
            this.textRotateY.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textRotateY.ForeColor = System.Drawing.Color.White;
            this.textRotateY.IntVal = 1;
            this.textRotateY.Location = new System.Drawing.Point(66, 5);
            this.textRotateY.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textRotateY.MaxFloat = 360F;
            this.textRotateY.MaxInt = 1000;
            this.textRotateY.MinFloat = 0F;
            this.textRotateY.MinInt = 1;
            this.textRotateY.Name = "textRotateY";
            this.textRotateY.Size = new System.Drawing.Size(60, 28);
            this.textRotateY.TabIndex = 4;
            this.textRotateY.Text = "90";
            this.textRotateY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textRotateY.ValidColor = System.Drawing.Color.White;
            this.textRotateY.ValueType = UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox.EValueType.Float;
            // 
            // buttRotateYPlus
            // 
            this.buttRotateYPlus.BackColor = System.Drawing.Color.Navy;
            this.buttRotateYPlus.Gapx = 5;
            this.buttRotateYPlus.Gapy = 5;
            this.buttRotateYPlus.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRotateYPlus.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttPlus;
            this.buttRotateYPlus.Location = new System.Drawing.Point(132, 5);
            this.buttRotateYPlus.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttRotateYPlus.Name = "buttRotateYPlus";
            this.buttRotateYPlus.Size = new System.Drawing.Size(28, 28);
            this.buttRotateYPlus.TabIndex = 3;
            this.buttRotateYPlus.Text = "ctlImageButton10";
            this.buttRotateYPlus.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRotateYPlus.Click += new System.EventHandler(this.buttRotateYPlus_Click);
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel10.Controls.Add(this.label11);
            this.flowLayoutPanel10.Controls.Add(this.buttRotateZMinus);
            this.flowLayoutPanel10.Controls.Add(this.textRotateZ);
            this.flowLayoutPanel10.Controls.Add(this.buttRotateZPlus);
            this.flowLayoutPanel10.Location = new System.Drawing.Point(3, 116);
            this.flowLayoutPanel10.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(164, 38);
            this.flowLayoutPanel10.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 3);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 32);
            this.label11.TabIndex = 1;
            this.label11.Text = "Z";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttRotateZMinus
            // 
            this.buttRotateZMinus.BackColor = System.Drawing.Color.Navy;
            this.buttRotateZMinus.Gapx = 5;
            this.buttRotateZMinus.Gapy = 5;
            this.buttRotateZMinus.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRotateZMinus.Image = global::UV_DLP_3D_Printer.Properties.Resources.butMinus;
            this.buttRotateZMinus.Location = new System.Drawing.Point(32, 5);
            this.buttRotateZMinus.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttRotateZMinus.Name = "buttRotateZMinus";
            this.buttRotateZMinus.Size = new System.Drawing.Size(28, 28);
            this.buttRotateZMinus.TabIndex = 2;
            this.buttRotateZMinus.Text = "ctlImageButton11";
            this.buttRotateZMinus.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRotateZMinus.Click += new System.EventHandler(this.buttRotateZMinus_Click);
            // 
            // textRotateZ
            // 
            this.textRotateZ.BackColor = System.Drawing.Color.Navy;
            this.textRotateZ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRotateZ.ErrorColor = System.Drawing.Color.Red;
            this.textRotateZ.FloatVal = 90F;
            this.textRotateZ.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textRotateZ.ForeColor = System.Drawing.Color.White;
            this.textRotateZ.IntVal = 1;
            this.textRotateZ.Location = new System.Drawing.Point(66, 5);
            this.textRotateZ.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textRotateZ.MaxFloat = 360F;
            this.textRotateZ.MaxInt = 1000;
            this.textRotateZ.MinFloat = 0F;
            this.textRotateZ.MinInt = 1;
            this.textRotateZ.Name = "textRotateZ";
            this.textRotateZ.Size = new System.Drawing.Size(60, 28);
            this.textRotateZ.TabIndex = 4;
            this.textRotateZ.Text = "90";
            this.textRotateZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textRotateZ.ValidColor = System.Drawing.Color.White;
            this.textRotateZ.ValueType = UV_DLP_3D_Printer.GUI.CustomGUI.ctlTextBox.EValueType.Float;
            // 
            // buttRotateZPlus
            // 
            this.buttRotateZPlus.BackColor = System.Drawing.Color.Navy;
            this.buttRotateZPlus.Gapx = 5;
            this.buttRotateZPlus.Gapy = 5;
            this.buttRotateZPlus.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRotateZPlus.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttPlus;
            this.buttRotateZPlus.Location = new System.Drawing.Point(132, 5);
            this.buttRotateZPlus.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttRotateZPlus.Name = "buttRotateZPlus";
            this.buttRotateZPlus.Size = new System.Drawing.Size(28, 28);
            this.buttRotateZPlus.TabIndex = 3;
            this.buttRotateZPlus.Text = "ctlImageButton12";
            this.buttRotateZPlus.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.None;
            this.buttRotateZPlus.Click += new System.EventHandler(this.buttRotateZPlus_Click);
            // 
            // ctlRotate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "ctlRotate";
            this.Size = new System.Drawing.Size(170, 156);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label label9;
        private ctlImageButton buttRotateXMinus;
        private ctlImageButton buttRotateXPlus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Label label10;
        private ctlImageButton buttRotateYMinus;
        private ctlImageButton buttRotateYPlus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.Label label11;
        private ctlImageButton buttRotateZMinus;
        private ctlImageButton buttRotateZPlus;
        private ctlTextBox textRotateX;
        private ctlTextBox textRotateY;
        private ctlTextBox textRotateZ;
    }
}