﻿using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Snake
{
    public static class Images
    {
        public readonly static ImageSource Empty = LoadImage("Empty.png");
        public readonly static ImageSource Body = LoadImage("Body.png");
        public readonly static ImageSource Head = LoadImage("Head.png");
        public readonly static ImageSource Food = LoadImage("C:\\Users\\22002545CTC\\source\\repos\\Snake\\Snake\\Assets\\Food.png");
        public readonly static ImageSource DeadBody = LoadImage("DeadBody.png");
        public readonly static ImageSource DeadHead = LoadImage("DeadHead.png");
        private static ImageSource LoadImage(string filename)   
        {
            return new BitmapImage(new Uri($"Assets/{filename}",
                UriKind.Relative));
        }
    }
}
