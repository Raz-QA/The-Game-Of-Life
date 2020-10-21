using System;

namespace Game_Of_Life
{
    class Field {
        private Array[,] FieldSize;
        private Array[,] FieldSize
        {
            get {return FieldSize; }
            set {FieldSize = value; }
        } 
    }
    class Cell {
        public void startGame() {
            // בצורה רנדומלית נבחרים 3 מקומות בלוח המשחק שבהם
            //        שלוש תאים יהיו כחולים ושלוש תאים אדומים  
        }

        public virtual int FindNumOfNeighbors() {
            foreach (Cell cell in Cells)
            {
                // לבדוק את הבא אחריו זה שלפניו מעליו מתחתיו ובאלכסונים
                // ולבדוק כמה יש שכנים שהם לא פנויים ולשמור בתוך משתנה
            }
        }
    }
    class Red:Cell {
        public override int FindNumOfNeighbors() {
            foreach (Red red in Cells) {
               // לבדוק את הבא אחריו זה שלפניו מעליו מתחתיו ובאלכסונים
               // ולבדוק כמה יש שכנים שהם לא פנויים ולשמור בתוך משתנה
            }
        }
        public override int FindNumOfRedNeighbors()
        {
            foreach (Red red in Cells)
            {
                // לבדוק את הבא אחריו זה שלפניו מעליו מתחתיו ובאלכסונים
               //           ולבדוק כמה יש שכנים אדומים ולשמור בתוך משתנה
            }
        }
        public Boolean isRedDies() { 
            if (//redNeighbors == 0 || neighbors <= 1 || neighbors >= 4) { אדום נהפך להיות תא פנוי }
     
}
    }
    class Blue:Cell {
        public int FindNumOfBlueNeighbors() {
            foreach (Blue blue in Cells)
            {
                //       ,לבדוק את הבא אחריו זה שלפניו מעליו מתחתיו ובאלכסונים
                //                 ולבדוק כמה יש שכנים כחולים ולשמור בתוך משתנה 
        }
        public int FindNumOfRedNeighbors() {
            foreach (Blue blue in Cells)
            {
                //      ,לבדוק את הבא אחריו זה שלפניו מעליו מתחתיו ובאלכסונים
                //                ולבדוק כמה יש שכנים אדומים ולשמור בתוך משתנה
            }
        }
        public Boolean isBlueDies() {
           if (//blueNeighbors != 1 || redNeighbors == 0 || redNeighbors > 3 ) {  כחול נהפך להיות תא פנוי }
            }
    }
    class Unoccuppied:Cell {
        public override int FindNumOfNeighbors() {
            foreach (Unoccuppied unoccuppied in Cells)
            {
                //   ,לבדוק את הבא אחריו זה שלפניו מעליו מתחתיו ובאלכסונים
                //    ולבדוק כמה יש שכנים שהם לא פנויים ולשמור בתוך משתנה 
            }
        }
        public Boolean isNewCellBorn() {
                if (// neighbors == 3) {  מתחלף התא הפנוי באדום או כחול בהסתברות של 0.5}
            }
    }
    class Cells_Group
    {
        private Array[] Cells;

        public Boolean IsWin(Array[] Cells)
        {
          // בודק האם כל הלוח פנוי במידה וכן מנצח
            foreach (Cell cell in Cells)
            {
                if (Cells[Cell] != null)
                {
                    return false;
                }
            }

            return true;
        }
        public Array[] Cells {
            get {
                return Cells;
            }
            set {
                Cells = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
