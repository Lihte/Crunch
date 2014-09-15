#region Using Statements
using System;
using WaveEngine.Common;
using WaveEngine.Common.Graphics;
using WaveEngine.Framework;
using WaveEngine.Framework.Services;
#endregion

namespace CrunchProject
{
    public class MyScene : Scene
    {
        protected override void CreateScene()
        {
            GameBoard myGameBoard = new GameBoard(5, 5);

            //Node myNode = new Node("nodegreen", 10, 10);
            //Node myNode1 = new Node("nodeblue", 30, 30);
            //Node myNode2 = new Node("nodered", 50, 50);

            //myNode.ToggleSelection();

            RenderManager.BackgroundColor = Color.CornflowerBlue;

            for (int i = 0; i < myGameBoard.BoardSize; i++)
            {
                EntityManager.Add(myGameBoard.Board[i].getEntity());
            }

            //EntityManager.Add(myNode.getEntity());
            //EntityManager.Add(myNode1.getEntity());
            //EntityManager.Add(myNode2.getEntity());
            //Insert your code here
        }
    }
}
