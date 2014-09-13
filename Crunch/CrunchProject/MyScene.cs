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
            Node myNode = new Node();

            myNode.ToggleSelection();

            RenderManager.BackgroundColor = Color.CornflowerBlue;
            EntityManager.Add(myNode.getEntity());
            //Insert your code here
        }
    }
}
