namespace Brogan_Assignment3_PokerHand
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dealButton = new Button();
            saveButton = new Button();
            loadButton = new Button();
            keepBoxOne = new CheckBox();
            keepBoxTwo = new CheckBox();
            keepBoxThree = new CheckBox();
            keepBoxFour = new CheckBox();
            keepBoxFive = new CheckBox();
            cardOne = new PictureBox();
            cardTwo = new PictureBox();
            cardThree = new PictureBox();
            cardFour = new PictureBox();
            cardFive = new PictureBox();
            cardList = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)cardOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardThree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardFour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardFive).BeginInit();
            SuspendLayout();
            // 
            // dealButton
            // 
            dealButton.Location = new Point(38, 66);
            dealButton.Name = "dealButton";
            dealButton.Size = new Size(112, 34);
            dealButton.TabIndex = 0;
            dealButton.Text = "&Deal";
            dealButton.UseVisualStyleBackColor = true;
            dealButton.Click += dealButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(732, 66);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(112, 34);
            saveButton.TabIndex = 1;
            saveButton.Text = "&Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(850, 66);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(112, 34);
            loadButton.TabIndex = 2;
            loadButton.Text = "&Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // keepBoxOne
            // 
            keepBoxOne.AutoSize = true;
            keepBoxOne.Location = new Point(50, 124);
            keepBoxOne.Name = "keepBoxOne";
            keepBoxOne.Size = new Size(92, 29);
            keepBoxOne.TabIndex = 3;
            keepBoxOne.Text = "Keep &1";
            keepBoxOne.UseVisualStyleBackColor = true;
            // 
            // keepBoxTwo
            // 
            keepBoxTwo.AutoSize = true;
            keepBoxTwo.Location = new Point(250, 124);
            keepBoxTwo.Name = "keepBoxTwo";
            keepBoxTwo.Size = new Size(92, 29);
            keepBoxTwo.TabIndex = 4;
            keepBoxTwo.Text = "Keep &2";
            keepBoxTwo.UseVisualStyleBackColor = true;
            // 
            // keepBoxThree
            // 
            keepBoxThree.AutoSize = true;
            keepBoxThree.Location = new Point(450, 124);
            keepBoxThree.Name = "keepBoxThree";
            keepBoxThree.Size = new Size(92, 29);
            keepBoxThree.TabIndex = 5;
            keepBoxThree.Text = "Keep &3";
            keepBoxThree.UseVisualStyleBackColor = true;
            // 
            // keepBoxFour
            // 
            keepBoxFour.AutoSize = true;
            keepBoxFour.Location = new Point(650, 124);
            keepBoxFour.Name = "keepBoxFour";
            keepBoxFour.Size = new Size(92, 29);
            keepBoxFour.TabIndex = 6;
            keepBoxFour.Text = "Keep &4";
            keepBoxFour.UseVisualStyleBackColor = true;
            // 
            // keepBoxFive
            // 
            keepBoxFive.AutoSize = true;
            keepBoxFive.Location = new Point(850, 124);
            keepBoxFive.Name = "keepBoxFive";
            keepBoxFive.Size = new Size(92, 29);
            keepBoxFive.TabIndex = 7;
            keepBoxFive.Text = "Keep &5";
            keepBoxFive.UseVisualStyleBackColor = true;
            // 
            // cardOne
            // 
            cardOne.Location = new Point(15, 159);
            cardOne.Name = "cardOne";
            cardOne.Size = new Size(150, 242);
            cardOne.SizeMode = PictureBoxSizeMode.Zoom;
            cardOne.TabIndex = 8;
            cardOne.TabStop = false;
            cardOne.Click += cardOne_Click;
            // 
            // cardTwo
            // 
            cardTwo.Location = new Point(215, 159);
            cardTwo.Name = "cardTwo";
            cardTwo.Size = new Size(150, 242);
            cardTwo.SizeMode = PictureBoxSizeMode.Zoom;
            cardTwo.TabIndex = 9;
            cardTwo.TabStop = false;
            cardTwo.Click += cardTwo_Click;
            // 
            // cardThree
            // 
            cardThree.Location = new Point(415, 159);
            cardThree.Name = "cardThree";
            cardThree.Size = new Size(150, 242);
            cardThree.SizeMode = PictureBoxSizeMode.Zoom;
            cardThree.TabIndex = 10;
            cardThree.TabStop = false;
            cardThree.Click += cardThree_Click;
            // 
            // cardFour
            // 
            cardFour.Location = new Point(615, 159);
            cardFour.Name = "cardFour";
            cardFour.Size = new Size(150, 242);
            cardFour.SizeMode = PictureBoxSizeMode.Zoom;
            cardFour.TabIndex = 11;
            cardFour.TabStop = false;
            cardFour.Click += cardFour_Click;
            // 
            // cardFive
            // 
            cardFive.Location = new Point(815, 159);
            cardFive.Name = "cardFive";
            cardFive.Size = new Size(150, 242);
            cardFive.SizeMode = PictureBoxSizeMode.Zoom;
            cardFive.TabIndex = 12;
            cardFive.TabStop = false;
            cardFive.Click += cardFive_Click;
            // 
            // cardList
            // 
            cardList.ColorDepth = ColorDepth.Depth32Bit;
            cardList.ImageStream = (ImageListStreamer)resources.GetObject("cardList.ImageStream");
            cardList.TransparentColor = Color.Transparent;
            cardList.Images.SetKeyName(0, "p0.png");
            cardList.Images.SetKeyName(1, "p1.png");
            cardList.Images.SetKeyName(2, "p2.png");
            cardList.Images.SetKeyName(3, "p3.png");
            cardList.Images.SetKeyName(4, "p4.png");
            cardList.Images.SetKeyName(5, "p5.png");
            cardList.Images.SetKeyName(6, "p6.png");
            cardList.Images.SetKeyName(7, "p7.png");
            cardList.Images.SetKeyName(8, "p8.png");
            cardList.Images.SetKeyName(9, "p9.png");
            cardList.Images.SetKeyName(10, "p10.png");
            cardList.Images.SetKeyName(11, "p11.png");
            cardList.Images.SetKeyName(12, "p12.png");
            cardList.Images.SetKeyName(13, "p13.png");
            cardList.Images.SetKeyName(14, "p14.png");
            cardList.Images.SetKeyName(15, "p15.png");
            cardList.Images.SetKeyName(16, "p16.png");
            cardList.Images.SetKeyName(17, "p17.png");
            cardList.Images.SetKeyName(18, "p18.png");
            cardList.Images.SetKeyName(19, "p19.png");
            cardList.Images.SetKeyName(20, "p20.png");
            cardList.Images.SetKeyName(21, "p21.png");
            cardList.Images.SetKeyName(22, "p22.png");
            cardList.Images.SetKeyName(23, "p23.png");
            cardList.Images.SetKeyName(24, "p24.png");
            cardList.Images.SetKeyName(25, "p25.png");
            cardList.Images.SetKeyName(26, "p26.png");
            cardList.Images.SetKeyName(27, "p27.png");
            cardList.Images.SetKeyName(28, "p28.png");
            cardList.Images.SetKeyName(29, "p29.png");
            cardList.Images.SetKeyName(30, "p30.png");
            cardList.Images.SetKeyName(31, "p31.png");
            cardList.Images.SetKeyName(32, "p32.png");
            cardList.Images.SetKeyName(33, "p33.png");
            cardList.Images.SetKeyName(34, "p34.png");
            cardList.Images.SetKeyName(35, "p35.png");
            cardList.Images.SetKeyName(36, "p36.png");
            cardList.Images.SetKeyName(37, "p37.png");
            cardList.Images.SetKeyName(38, "p38.png");
            cardList.Images.SetKeyName(39, "p39.png");
            cardList.Images.SetKeyName(40, "p40.png");
            cardList.Images.SetKeyName(41, "p41.png");
            cardList.Images.SetKeyName(42, "p42.png");
            cardList.Images.SetKeyName(43, "p43.png");
            cardList.Images.SetKeyName(44, "p44.png");
            cardList.Images.SetKeyName(45, "p45.png");
            cardList.Images.SetKeyName(46, "p46.png");
            cardList.Images.SetKeyName(47, "p47.png");
            cardList.Images.SetKeyName(48, "p48.png");
            cardList.Images.SetKeyName(49, "p49.png");
            cardList.Images.SetKeyName(50, "p50.png");
            cardList.Images.SetKeyName(51, "p51.png");
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 522);
            Controls.Add(cardFive);
            Controls.Add(cardFour);
            Controls.Add(cardThree);
            Controls.Add(cardTwo);
            Controls.Add(cardOne);
            Controls.Add(keepBoxFive);
            Controls.Add(keepBoxFour);
            Controls.Add(keepBoxThree);
            Controls.Add(keepBoxTwo);
            Controls.Add(keepBoxOne);
            Controls.Add(loadButton);
            Controls.Add(saveButton);
            Controls.Add(dealButton);
            MaximizeBox = false;
            MaximumSize = new Size(1070, 578);
            MinimumSize = new Size(1070, 578);
            Name = "MainForm";
            Text = "Poker Hand Simulator";
            Load += PokerHand_Load;
            ((System.ComponentModel.ISupportInitialize)cardOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardThree).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardFour).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardFive).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button dealButton;
        private Button saveButton;
        private Button loadButton;
        private CheckBox keepBoxOne;
        private CheckBox keepBoxTwo;
        private CheckBox keepBoxThree;
        private CheckBox keepBoxFour;
        private CheckBox keepBoxFive;
        private PictureBox cardOne;
        private PictureBox cardTwo;
        private PictureBox cardThree;
        private PictureBox cardFour;
        private PictureBox cardFive;
        private ImageList cardList;
    }
}
