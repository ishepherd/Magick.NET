﻿// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

using System;
using System.Collections.Generic;
using ImageMagick.Defines;

namespace ImageMagick.Formats
{
    /// <summary>
    /// Class for defines that are used when a video image is read.
    /// </summary>
    public sealed class VideoReadDefines : WriteDefinesCreator
    {
        private static readonly List<MagickFormat> AllowedFormats = new List<MagickFormat> { MagickFormat.ThreeGp, MagickFormat.ThreeG2, MagickFormat.APng, MagickFormat.Avi, MagickFormat.Flv, MagickFormat.Mkv, MagickFormat.Mov, MagickFormat.Mpeg, MagickFormat.Mpg, MagickFormat.Mp4, MagickFormat.M2v, MagickFormat.M4v, MagickFormat.WebM, MagickFormat.Wmv };

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoReadDefines"/> class.
        /// </summary>
        /// <param name="format">The video format.</param>
        public VideoReadDefines(MagickFormat format)
          : base(CheckFormat(format))
        {
        }

        /// <summary>
        /// Gets the defines that should be set as a define on an image.
        /// </summary>
        public override IEnumerable<IDefine> Defines
        {
            get
            {
                yield break;
            }
        }

        private static MagickFormat CheckFormat(MagickFormat format)
        {
            if (!AllowedFormats.Contains(format))
                throw new ArgumentException("The specified format is not a video format.", nameof(format));

            return format;
        }
    }
}