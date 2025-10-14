namespace SewersApp3
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
            PanelBoard = new Panel();
            ShopPanel = new Panel();
            label1 = new Label();
            ShopDebug = new Button();
            SelectedPicture = new PictureBox();
            SelectionLeft = new Button();
            SelectionRight = new Button();
            ((System.ComponentModel.ISupportInitialize)SelectedPicture).BeginInit();
            SuspendLayout();
            // 
            // PanelBoard
            // 
            PanelBoard.Location = new Point(126, 29);
            PanelBoard.Name = "PanelBoard";
            PanelBoard.Size = new Size(1000, 600);
            PanelBoard.TabIndex = 0;
            // 
            // ShopPanel
            // 
            ShopPanel.Location = new Point(0, 204);
            ShopPanel.Name = "ShopPanel";
            ShopPanel.Size = new Size(120, 425);
            ShopPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1176, 109);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // ShopDebug
            // 
            ShopDebug.Location = new Point(1160, 138);
            ShopDebug.Name = "ShopDebug";
            ShopDebug.Size = new Size(75, 23);
            ShopDebug.TabIndex = 3;
            ShopDebug.Text = "Start Shop";
            ShopDebug.UseVisualStyleBackColor = true;
            ShopDebug.Click += ShopDebug_Click;
            // 
            // SelectedPicture
            // 
            SelectedPicture.Location = new Point(9, 29);
            SelectedPicture.Name = "SelectedPicture";
            SelectedPicture.Size = new Size(108, 104);
            SelectedPicture.TabIndex = 4;
            SelectedPicture.TabStop = false;
            // 
            // SelectionLeft
            // 
            SelectionLeft.Location = new Point(9, 138);
            SelectionLeft.Name = "SelectionLeft";
            SelectionLeft.Size = new Size(43, 23);
            SelectionLeft.TabIndex = 5;
            SelectionLeft.Text = "left";
            SelectionLeft.UseVisualStyleBackColor = true;
            SelectionLeft.Click += SelectLeft_Click;
            // 
            // SelectionRight
            // 
            SelectionRight.Location = new Point(68, 138);
            SelectionRight.Name = "SelectionRight";
            SelectionRight.Size = new Size(49, 23);
            SelectionRight.TabIndex = 6;
            SelectionRight.Text = "right";
            SelectionRight.UseVisualStyleBackColor = true;
            SelectionRight.Click += SelectRight_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 726);
            Controls.Add(SelectionRight);
            Controls.Add(SelectionLeft);
            Controls.Add(SelectedPicture);
            Controls.Add(ShopDebug);
            Controls.Add(label1);
            Controls.Add(ShopPanel);
            Controls.Add(PanelBoard);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)SelectedPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelBoard;
        private Panel ShopPanel;
        private Label label1;
        private Button ShopDebug;
        private PictureBox SelectedPicture;
        private Button SelectionLeft;
        private Button SelectionRight;
    }
}
