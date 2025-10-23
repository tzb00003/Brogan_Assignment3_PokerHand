namespace Brogan_Assignment3_PokerHand
{
    public partial class MainForm : Form
    {
        private Image[] hand = new Image[5];
        private int[] savedHand = new int[5];
        private ImageList deckCopy = new ImageList();
        private List<int> recordedIndex = new List<int>();
        private Random randomInt = new Random();
        private int dealerIndex = 52;

        public MainForm()
        {
            InitializeComponent();
            for (int i = 0; i < 52; i++)
            {
                recordedIndex.Add(i);
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
                keepBoxFive.Checked = false;
                keepBoxFour.Checked = false;
                keepBoxThree.Checked = false;
                keepBoxTwo.Checked = false;
                keepBoxOne.Checked = false;
                shuffleHand();
            }
            dealHand();
        }

        private void shuffleHand()
        {
            for (int i = 0; i < 52; i++)
            {
                recordedIndex[i] = i;
            }
            dealerIndex = 0;
            deckCopy = new ImageList();

            deckCopy.ImageSize = cardList.ImageSize;
            deckCopy.ColorDepth = cardList.ColorDepth; 

            foreach (Image img in cardList.Images)
            {
                deckCopy.Images.Add((Image)img.Clone());
            }

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
                FileName = "PokerHand"
            };

            if (save.ShowDialog() == DialogResult.OK)
            {
                string filePath = save.FileName;
                string content = string.Join(Environment.NewLine, savedHand.Select(card => card.ToString()));
                File.WriteAllText(filePath, content);
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
                    string[] lines = File.ReadAllLines(filePath);

                    hand[0] = cardList.Images[int.Parse(lines[0])];
                    hand[1] = cardList.Images[int.Parse(lines[1])];
                    hand[2] = cardList.Images[int.Parse(lines[2])];
                    hand[3] = cardList.Images[int.Parse(lines[3])];
                    hand[4] = cardList.Images[int.Parse(lines[4])];
                    cardOne.Image = cardList.Images[int.Parse(lines[0])];
                    cardTwo.Image = cardList.Images[int.Parse(lines[1])];
                    cardThree.Image = cardList.Images[int.Parse(lines[2])];
                    cardFour.Image = cardList.Images[int.Parse(lines[3])];
                    cardFive.Image = cardList.Images[int.Parse(lines[4])];

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading file:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//
                }
                finally
                {
                    dealerIndex = 53;
                }
            }
        }
    }
}
