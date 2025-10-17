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
            PanelBoard.Location = new Point(180, 48);
            PanelBoard.Margin = new Padding(4, 5, 4, 5);
            PanelBoard.Name = "PanelBoard";
            PanelBoard.Size = new Size(1429, 1000);
            PanelBoard.TabIndex = 0;
            // 
            // ShopPanel
            // 
            ShopPanel.Location = new Point(0, 340);
            ShopPanel.Margin = new Padding(4, 5, 4, 5);
            ShopPanel.Name = "ShopPanel";
            ShopPanel.Size = new Size(171, 708);
            ShopPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1680, 182);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // ShopDebug
            // 
            ShopDebug.Location = new Point(1657, 230);
            ShopDebug.Margin = new Padding(4, 5, 4, 5);
            ShopDebug.Name = "ShopDebug";
            ShopDebug.Size = new Size(107, 38);
            ShopDebug.TabIndex = 3;
            ShopDebug.Text = "Start Shop";
            ShopDebug.UseVisualStyleBackColor = true;
            ShopDebug.Click += ShopDebug_Click;
            // 
            // SelectedPicture
            // 
            SelectedPicture.Location = new Point(13, 48);
            SelectedPicture.Margin = new Padding(4, 5, 4, 5);
            SelectedPicture.Name = "SelectedPicture";
            SelectedPicture.Size = new Size(154, 173);
            SelectedPicture.TabIndex = 4;
            SelectedPicture.TabStop = false;
            // 
            // SelectionLeft
            // 
            SelectionLeft.Location = new Point(13, 230);
            SelectionLeft.Margin = new Padding(4, 5, 4, 5);
            SelectionLeft.Name = "SelectionLeft";
            SelectionLeft.Size = new Size(61, 38);
            SelectionLeft.TabIndex = 5;
            SelectionLeft.Text = "left";
            SelectionLeft.UseVisualStyleBackColor = true;
            SelectionLeft.Click += SelectLeft_Click;
            // 
            // SelectionRight
            // 
            SelectionRight.Location = new Point(97, 230);
            SelectionRight.Margin = new Padding(4, 5, 4, 5);
            SelectionRight.Name = "SelectionRight";
            SelectionRight.Size = new Size(70, 38);
            SelectionRight.TabIndex = 6;
            SelectionRight.Text = "right";
            SelectionRight.UseVisualStyleBackColor = true;
            SelectionRight.Click += SelectRight_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1823, 1210);
            Controls.Add(SelectionRight);
            Controls.Add(SelectionLeft);
            Controls.Add(SelectedPicture);
            Controls.Add(ShopDebug);
            Controls.Add(label1);
            Controls.Add(ShopPanel);
            Controls.Add(PanelBoard);
            Margin = new Padding(4, 5, 4, 5);
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
