﻿
namespace ImageResizer.FluentExtensions
{
    public class AlignmentExpression : ResizeExpression
    {
        internal AlignmentExpression(ImageBuilder builder) : base(builder)
        {
        }

        /// <summary>
        /// Determines how to anchor the image when padding or cropping
        /// </summary>
        /// <param name="anchorPoint">The position of the anchor point</param>
        /// <returns></returns>
        public AlignmentExpression Anchor(AnchorPoint anchorPoint)
        {
            builder.SetParameter(AlignmentParameters.Anchor, anchorPoint.ToString().ToLowerInvariant());
            return this;
        }
    }

    public enum AnchorPoint
    {
        TopLeft,
        TopCenter,
        TopRight,
        MiddleLeft,
        MiddleCenter,
        MiddleRight,
        BottomLeft,
        BottomCenter,
        BottomRight
    }

    internal static class AlignmentParameters
    {
        internal const string Anchor = "anchor";
    }
}