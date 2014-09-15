using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrunchProject
{
    public class GameBoard
    {
        private List<Node> _gameBoard;

        public int BoardSize
        {
            get
            {
                return _gameBoard.Count;
            }
        }

        public List<Node> Board
        {
            get
            {
                return _gameBoard;
            }
        }

        public GameBoard(int sizeX, int sizeY)
        {
            _gameBoard = new List<Node>();

            for(int x = 0; x < sizeX; x++)
            {
                for(int y = 0; y < sizeY; y++)
                {
                    _gameBoard.Add(new Node("node" + x.ToString() + "_" + y.ToString(), x, y));
                }
            }
        }


    }
}
