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
        public void startGame() { }

        public virtual int FindNumOfNeighbors() { }
    }
    class Red:Cell {
        public override int FindNumOfNeighbors() { }
        public Boolean isRedDies() { }
    }
    class Blue:Cell {
        public int FindNumOfBlueNeighbors() { }
        public int FindNumOfRedNeighbors() { }
        public Boolean isBlueDies() { }
    }
    class Unoccuppied:Cell {
        public override int FindNumOfNeighbors() { }
        public Boolean isNewCellBorn() { }
    }
    class Cells_Group
    {
        private Array[] Cells;

        public Boolean IsWin(Array[] Cells)
        {
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
