namespace SewersApp3
{

    public partial class Form1 : Form
    {
        // -- Global variables --

        const int BoardX = 13;
        const int BoardY = 7;
        static Tile[,] TileBoard = new Tile[BoardX, BoardY];
        bool shopOpen = true;

        // -- Images

        static Image blank = Image.FromFile("blank.png");
        static Image house = Image.FromFile("house1.png");
        static Image obama = Image.FromFile("obama.png");
        static Image trump = Image.FromFile("trump.png");

        static Image circle = Image.FromFile("redcircle.png");

        // -- Tiles

        static TileDefinition emptyTile = new TileDefinition("Blank", blank, [false, false, false, false]);
        static TileDefinition lightroomsTile = new TileDefinition("Lightrooms", house, [true, true, true, true]);
        static TileDefinition trumpTile = new TileDefinition("Trump", trump, [true, false, true, false]);
        static TileDefinition obamaTile = new TileDefinition("Obama", obama, [false, true, false, true]);
        static TileDefinition AvailableTile = new TileDefinition("Available", circle, [false, false, false, false]);
        static TileDefinition SelectedTile = emptyTile;
        static int SelectedRotation = 0;

        static List<TileDefinition> TileList = new List<TileDefinition>
        ([
            lightroomsTile, obamaTile, trumpTile
        ]);

        // -- Classes

        class TileDefinition
        {
            public Image image;
            public string name;
            public bool[] directions = new bool[4];
            public TileDefinition(string nameIn, Image imagein, bool[] boolIn)
            {
                this.name = nameIn;
                this.image = imagein;
                this.directions = boolIn;
            }
        }

        class Tile
        {
            public TileDefinition defintion;
            public int xPos, yPos, rotation;
            public PictureBox picture;
            public Panel panel;
            public Tile(int x, int y, TileDefinition defintionIn, int rotationIn, Panel PanelBoard)
            {
                this.defintion = defintionIn;
                this.xPos = x;
                this.yPos = y;
                this.rotation = rotationIn;
                this.panel = PanelBoard;

                PictureBox p = new PictureBox();
                p.Image = defintion.image;
                int pictureX = PanelBoard.Width / BoardX;
                p.Location = new Point(pictureX * x, pictureX * y);
                p.Size = new Size(pictureX, pictureX);
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.Click += buy!;
                this.panel.Controls.Add(p);
                this.picture = p;
            }
            public void buy(object sender, EventArgs e)
            {
                if (SelectedTile != emptyTile && this.defintion == AvailableTile)
                {
                    this.update(SelectedTile);
                    this.rotation = SelectedRotation;

                    /*
                    PictureBox p = new PictureBox();
                    p.Image = circle;
                    int pictureX = this.panel.Width / BoardX;
                    p.Location = new Point(this.xPos * pictureX+12, this.yPos * pictureX+52);
                    p.Size = new Size(50, 50);
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                    p.Click += buy2!;
                    this.panel.Controls.Add(p);
                    p.BringToFront();

                    void buy2(object sender, EventArgs e)
                    {
                        this.update(SelectedTile);
                        ((PictureBox)sender).Dispose();
                        ((PictureBox)sender).Hide();
                    }*/ //Freakyk picture code ):

                }

                foreach (Tile i in TileBoard)
                {
                    if (i.defintion == AvailableTile)
                    {
                        i.update(emptyTile);
                    }
                }
            }

            public void update(TileDefinition newTile)
            {
                this.defintion = newTile;
                this.picture.Image = newTile.image;
            }
        }

        // -- Functions

        void PopulateTiles()
        {
            for (int i = 0; i < BoardX; i++)
            {
                for (int j = 0; j < BoardY; j++)
                {
                    if (i == 6 && j == 3)
                    {
                        TileBoard[i, j] = new Tile(i, j, lightroomsTile, 0, PanelBoard);
                    }
                    else
                    {
                        TileBoard[i, j] = new Tile(i, j, emptyTile, 0, PanelBoard);
                    }
                }
            }



        }

        void PopulateShopPictures()
        {
            int y = 0;
            foreach (TileDefinition i in TileList)
            {
                PictureBox p = new PictureBox();
                p.Image = i.image;
                p.Location = new Point(0, y * 110);
                p.Size = new Size(100, 100);
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.Click += SelectShopPicture!;
                ShopPanel.Controls.Add(p);
                y++;
            }
        }

