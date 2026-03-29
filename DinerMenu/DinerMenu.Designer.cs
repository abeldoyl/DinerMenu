namespace DinerMenu
{
    partial class DinerMenu
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
            DinerMenuLabel = new Label();
            SoupButton = new Button();
            SaladButton = new Button();
            FishButton = new Button();
            ExitButton = new Button();
            DisplayLabel = new Label();
            MenuItemLabel = new Label();
            SuspendLayout();
            // 
            // DinerMenuLabel
            // 
            DinerMenuLabel.AutoSize = true;
            DinerMenuLabel.Font = new Font("Roboto Slab", 28.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            DinerMenuLabel.Location = new Point(113, 9);
            DinerMenuLabel.Name = "DinerMenuLabel";
            DinerMenuLabel.Size = new Size(555, 63);
            DinerMenuLabel.TabIndex = 0;
            DinerMenuLabel.Text = "Botics Fine Diner Menu";
            // 
            // SoupButton
            // 
            SoupButton.Location = new Point(12, 374);
            SoupButton.Name = "SoupButton";
            SoupButton.Size = new Size(126, 64);
            SoupButton.TabIndex = 0;
            SoupButton.Text = "Soup";
            SoupButton.UseVisualStyleBackColor = true;
            SoupButton.Click += SoupButton_Click;
            // 
            // SaladButton
            // 
            SaladButton.Location = new Point(144, 374);
            SaladButton.Name = "SaladButton";
            SaladButton.Size = new Size(126, 64);
            SaladButton.TabIndex = 1;
            SaladButton.Text = "Salad";
            SaladButton.UseVisualStyleBackColor = true;
            SaladButton.Click += SaladButton_Click;
            // 
            // FishButton
            // 
            FishButton.Location = new Point(276, 374);
            FishButton.Name = "FishButton";
            FishButton.Size = new Size(126, 64);
            FishButton.TabIndex = 2;
            FishButton.Text = "Fish";
            FishButton.UseVisualStyleBackColor = true;
            FishButton.Click += FishButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(662, 374);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(126, 64);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // DisplayLabel
            // 
            DisplayLabel.AutoSize = true;
            DisplayLabel.Font = new Font("Roboto Slab", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DisplayLabel.Location = new Point(246, 122);
            DisplayLabel.Name = "DisplayLabel";
            DisplayLabel.Size = new Size(100, 40);
            DisplayLabel.TabIndex = 4;
            DisplayLabel.Text = "label1";
            // 
            // MenuItemLabel
            // 
            MenuItemLabel.AutoSize = true;
            MenuItemLabel.Font = new Font("Roboto Slab", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuItemLabel.Location = new Point(31, 184);
            MenuItemLabel.Name = "MenuItemLabel";
            MenuItemLabel.Size = new Size(75, 31);
            MenuItemLabel.TabIndex = 5;
            MenuItemLabel.Text = "label1";
            // 
            // DinerMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MenuItemLabel);
            Controls.Add(DisplayLabel);
            Controls.Add(ExitButton);
            Controls.Add(FishButton);
            Controls.Add(SaladButton);
            Controls.Add(SoupButton);
            Controls.Add(DinerMenuLabel);
            Name = "DinerMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Botics Fine Diner Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DinerMenuLabel;
        private Button SoupButton;
        private Button SaladButton;
        private Button FishButton;
        private Button ExitButton;
        private Label DisplayLabel;
        private Label MenuItemLabel;
    }
}
