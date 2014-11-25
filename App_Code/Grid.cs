namespace Simplismo
{
    public static class Grid
    {
        static Grid()
        {
            container = "container";
            row = "row";
            col = "col";
            offset = "offset";

            xs = "xs";
            sm = "s";
            md = "m";
            lg = "l";
        }
        
        private static string container;
        public static string Container
        {
            get { return container; }
            private set { container = value; }
        }

        private static string row;
        public static string Row
        {
            get { return row; }
            private set { row = value; }
        }

        private static string col;
        public static string Col
        {
            get { return col; }
            private set { col = value; }
        }

        private static string offset;
        public static string Offset
        {
            get { return offset; }
            private set { offset = value; }
        }

        //public string ColPrefix
        //{
        //    get { return colPrefix; }
        //    private set { colPrefix = value; }
        //}

        private static string xs;
        private static string sm;
        private static string md;
        private static string lg;

        public static string Xs
        {
            get { return xs; }
            private set { xs = value; }
        }

        public static string Sm
        {
            get { return sm; }
            private set { sm = value; }
        }

        public static string Md
        {
            get { return md; }
            private set { md = value; }
        }

        public static string Lg
        {
            get { return lg; }
            private set { lg = value; }
        }

        public static string Cols(string deviceWidth, int cols)
        {
            return col + "-" + deviceWidth + "-" + cols.ToString();
        }

        public static string Off(string deviceWidth, int cols)
        {
            return offset + "-" + deviceWidth + "-" + cols.ToString();
        }

        public static int ColsPerItem(int itemsPerRow)
        {
            if (itemsPerRow> 0 && itemsPerRow <= 12)
            {
                return ((int)(12 / itemsPerRow));
            }
            else
            {
                return 12;
            }
        }

    }
}