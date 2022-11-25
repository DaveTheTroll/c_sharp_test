namespace FitForPurpose
{
    partial class MainForm
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
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
            System.Windows.Forms.Button buttonFit;
            System.Windows.Forms.Button buttonGenerateData;
            this.panelButtons = new System.Windows.Forms.Panel();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.panelGraph = new System.Windows.Forms.Panel();
            tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            buttonFit = new System.Windows.Forms.Button();
            buttonGenerateData = new System.Windows.Forms.Button();
            tableLayoutPanel.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(this.panelButtons, 0, 0);
            tableLayoutPanel.Controls.Add(this.panelGraph, 1, 0);
            tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            tableLayoutPanel.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.textBoxOut);
            this.panelButtons.Controls.Add(buttonFit);
            this.panelButtons.Controls.Add(buttonGenerateData);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(3, 3);
            this.panelButtons.Name = "panelButtons";
            tableLayoutPanel.SetRowSpan(this.panelButtons, 2);
            this.panelButtons.Size = new System.Drawing.Size(144, 444);
            this.panelButtons.TabIndex = 1;
            // 
            // textBoxOut
            // 
            this.textBoxOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOut.Location = new System.Drawing.Point(0, 262);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ReadOnly = true;
            this.textBoxOut.Size = new System.Drawing.Size(144, 182);
            this.textBoxOut.TabIndex = 2;
            // 
            // buttonFit
            // 
            buttonFit.Location = new System.Drawing.Point(3, 38);
            buttonFit.Name = "buttonFit";
            buttonFit.Size = new System.Drawing.Size(141, 23);
            buttonFit.TabIndex = 0;
            buttonFit.Text = "Fit";
            buttonFit.UseVisualStyleBackColor = true;
            buttonFit.Click += new System.EventHandler(this.buttonFit_Click);
            // 
            // buttonGenerateData
            // 
            buttonGenerateData.Location = new System.Drawing.Point(3, 9);
            buttonGenerateData.Name = "buttonGenerateData";
            buttonGenerateData.Size = new System.Drawing.Size(141, 23);
            buttonGenerateData.TabIndex = 1;
            buttonGenerateData.Text = "Generate Data";
            buttonGenerateData.UseVisualStyleBackColor = true;
            buttonGenerateData.Click += new System.EventHandler(this.buttonGenerateData_Click);
            // 
            // panelGraph
            // 
            this.panelGraph.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraph.Location = new System.Drawing.Point(153, 3);
            this.panelGraph.Name = "panelGraph";
            tableLayoutPanel.SetRowSpan(this.panelGraph, 2);
            this.panelGraph.Size = new System.Drawing.Size(644, 444);
            this.panelGraph.TabIndex = 2;
            this.panelGraph.SizeChanged += new System.EventHandler(this.panelGraph_SizeChanged);
            this.panelGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGraph_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(tableLayoutPanel);
            this.Name = "MainForm";
            this.Text = "Fit for Purpose";
            tableLayoutPanel.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonFit;
        private Button buttonGenerateData;
        private Panel panelButtons;
        private TextBox textBoxOut;
        private Panel panelGraph;
    }
}