using System;


namespace Game_Of_Life
{
    class Field {
        public Cell[,] FieldSize = new Cell[10,10];
        private Random randomNumberX = new Random();
        private Random randomNumberY = new Random();
        public void startGame()
        {
            // בצורה רנדומלית נבחרים 3 מקומות בלוח המשחק שבהם
            //       שלוש תאים יהיו כחולים ושלוש תאים אדומים  
            for (int i = 0; i < FieldSize.Length; i++)
            {
                for (int j = 0; i < FieldSize.Length; j++)
                {
                    FieldSize[i, j] = new Unoccupied();
                }

            }
            for(int i = 1; i<=3; i++)
            {
                FieldSize[randomNumberX, randomNumberY] = new Blue;
                
            }
            for (int i = 1; i <= 3; i++)
            {
                FieldSize[randomNumberX, randomNumberY] = new Red;

            }

        }
         public Boolean IsWin(Cell[,] FieldSize)
            {
                {
                    // בודק האם כל הלוח פנוי במידה וכן מנצח
                    for (int i = 0; i < FieldSize.Length; i++)
                    {
                        for (int j = 0; j < FieldSize.Length; i++)
                        {
                            if (FieldSize[i, j] != null)
                            {
                                return false;
                            }
                        }
                    }
                    return true;
                }
            }


    }
    class Cell {
        protected int neighbors = 0;
        protected int redNeighbors = 0;
        protected int blueNeighbors = 0;

        public virtual int FindNumOfNeighbors() {
            foreach (Cell cell in FieldSize)
            {
                // לבדוק את הבא אחריו זה שלפניו מעליו מתחתיו ובאלכסונים
                // ולבדוק כמה יש שכנים שהם לא פנויים ולשמור בתוך משתנה
            }
            return neighbors;
        }
    }
    class Red:Cell {
        public override int FindNumOfNeighbors() {
           
            foreach (Red red in FieldSize) {
               
                // לבדוק את הבא אחריו זה שלפניו מעליו מתחתיו ובאלכסונים
                // ולבדוק כמה יש שכנים שהם לא פנויים ולשמור בתוך משתנה
               
            }
            return neighbors;
        }
        public int FindNumOfRedNeighbors()
        {
            foreach (Red red in FieldSize)
            {
                // לבדוק את הבא אחריו זה שלפניו מעליו מתחתיו ובאלכסונים
               //           ולבדוק כמה יש שכנים אדומים ולשמור בתוך משתנה
            }
            return redNeighbors;
        }
        public Boolean isRedDies() {
            if (redNeighbors == 0 || neighbors <= 1 || neighbors >= 4) {
                //  אדום נהפך להיות תא פנוי 
                return true;
            }
            return false;
}
    }
    class Blue:Cell { 
        public int FindNumOfBlueNeighbors() {
            foreach (Blue blue in FieldSize)
            {
                //       ,לבדוק את הבא אחריו זה שלפניו מעליו מתחתיו ובאלכסונים
                //                 ולבדוק כמה יש שכנים כחולים ולשמור בתוך משתנה 
            }
            return blueNeighbors;
        }
        public int FindNumOfRedNeighbors() {
            foreach (Blue blue in FieldSize)
            {
                //      ,לבדוק את הבא אחריו זה שלפניו מעליו מתחתיו ובאלכסונים
                //                ולבדוק כמה יש שכנים אדומים ולשמור בתוך משתנה
            }
            return redNeighbors;
        }
        public Boolean isBlueDies() {
           if (blueNeighbors != 1 || redNeighbors == 0 || redNeighbors > 3 ) {
                //כחול נהפך להיות תא פנוי 
                return true;
            }
            return false;
            }
    }
    class Unoccupied:Cell {
        public override int FindNumOfNeighbors() {
            foreach (Unoccupied unoccuppied in FieldSize)
            {
                //   ,לבדוק את הבא אחריו זה שלפניו מעליו מתחתיו ובאלכסונים
                //    ולבדוק כמה יש שכנים שהם לא פנויים ולשמור בתוך משתנה 
            }
            return neighbors;
        }
        public Boolean isNewCellBorn() {
            if (neighbors == 3)
            {
                // מתחלף התא הפנוי באדום או כחול בהסתברות של 0.5
                return true;
            }
            return false;
            }
    }
    class Cells_Group
    {
     
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
