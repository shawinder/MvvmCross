﻿#region Copyright

// <copyright file="MvxWebBrowserTask.cs" company="Cirrious">
// (c) Copyright Cirrious. http://www.cirrious.com
// This source is subject to the Microsoft Public License (Ms-PL)
// Please see license.txt on http://opensource.org/licenses/ms-pl.html
// All other rights reserved.
// </copyright>
// 
// Author - Stuart Lodge, Cirrious. http://www.cirrious.com

#endregion

#region using

using Android.Content;
using Cirrious.MvvmCross.Interfaces.Platform.Tasks;

#endregion

namespace Cirrious.MvvmCross.Android.Platform.Tasks
{
    public class MvxWebBrowserTask : MvxAndroidTask, IMvxWebBrowserTask
    {
        #region IMvxWebBrowserTask Members

        public void ShowWebPage(string url)
        {
            var intent = new Intent(Intent.ActionView, global::Android.Net.Uri.Parse(url));
            StartActivity(intent);
        }

        #endregion
    }
}