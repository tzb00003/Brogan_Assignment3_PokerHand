namespace Brogan_Assignment3_PokerHand
{
    public partial class MainForm : Form
    {
        private Image[] hand = new Image[5];
        private ImageList deckCopy = new ImageList();
        private Random randomInt = new Random();
        private int dealerIndex = 52;

        public MainForm()
        {
            InitializeComponent();
            shuffleHand();
            dealHand();
        }

        private void PokerHand_Load(object sender, EventArgs e)
        {

        }

        private void dealButton_Click(object sender, EventArgs e)
        {
            if (dealerIndex >= 52)
            {
                shuffleHand();
            }
            dealHand();
        }

        private void shuffleHand()
        {
            dealerIndex = 0;
            deckCopy = cardList;
            for (int i = 0; i <= 100; i++)
            {
                int x = randomInt.Next(52);
                int y = randomInt.Next(52);
                Image temp = deckCopy.Images[x];
                deckCopy.Images[x] = deckCopy.Images[y];
                deckCopy.Images[y] = temp;

            }
        }

        private void dealHand()
        {
            if (!keepBoxOne.Checked && dealerIndex < 52)
            {
                cardOne.Image = deckCopy.Images[dealerIndex++];
                hand[0] = cardOne.Image;
            }
            if (!keepBoxTwo.Checked && dealerIndex < 52)
            {
                cardTwo.Image = deckCopy.Images[dealerIndex++];
                hand[1] = cardTwo.Image;
            }
            if (!keepBoxThree.Checked && dealerIndex < 52)
            {
                cardThree.Image = deckCopy.Images[dealerIndex++];
                hand[2] = cardThree.Image;
            }
            if (!keepBoxFour.Checked && dealerIndex < 52)
            {
                cardFour.Image = deckCopy.Images[dealerIndex++];
                hand[3] = cardFour.Image;

            }
            if (!keepBoxFive.Checked && dealerIndex < 52)
            {
                cardFive.Image = deckCopy.Images[dealerIndex++];
                hand[4] = cardFive.Image;
            }
            if (dealerIndex >= 52)
            {
                shuffleHand();
                MessageBox.Show("Deck is now empty. Re-shuffeling hand.");
                cardOne.Image = deckCopy.Images[dealerIndex++];
                hand[0] = cardOne.Image;
                cardTwo.Image = deckCopy.Images[dealerIndex++];
                hand[1] = cardTwo.Image;
                cardThree.Image = deckCopy.Images[dealerIndex++];
                hand[2] = cardThree.Image;
                cardFour.Image = deckCopy.Images[dealerIndex++];
                hand[3] = cardFour.Image;
                cardFive.Image = deckCopy.Images[dealerIndex++];
                hand[4] = cardFive.Image;
                keepBoxOne.Checked = false;
                keepBoxTwo.Checked = false;
                keepBoxThree.Checked = false;
                keepBoxFour.Checked = false;
                keepBoxFive.Checked = false;
            }

        }

        private void cardOne_Click(object sender, EventArgs e)
        {
            keepBoxOne.Checked = !keepBoxOne.Checked;
        }

        private void cardTwo_Click(object sender, EventArgs e)
        {
            keepBoxTwo.Checked = !keepBoxTwo.Checked;
        }

        private void cardThree_Click(object sender, EventArgs e)
        {
            keepBoxThree.Checked = !keepBoxThree.Checked;
        }

        private void cardFour_Click(object sender, EventArgs e)
        {
            keepBoxFour.Checked = !keepBoxFour.Checked;
        }

        private void cardFive_Click(object sender, EventArgs e)
        {
            keepBoxFive.Checked = !keepBoxFive.Checked;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog
            {
                DefaultExt = "txt",
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                InitialDirectory = @"C:\Users\trist\source\repos\Brogan_Assignment3_PokerHand\Brogan_Assignment3_PokerHand\SavedHands\",
                Title = "Save Poker Hand",
                FileName = "PokerHand" // Default file name
            };

            if (save.ShowDialog() == DialogResult.OK)
            {
                string basePath = Path.GetDirectoryName(save.FileName);
                string baseFileName = Path.GetFileNameWithoutExtension(save.FileName);

                for (int i = 0; i < hand.Length; i++)
                {
                    if (hand[i] != null)
                    {
                        string imagePath = Path.Combine(basePath, $"{baseFileName}_Card{i + 1}.png");
                        hand[i].Save(imagePath, System.Drawing.Imaging.ImageFormat.Png);
                    }
                }

                MessageBox.Show("Poker hand saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {

        }
    }
}
