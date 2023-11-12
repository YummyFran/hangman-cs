using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman.Forms
{
    public partial class WordGameMode : Form
    {
        private string secretWord;
        private int attemptsLeft;
        private static String currPath = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
        private String imagePath = Path.Combine(currPath, "..\\..\\..\\assets");
        private String[] images = { "bitay0.png", "bitay1.png", "bitay2.png", "bitay3.png", "bitay4.png", "bitay5.png", "bitay6.png" };
        public WordGameMode()
        {
            InitializeComponent();
        }

        private void WordGameMode_Load(object sender, EventArgs e)
        {
            this.startGame();
        }

        private void startGame()
        {
            string[] words = { "able", "about", "account", "acid", "across", "act", "addition", "adjustment", "advertisement", "after", "again", "against", "agreement", "air", "all", "almost", "among", "amount", "amusement", "and", "angle", "angry", "animal", "answer", "ant", "any", "apparatus", "apple", "approval", "arch", "argument", "arm", "army", "art", "as", "at", "attack", "attempt", "attention", "attraction", "authority", "automatic", "awake", "baby", "back", "bad", "bag", "balance", "ball", "band", "base", "basin", "basket", "bath", "be", "beautiful", "because", "bed", "bee", "before", "behaviour", "belief", "bell", "bent", "berry", "between", "bird", "birth", "bit", "bite", "bitter", "black", "blade", "blood", "blow", "blue", "board", "boat", "body", "boiling", "bone", "book", "boot", "bottle", "box", "boy", "brain", "brake", "branch", "brass", "bread", "breath", "brick", "bridge", "bright", "broken", "brother", "brown", "brush", "bucket", "building", "bulb", "burn", "burst", "business", "but", "butter", "button", "by", "cake", "camera", "canvas", "card", "care", "carriage", "cart", "cat", "cause", "certain", "chain", "chalk", "chance", "change", "cheap", "cheese", "chemical", "chest", "chief", "chin", "church", "circle", "clean", "clear", "clock", "cloth", "cloud", "coal", "coat", "cold", "collar", "colour", "comb", "come", "comfort", "committee", "common", "company", "comparison", "competition", "complete", "complex", "condition", "connection", "conscious", "control", "cook", "copper", "copy", "cord", "cork", "cotton", "cough", "country", "cover", "cow", "crack", "credit", "crime", "cruel", "crush", "cry", "cup", "cup", "current", "curtain", "curve", "cushion", "damage", "danger", "dark", "daughter", "day", "dead", "dear", "death", "debt", "decision", "deep", "degree", "delicate", "dependent", "design", "desire", "destruction", "detail", "development", "different", "digestion", "direction", "dirty", "discovery", "discussion", "disease", "disgust", "distance", "distribution", "division", "do", "dog", "door", "doubt", "down", "drain", "drawer", "dress", "drink", "driving", "drop", "dry", "dust", "ear", "early", "earth", "east", "edge", "education", "effect", "egg", "elastic", "electric", "end", "engine", "enough", "equal", "error", "even", "event", "ever", "every", "example", "exchange", "existence", "expansion", "experience", "expert", "eye", "face", "fact", "fall", "false", "family", "far", "farm", "fat", "father", "fear", "feather", "feeble", "feeling", "female", "fertile", "fiction", "field", "fight", "finger", "fire", "first", "fish", "fixed", "flag", "flame", "flat", "flight", "floor", "flower", "fly", "fold", "food", "foolish", "foot", "for", "force", "fork", "form", "forward", "fowl", "frame", "free", "frequent", "friend", "from", "front", "fruit", "full", "future", "garden", "general", "get", "girl", "give", "glass", "glove", "go", "goat", "gold", "good", "government", "grain", "grass", "great", "green", "grey", "grip", "group", "growth", "guide", "gun", "hair", "hammer", "hand", "hanging", "happy", "harbour", "hard", "harmony", "hat", "hate", "have", "he", "head", "healthy", "hear", "hearing", "heart", "heat", "help", "high", "history", "hole", "hollow", "hook", "hope", "horn", "horse", "hospital", "hour", "house", "how", "humour", "I", "ice", "idea", "if", "ill", "important", "impulse", "in", "increase", "industry", "ink", "insect", "instrument", "insurance", "interest", "invention", "iron", "island", "jelly", "jewel", "join", "journey", "judge", "jump", "keep", "kettle", "key", "kick", "kind", "kiss", "knee", "knife", "knot", "knowledge", "land", "language", "last", "late", "laugh", "law", "lead", "leaf", "learning", "leather", "left", "leg", "let", "letter", "level", "library", "lift", "light", "like", "limit", "line", "linen", "lip", "liquid", "list", "little", "living", "lock", "long", "look", "loose", "loss", "loud", "love", "low", "machine", "make", "male", "man", "manager", "map", "mark", "market", "married", "mass", "match", "material", "may", "meal", "measure", "meat", "medical", "meeting", "memory", "metal", "middle", "military", "milk", "mind", "mine", "minute", "mist", "mixed", "money", "monkey", "month", "moon", "morning", "mother", "motion", "mountain", "mouth", "move", "much", "muscle", "music", "nail", "name", "narrow", "nation", "natural", "near", "necessary", "neck", "need", "needle", "nerve", "net", "new", "news", "night", "no", "noise", "normal", "north", "nose", "not", "note", "now", "number", "nut", "observation", "of", "off", "offer", "office", "oil", "old", "on", "only", "open", "operation", "opinion", "opposite", "or", "orange", "order", "organization", "ornament", "other", "out", "oven", "over", "owner", "page", "pain", "paint", "paper", "parallel", "parcel", "part", "past", "paste", "payment", "peace", "pen", "pencil", "person", "physical", "picture", "pig", "pin", "pipe", "place", "plane", "plant", "plate", "play", "please", "pleasure", "plough", "pocket", "point", "poison", "polish", "political", "poor", "porter", "position", "possible", "pot", "potato", "powder", "power", "present", "price", "print", "prison", "private", "probable", "process", "produce", "profit", "property", "prose", "protest", "public", "pull", "pump", "punishment", "purpose", "push", "put", "quality", "question", "quick", "quiet", "quite", "rail", "rain", "range", "rat", "rate", "ray", "reaction", "reading", "ready", "reason", "receipt", "record", "red", "regret", "regular", "relation", "religion", "representative", "request", "respect", "responsible", "rest", "reward", "rhythm", "rice", "right", "ring", "river", "road", "rod", "roll", "roof", "room", "root", "rough", "round", "rub", "rule", "run", "sad", "safe", "sail", "salt", "same", "sand", "say", "scale", "school", "science", "scissors", "screw", "sea", "seat", "second", "secret", "secretary", "see", "seed", "seem", "selection", "self", "send", "sense", "separate", "serious", "servant", "sex", "shade", "shake", "shame", "sharp", "sheep", "shelf", "ship", "shirt", "shock", "shoe", "short", "shut", "side", "sign", "silk", "silver", "simple", "sister", "size", "skin", "", "skirt", "sky", "sleep", "slip", "slope", "slow", "small", "smash", "smell", "smile", "smoke", "smooth", "snake", "sneeze", "snow", "so", "soap", "society", "sock", "soft", "solid", "some", "", "son", "song", "sort", "sound", "soup", "south", "space", "spade", "special", "sponge", "spoon", "spring", "square", "stage", "stamp", "star", "start", "statement", "station", "steam", "steel", "stem", "step", "stick", "sticky", "stiff", "still", "stitch", "stocking", "stomach", "stone", "stop", "store", "story", "straight", "strange", "street", "stretch", "strong", "structure", "substance", "such", "sudden", "sugar", "suggestion", "summer", "sun", "support", "surprise", "sweet", "swim", "system", "table", "tail", "take", "talk", "tall", "taste", "tax", "teaching", "tendency", "test", "than", "that", "the", "then", "theory", "there", "thick", "thin", "thing", "this", "thought", "thread", "throat", "through", "through", "thumb", "thunder", "ticket", "tight", "till", "time", "tin", "tired", "to", "toe", "together", "tomorrow", "tongue", "tooth", "top", "touch", "town", "trade", "train", "transport", "tray", "tree", "trick", "trouble", "trousers", "true", "turn", "twist", "umbrella", "under", "unit", "up", "use", "value", "verse", "very", "vessel", "view", "violent", "voice", "waiting", "walk", "wall", "war", "warm", "wash", "waste", "watch", "water", "wave", "wax", "way", "weather", "week", "weight", "well", "west", "wet", "wheel", "when", "where", "while", "whip", "whistle", "white", "who", "why", "wide", "will", "wind", "window", "wine", "wing", "winter", "wire", "wise", "with", "woman", "wood", "wool", "word", "work", "worm", "wound", "writing", "wrong", "year", "yellow", "yes", "yesterday", "you", "young", "Bernhard", "Breytenbach", "Android" };
            //string[] words = { "kaith", "clyde", "justine", "yummy" };
            Random random = new Random();
            secretWord = words[random.Next(words.Length)];
            //secretWord = words[random];
            attemptsLeft = 6;

            secretLbl.Text = GetSecretWord();
            bitay.ImageLocation = Path.Combine(imagePath, images[0]);

            foreach (Control btn in keyboard.Controls)
            {
                btn.Enabled = true;
                btn.BackColor = ColorTranslator.FromHtml("#212A3E");
            }
        }

        private string GetSecretWord()
        {
            string secret = "";
            foreach (char c in secretWord)
            {
                secret += "_ ";
            }
            return secret;
        }

        private void playerMoved(char letter, object button)
        {
            bool found = false;

            Button clickedButton = (Button)button;
            clickedButton.Enabled = false;
            clickedButton.BackColor = ColorTranslator.FromHtml("#394867");

            for (int i = 0; i < secretWord.Length; i++)
            {
                if (secretWord[i] == letter)
                {
                    found = true;
                    secretLbl.Text = secretLbl.Text.Substring(0, i * 2) + letter + " " + secretLbl.Text.Substring(i * 2 + 2);
                }
            }
            if (!found)
            {
                attemptsLeft--;
                bitay.ImageLocation = Path.Combine(imagePath, images[6 - attemptsLeft]);
            }

            if (secretLbl.Text.IndexOf("_") == -1)
            {
                MessageBox.Show("You win!");
                this.startGame();
            }
            else if (attemptsLeft == 0)
            {
                MessageBox.Show($"You lose! The secret word was \"{secretWord}\".");
                this.startGame();
            }
        }

        private void a_Click(object sender, EventArgs e)
        {
            playerMoved('a', sender);
        }

        private void b_Click(object sender, EventArgs e)
        {
            playerMoved('b', sender);
        }

        private void c_Click(object sender, EventArgs e)
        {
            playerMoved('c', sender);
        }

        private void d_Click(object sender, EventArgs e)
        {
            playerMoved('d', sender);
        }

        private void e_Click(object sender, EventArgs e)
        {
            playerMoved('e', sender);
        }

        private void f_Click(object sender, EventArgs e)
        {
            playerMoved('f', sender);
        }

        private void g_Click(object sender, EventArgs e)
        {
            playerMoved('g', sender);
        }

        private void h_Click(object sender, EventArgs e)
        {
            playerMoved('h', sender);
        }

        private void i_Click(object sender, EventArgs e)
        {
            playerMoved('i', sender);
        }

        private void j_Click(object sender, EventArgs e)
        {
            playerMoved('j', sender);
        }

        private void k_Click(object sender, EventArgs e)
        {
            playerMoved('k', sender);
        }

        private void l_Click(object sender, EventArgs e)
        {
            playerMoved('l', sender);
        }

        private void m_Click(object sender, EventArgs e)
        {
            playerMoved('m', sender);
        }

        private void n_Click(object sender, EventArgs e)
        {
            playerMoved('n', sender);
        }

        private void o_Click(object sender, EventArgs e)
        {
            playerMoved('o', sender);
        }

        private void p_Click(object sender, EventArgs e)
        {
            playerMoved('p', sender);
        }

        private void q_Click(object sender, EventArgs e)
        {
            playerMoved('q', sender);
        }

        private void r_Click(object sender, EventArgs e)
        {
            playerMoved('r', sender);
        }

        private void s_Click(object sender, EventArgs e)
        {
            playerMoved('s', sender);
        }

        private void t_Click(object sender, EventArgs e)
        {
            playerMoved('t', sender);
        }

        private void u_Click(object sender, EventArgs e)
        {
            playerMoved('u', sender);
        }

        private void v_Click(object sender, EventArgs e)
        {
            playerMoved('v', sender);
        }

        private void w_Click(object sender, EventArgs e)
        {
            playerMoved('w', sender);
        }

        private void x_Click(object sender, EventArgs e)
        {
            playerMoved('x', sender);
        }

        private void y_Click(object sender, EventArgs e)
        {
            playerMoved('y', sender);
        }

        private void z_Click(object sender, EventArgs e)
        {
            playerMoved('z', sender);
        }

        private void WordGameMode_SizeChanged(object sender, EventArgs e)
        {
            bitay.SizeMode = PictureBoxSizeMode.Zoom;
            bitay.Height = ClientSize.Height / 3;
        }
    }
}