        void SelectShopPicture(object sender, EventArgs e)
        {
            SelectedTile = TileList[(((PictureBox)sender).Location.Y / 100)];
            label1.Text = "Selected tile: " + TileList[(((PictureBox)sender).Location.Y / 100)].name;
            SelectedPicture.Image = SelectedTile.image;
            SelectedPicture.SizeMode = PictureBoxSizeMode.StretchImage;

            /*
            foreach (Tile i in TileBoard)
            {
                // If this tile has a north connection, and if the tile above it is empty:
                try
                {
                    if (i.defintion.directions[0] && TileBoard[i.xPos, i.yPos - 1].defintion == emptyTile) { TileBoard[i.xPos, i.yPos - 1].update(AvailableTile); }
                    if (i.defintion.directions[1] && TileBoard[i.xPos + 1, i.yPos].defintion == emptyTile) { TileBoard[i.xPos + 1, i.yPos].update(AvailableTile); }
                    if (i.defintion.directions[2] && TileBoard[i.xPos, i.yPos + 1].defintion == emptyTile) { TileBoard[i.xPos, i.yPos + 1].update(AvailableTile); }
                    if (i.defintion.directions[3] && TileBoard[i.xPos - 1, i.yPos].defintion == emptyTile) { TileBoard[i.xPos - 1, i.yPos].update(AvailableTile); }

                }
                catch (System.IndexOutOfRangeException) { }
            }
            */
            
            UpdateAvailableTiles();
        }

        void UpdateAvailableTiles()
        {
            foreach (Tile i in TileBoard)
            {
                if (i.defintion == AvailableTile)
                {
                    i.update(emptyTile);
                }
            }

            // Code to highlight available tiles
            foreach (Tile i in TileBoard)
            {
                if (i.defintion != emptyTile && i.defintion != AvailableTile)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (i.defintion.directions[j] && IsNextTileEmpty(j, i)) { SetNextTileAvailable(j, i); };
                    }
                }

            }

            static bool IsNextTileEmpty(int direction, Tile i)
            {
                switch ((direction + i.rotation) % 4)
                {
                    case 0: if (i.yPos - 1 >= 0     && TileBoard[i.xPos, i.yPos - 1].defintion == emptyTile && SelectedTile.directions[(2 + SelectedRotation) % 4]) { return true; } else { return false; };
                    case 1: if (i.xPos + 1 < BoardX && TileBoard[i.xPos + 1, i.yPos].defintion == emptyTile && SelectedTile.directions[(3 + SelectedRotation) % 4]) { return true; } else { return false; };
                    case 2: if (i.yPos + 1 < BoardY && TileBoard[i.xPos, i.yPos + 1].defintion == emptyTile && SelectedTile.directions[(0 + SelectedRotation) % 4]) { return true; } else { return false; };
                    case 3: if (i.xPos - 1 >= 0     && TileBoard[i.xPos - 1, i.yPos].defintion == emptyTile && SelectedTile.directions[(1 + SelectedRotation) % 4]) { return true; } else { return false; };
                }
                return false;
            }

            static void SetNextTileAvailable(int direction, Tile i)
            {
                switch ((direction + i.rotation) % 4)
                {
                    case 0: TileBoard[i.xPos, i.yPos - 1].update(AvailableTile); break;
                    case 1: TileBoard[i.xPos + 1, i.yPos].update(AvailableTile); break;
                    case 2: TileBoard[i.xPos, i.yPos + 1].update(AvailableTile); break;
                    case 3: TileBoard[i.xPos - 1, i.yPos].update(AvailableTile); break;
                }
            }
        }

        void ToggleShopPictures(object sender, EventArgs e)
        {

            if (shopOpen)
            {
                for (int i = 0; i > -100; i -= 10)
                {
                    ShopPanel.Location = new Point(i, 204);
                    Thread.Sleep(10);
                }
                ShopDebug.Text = "Shop closed";
                shopOpen = false;
            }
            else
            {
                ShopPanel.Location = new Point(0, 204);
                ShopDebug.Text = "Shop open";
                shopOpen = true;
            }




        }
        public Form1()
        {
            InitializeComponent();

            PopulateTiles();

            PopulateShopPictures();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // -- Click events
        private void ShopDebug_Click(object sender, EventArgs e)
        {
            ToggleShopPictures(sender, e);
        }

        private void SelectLeft_Click(object sender, EventArgs e)
        {
            SelectedRotation--;
            if (SelectedRotation == -1) { SelectedRotation = 3; }
            SelectedPicture.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            SelectedPicture.Image = SelectedTile.image;
            UpdateAvailableTiles();
        }

        private void SelectRight_Click(object sender, EventArgs e)
        {
            SelectedRotation++;
            if (SelectedRotation == 4) { SelectedRotation = 0; }
            SelectedPicture.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            SelectedPicture.Image = SelectedTile.image;
            UpdateAvailableTiles();
        }
    }
}




