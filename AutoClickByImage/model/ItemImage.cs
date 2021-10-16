﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClickByImage.model
{
    public class ItemImage
    {

        public  int orderId { get; set; }
        public  string pathFileImage { get; set; }
        public string modeClick { get; set; }


        public ItemImage()
        {
            
        }

        public ItemImage(int orderId, string pathFileImage, string modeClick)
        {
            this.orderId = orderId;
            this.pathFileImage = pathFileImage;
            this.modeClick = modeClick;
        }


    }
}