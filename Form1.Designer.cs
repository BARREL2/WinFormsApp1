﻿namespace WinFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BT_ButtonA = new System.Windows.Forms.Button();
            this.TB_Box1 = new System.Windows.Forms.TextBox();
            this.LB_ToUpper = new System.Windows.Forms.Label();
            this.LB_ToLower = new System.Windows.Forms.Label();
            this.LB_Timer = new System.Windows.Forms.Label();
            this.LB_Counter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // BT_ButtonA
            // 
            this.BT_ButtonA.Location = new System.Drawing.Point(172, 12);
            this.BT_ButtonA.Name = "BT_ButtonA";
            this.BT_ButtonA.Size = new System.Drawing.Size(75, 23);
            this.BT_ButtonA.TabIndex = 1;
            this.BT_ButtonA.Text = "String";
            this.BT_ButtonA.UseVisualStyleBackColor = true;
            this.BT_ButtonA.Click += new System.EventHandler(this.BT_ButtonA_Click);
            // 
            // TB_Box1
            // 
            this.TB_Box1.Location = new System.Drawing.Point(12, 12);
            this.TB_Box1.Name = "TB_Box1";
            this.TB_Box1.Size = new System.Drawing.Size(154, 23);
            this.TB_Box1.TabIndex = 2;
            // 
            // LB_ToUpper
            // 
            this.LB_ToUpper.AutoSize = true;
            this.LB_ToUpper.Location = new System.Drawing.Point(12, 38);
            this.LB_ToUpper.Name = "LB_ToUpper";
            this.LB_ToUpper.Size = new System.Drawing.Size(38, 15);
            this.LB_ToUpper.TabIndex = 3;
            this.LB_ToUpper.Text = "label1";
            // 
            // LB_ToLower
            // 
            this.LB_ToLower.AutoSize = true;
            this.LB_ToLower.Location = new System.Drawing.Point(12, 53);
            this.LB_ToLower.Name = "LB_ToLower";
            this.LB_ToLower.Size = new System.Drawing.Size(38, 15);
            this.LB_ToLower.TabIndex = 4;
            this.LB_ToLower.Text = "label2";
            // 
            // LB_Timer
            // 
            this.LB_Timer.AutoSize = true;
            this.LB_Timer.Location = new System.Drawing.Point(172, 53);
            this.LB_Timer.Name = "LB_Timer";
            this.LB_Timer.Size = new System.Drawing.Size(34, 15);
            this.LB_Timer.TabIndex = 5;
            this.LB_Timer.Text = "timer";
            // 
            // LB_Counter
            // 
            this.LB_Counter.AutoSize = true;
            this.LB_Counter.Location = new System.Drawing.Point(172, 38);
            this.LB_Counter.Name = "LB_Counter";
            this.LB_Counter.Size = new System.Drawing.Size(48, 15);
            this.LB_Counter.TabIndex = 6;
            this.LB_Counter.Text = "counter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 93);
            this.Controls.Add(this.LB_Counter);
            this.Controls.Add(this.LB_Timer);
            this.Controls.Add(this.LB_ToLower);
            this.Controls.Add(this.LB_ToUpper);
            this.Controls.Add(this.TB_Box1);
            this.Controls.Add(this.BT_ButtonA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Button BT_ButtonA;
        private TextBox TB_Box1;
        private Label LB_ToUpper;
        private Label LB_ToLower;
        private Label LB_Timer;
        private Label LB_Counter;
    }
}