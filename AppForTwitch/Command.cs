using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForTwitch
{
    class Command
    {
        private string keyWord;
        private string text;
        private bool requestor = false;
        private bool randomNumber = false;
        private int minNumber = 0;
        private int maxNumber = 0;

        public string KeyWord { get => keyWord; set => keyWord = value; }
        public string Text { get => text; set => text = value; }
        public bool Requestor { get => requestor; set => requestor = value; }
        public bool RandomNumber { get => randomNumber; set => randomNumber = value; }
        public int MinNumber { get => minNumber; set => minNumber = value; }
        public int MaxNumber { get => maxNumber; set => maxNumber = value; }
    }
}
