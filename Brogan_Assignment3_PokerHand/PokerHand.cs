namespace Brogan_Assignment3_PokerHand
{
    public partial class MainForm : Form
    {
        private Image[] hand = new Image[5];
        private int[] savedHand = new int[5];
        private ImageList deckCopy = new ImageList();
        private int[] recordedIndex = new int[52];
        private Random randomInt = new Random();
        private int dealerIndex = 52;

        public MainForm()
        {
            InitializeComponent();
            for(int i = 0; i < 52; i++)
            {
                recordedIndex[i] = i;
            }
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
                int handTemp = recordedIndex[x];
                deckCopy.Images[x] = deckCopy.Images[y];
                recordedIndex[x] = recordedIndex[y];
                deckCopy.Images[y] = temp;
                recordedIndex[y] = handTemp;

            }
        }

        private void dealHand()
        {
            if (!keepBoxOne.Checked && dealerIndex < 52)
            {
                savedHand[0] = recordedIndex[dealerIndex];
                cardOne.Image = deckCopy.Images[dealerIndex++];
                hand[0] = cardOne.Image;
            }
            if (!keepBoxTwo.Checked && dealerIndex < 52)
            {
                savedHand[1] = recordedIndex[dealerIndex];
                cardTwo.Image = deckCopy.Images[dealerIndex++];
                hand[1] = cardTwo.Image;
            }
            if (!keepBoxThree.Checked && dealerIndex < 52)
            {
                savedHand[2] = recordedIndex[dealerIndex];
                cardThree.Image = deckCopy.Images[dealerIndex++];
                hand[2] = cardThree.Image;
            }
            if (!keepBoxFour.Checked && dealerIndex < 52)
            {
                savedHand[3] = recordedIndex[dealerIndex];
                cardFour.Image = deckCopy.Images[dealerIndex++];
                hand[3] = cardFour.Image;

            }
            if (!keepBoxFive.Checked && dealerIndex < 52)
            {
                savedHand[4] = recordedIndex[dealerIndex];
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
                string filePath = save.FileName; // ✅ Use the full path including filename

                // Build the content from savedHand
                string content = string.Join(Environment.NewLine, savedHand.Select(card => card.ToString()));

                // Write text to the file
                File.WriteAllText(filePath, content);

                MessageBox.Show("Poker hand saved to:\n" + filePath, "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog
            {
                DefaultExt = "txt",
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                InitialDirectory = @"C:\Users\trist\source\repos\Brogan_Assignment3_PokerHand\Brogan_Assignment3_PokerHand\SavedHands\",
                Title = "Open Poker Hand"
            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                string filePath = open.FileName;

                try
                {
                    string content = File.ReadAllText(filePath);
                    MessageBox.Show("Loaded content:\n" + content, "File Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string[] lines = File.ReadAllLines(filePath);

                    foreach (string line in lines)
                    {
                        int index = int.Parse(line);
                        hand[index] = deckCopy.Images[index];
                        recordedIndex[index] = index;
                    }
                    dealerIndex = 52;
                    cardOne.Image = hand[0];
                    cardTwo.Image = hand[1];
                    cardThree.Image = hand[2];
                    cardFour.Image = hand[3];
                    cardFive.Image = hand[4];  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading file:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//
                }
            }

        }
    }
}
