﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagsCloudVisualization
{
    interface ICloudLayouter
    {
        Rectangle PutNextRectangle(Size rectangleSize);

        List<Rectangle> Rectangles { get; }

        Rectangle CloudRectangle { get; }
    }
}
