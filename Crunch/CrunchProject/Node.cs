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

        private string TexturePath
        {
            get;
            set;
        }

        private Entity myEntity;


        public Node(string nodeName, int _posX, int _posY)
        {
            myEntity = new Entity(nodeName)
               .AddComponent(new Sprite("Content/placeholder_GreenCrystal.wpk"))
               .AddComponent(new SpriteRenderer(DefaultLayers.Alpha))
               .AddComponent(new Transform2D()
               {
                   Y = _posY * 10,
                   X = _posX * 10
               });

            //initializeNodeEntity(nodeName, crystalType, positionOffsetX, positionOffsetY);
            PosX = _posX;
            PosY = _posY;
            NodeValue = 10;
            Selected = false;
        }

        //private void initializeNodeEntity(string nodeName, string crystalType, float positionOffsetX, float positionOffsetY)
        //{
        //    switch (crystalType)
        //    {
        //        case "red":
        //            TexturePath = "Content/placeholder_RedCrystal.wpk";
        //            break;
        //        case "blue":
        //            TexturePath = "Content/placeholder_BlueCrystal.wpk";
        //            break;
        //        case "green":
        //            TexturePath = "Content/placeholder_GreenCrystal.wpk";
        //            break;
        //    }

        //    myEntity = new Entity(nodeName)
        //       .AddComponent(new Sprite(TexturePath))
        //       .AddComponent(new SpriteRenderer(DefaultLayers.Alpha))
        //       .AddComponent(new Transform2D()
        //       {
        //           Y = positionOffsetY,
        //           X = positionOffsetX
        //       });
        //}

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
