﻿namespace Svg.Model
{
    public class PaintImageFilter : ImageFilter
    {
        public Paint Paint { get; set; }
        public CropRect CropRect { get; set; }

        public PaintImageFilter(Paint paint, CropRect cropRect)
        {
            Paint = paint;
            CropRect = cropRect;
        }
    }
}
