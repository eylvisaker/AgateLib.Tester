﻿//
//    Copyright (c) 2006-2018 Erik Ylvisaker
//
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the "Software"), to deal
//    in the Software without restriction, including without limitation the rights
//    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//    copies of the Software, and to permit persons to whom the Software is
//    furnished to do so, subject to the following conditions:
//
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
//
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//    SOFTWARE.
//

using System;
using System.Collections.Generic;
using System.Text;
using AgateLib.Display;
using AgateLib.UserInterface.Styling;
using AgateLib.UserInterface.Styling.Themes.Model;

namespace AgateLib.UserInterface.Widgets
{
    public class WidgetStyle
    {
        public BorderStyle Border { get; set; } = new BorderStyle();

        public BackgroundStyle Background { get; set; } = new BackgroundStyle();

        public AnimationStyle Animation { get; set; } = new AnimationStyle();

        public ThemeWidgetSize Size { get; set; } = new ThemeWidgetSize();

        public LayoutBox Padding { get; set; }

        public LayoutBox Margin { get; set; }

        public string Theme { get; set; }

        public Font Font { get; set; }
    }
}
