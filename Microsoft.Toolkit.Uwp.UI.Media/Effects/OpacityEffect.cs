﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Microsoft.Toolkit.Uwp.UI.Media.Pipelines;

namespace Microsoft.Toolkit.Uwp.UI.Media.Effects
{
    /// <summary>
    /// An opacity effect
    /// </summary>
    /// <remarks>This effect maps to the Win2D <see cref="Graphics.Canvas.Effects.OpacityEffect"/> effect</remarks>
    public sealed class OpacityEffect : IPipelineEffect
    {
        private double value = 1;

        /// <summary>
        /// Gets or sets the opacity value to apply to the background (defaults to 1, should be in the [0, 1] range).
        /// </summary>
        public double Value
        {
            get => this.value;
            set => this.value = Math.Clamp(value, 0, 1);
        }

        /// <inheritdoc/>
        public PipelineBuilder AppendToPipeline(PipelineBuilder builder)
        {
            return builder.Opacity((float)Value);
        }
    }
}
