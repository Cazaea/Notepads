﻿namespace Notepads.Extensions.DiffViewer
{
    using Windows.UI.Xaml;

    public interface ISideBySideDiffViewer
    {
        void RenderDiff(string left, string right, ElementTheme theme);
    }
}