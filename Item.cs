﻿using System;
using System.Reflection;

namespace Project_jUMPKING
{
    class Item
    {
        protected int posX, posY;
        protected bool _GetItem;
        protected string[][] sprite = new string[2][];
        protected int index;
        protected int time = 100;
        protected char _tempChar;
        protected char _Char;
        protected string _Text = "";

        public bool getItem
        {
            get { return _GetItem; }
            set { _GetItem = value; }
        }
        public int get_posX
        {
            get { return posX; }
            set {  posX = value; }
        }
        public int get_posY
        {
            get { return posY; }
        }
        public char get_Char
        {
            get { return _Char; }
        }
        public char get_tempChar
        {
            get { return _tempChar; }
        }

        public Item(int posX, int posY, char tempChar)
        {
            this.posX = posX;
            this.posY = posY;
            _GetItem = false;
            _tempChar = tempChar;
        }

        public void Set_posY(int posy)
        {
            posY = posy;
        }
        public virtual void Set_pos()
        {
        }
        public virtual void OnItem()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(posX - 2, posY - 2);
            Console.Write(sprite[0][0]);
            Console.SetCursorPosition(posX - 2, posY - 1);
            Console.Write(sprite[0][1]);
            Console.SetCursorPosition(posX - 2, posY);
            Console.Write(sprite[0][2]);
            Console.SetCursorPosition(posX - 2, posY + 1);
            Console.Write(sprite[0][3]);
            Console.SetCursorPosition(posX - 2, posY + 2);
            Console.Write(sprite[0][4]);

            Console.SetCursorPosition(posX - 3, posY - 5);
            Console.Write(_Text);
            Console.ResetColor();
        }

        public virtual void OffItem()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(posX - 2, posY - 2);
            Console.Write(sprite[0][0]);
            Console.SetCursorPosition(posX - 2, posY - 1);
            Console.Write(sprite[0][1]);
            Console.SetCursorPosition(posX - 2, posY);
            Console.Write(sprite[0][2]);
            Console.SetCursorPosition(posX - 2, posY + 1);
            Console.Write(sprite[0][3]);
            Console.SetCursorPosition(posX - 2, posY + 2);
            Console.Write(sprite[0][4]);

            Console.SetCursorPosition(posX -3, posY - 5);
            Console.Write(_Text);
            Console.ResetColor();
        }

        public virtual void PrintItem(int i)
        {
            if (_GetItem == true)
            {
                return;
            }
            time++;
            if (time > 50)
            {
                time += 1 + i;
                index++;
                index %= 2;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(posX - 2, posY - 2);
                Console.Write(sprite[index][0]);
                Console.SetCursorPosition(posX - 2, posY - 1);
                Console.Write(sprite[index][1]);
                Console.SetCursorPosition(posX - 2, posY);
                Console.Write(sprite[index][2]);
                Console.SetCursorPosition(posX - 2, posY + 1);
                Console.Write(sprite[index][3]);
                Console.SetCursorPosition(posX - 2, posY + 2);
                Console.Write(sprite[index][4]);
                time = 0;
                Console.ResetColor();
            }
        }
    }
    class SaveLoad : Item
    {
        public SaveLoad(int posX, int posY, char tempChar) : base(posX, posY, tempChar)
        {
            sprite[0] = sprite1;
            sprite[1] = sprite2;
            _Char = sprite[0][2][2];
        }

        public override void OnItem()
        {
        }
        public override void OffItem()
        {
        }
        public override void PrintItem(int i)
        {
            if (_GetItem == true)
            {
                return;
            }
            time++;
            if (time > 50)
            {
                time += 1 + i;
                index++;
                index %= 2;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(posX - 2, posY - 2);
                Console.Write(sprite[index][0]);
                Console.SetCursorPosition(posX - 2, posY - 1);
                Console.Write(sprite[index][1]);
                Console.SetCursorPosition(posX - 2, posY);
                Console.Write(sprite[index][2]);
                Console.SetCursorPosition(posX - 2, posY + 1);
                Console.Write(sprite[index][3]);
                Console.SetCursorPosition(posX - 2, posY + 2);
                Console.Write(sprite[index][4]);
                time = 0;
                Console.ResetColor();
            }
        }

        private readonly string[] sprite1 =
        {
        "*#*#*",
        "#SRS#",
        "*R0R*",
        "#SRS#",
        "*#*#*"
        };

        private readonly string[] sprite2 =
        {
        "#*#*#",
        "*RSR*",
        "#S0S#",
        "*RSR*",
        "#*#*#"
        };
    }

    class Further : Item
    {
        public Further(int posX, int posY, char tempChar) : base(posX, posY, tempChar)
        {
            sprite[0] = sprite1;
            sprite[1] = sprite2;
            _Char = '★';
            _Text = "Booster";
        }

        public override void Set_pos()
        {
            this.posX = 191;
            this.posY = 227;
        }

        private readonly string[] sprite1 =
        {
        "*#*#*",
        "#*1*#",
        "*111*",
        "#*1*#",
        "*#*#*"
        };

        private readonly string[] sprite2 =
        {
        "#*#*#",
        "*#1#*",
        "#111#",
        "*#1#*",
        "#*#*#"
        };
    }

    class Higher : Item
    {
        public Higher(int posX, int posY, char tempChar) : base(posX, posY, tempChar)
        {
            sprite[0] = sprite1;
            sprite[1] = sprite2;
            _Char = '☆';
            _Text = "Jumper";
        }

        public override void Set_pos()
        {
            this.posX = 202;
            this.posY = 227;
        }
        
        private readonly string[] sprite1 =
        {
        "*#*#*",
        "#*2*#",
        "*222*",
        "#*2*#",
        "*#*#*",
        };

        private readonly string[] sprite2 =
        {
        "#*#*#",
        "*#2#*",
        "#222#",
        "*#2#*",
        "#*#*#"
        };
    }

    class Longer : Item
    {
        public Longer(int posX, int posY, char tempChar) : base(posX, posY, tempChar)
        {
            sprite[0] = sprite1;
            sprite[1] = sprite2;
            _Char = '○';
            _Text = "Gravity";
        }

        public override void Set_pos()
        {
            this.posX = 213;
            this.posY = 227;
        }

        private readonly string[] sprite1 =
        {
        "*#*#*",
        "#*3*#",
        "*333*",
        "#*3*#",
        "*#*#*",
        };

        private readonly string[] sprite2 =
        {
        "#*#*#",
        "*#3#*",
        "#333#",
        "*#3#*",
        "#*#*#"
        };
    }
}
