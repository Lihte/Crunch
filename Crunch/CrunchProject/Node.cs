using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WaveEngine.Common;
using WaveEngine.Common.Graphics;
using WaveEngine.Components.Gestures;
using WaveEngine.Components.Graphics2D;
using WaveEngine.Components.UI;
using WaveEngine.Framework;
using WaveEngine.Framework.Graphics;
using WaveEngine.Framework.Physics2D;
using WaveEngine.Framework.Services;

namespace CrunchProject
{
    public class Node
    {
        public int PosX
        {
            get;
            set;
        }
        public int PosY
        {
            get;
            set;
        }

        public int NodeValue
        {
            get;
            set;
        }

        public bool Selected
        {
            get;
            private set;
        }

        Entity myEntity = new Entity("Node")
       .AddComponent(new Sprite("Content/Sprite-icon.wpk"))
       .AddComponent(new SpriteRenderer(DefaultLayers.Alpha))
       .AddComponent(new Transform2D()
       {
           Y = WaveServices.Platform.ScreenHeight / 2,
           X = WaveServices.Platform.ScreenWidth / 2
       });
       

        public Node()
        {
            PosX = 1;
            PosY = 1;
            NodeValue = 10;
            Selected = false;
        }

        public void ToggleSelection()
        {
            Selected = !Selected;
        }

        public Entity getEntity()
        {
            return myEntity;
        }
    }
}
