﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MySchool.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoursePage : CarouselPage
    {
        public CoursePage()
        {
            InitializeComponent();
        }

        private void ButtonAddCourse_Clicked(object sender, EventArgs e)
        {

        }
    }
}