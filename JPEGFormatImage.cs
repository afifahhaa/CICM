

using Microsoft.Maui.Controls;
using System;

namespace CICMmauiApp
{
    internal class JPEGFormatImage
    {
        private Uri uri;
        private Uri uri1;

        public JPEGFormatImage(Uri uri)
        {
            this.uri = uri;
        }

        //public JPEGFormatImage(Uri uri1)
        //{
        //    this.uri1 = uri1;
        //}

        public static implicit operator ImageSource(JPEGFormatImage v)
        {
            throw new NotImplementedException();
        }
    }
}