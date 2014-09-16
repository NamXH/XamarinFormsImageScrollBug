using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace TestImageScrollBug
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
            _tableView.Intent = TableIntent.Menu;

            var imageSection = new TableSection("One");
            var imageCell = new ImageCell();
            imageCell.ImageSource = ImageSource.FromResource("TestImageScrollBug.Images.contact_icon.png");
            imageSection.Add(imageCell);
            _tableRoot.Add(imageSection);

            var tableSection = new TableSection("Two");

            var textCell = new TextCell();
            textCell.Text = "blah1";
            tableSection.Add(textCell);

            var textCell1 = new TextCell();
            textCell1.Text = "blah1";
            tableSection.Add(textCell1);

            var textCell2 = new TextCell();
            textCell2.Text = "blah1";
            tableSection.Add(textCell2);

            var textCell3 = new TextCell();
            textCell3.Text = "blah1";
            tableSection.Add(textCell3);

            var textCell4 = new TextCell();
            textCell4.Text = "blah1";
            tableSection.Add(textCell4);

            var textCell5 = new TextCell();
            textCell5.Text = "blah1";
            tableSection.Add(textCell5);

            var textCell6 = new TextCell();
            textCell6.Text = "blah1";
            tableSection.Add(textCell6);

            var textCell7 = new TextCell();
            textCell7.Text = "blah1";
            tableSection.Add(textCell7);

            var textCell8 = new TextCell();
            textCell8.Text = "blah1";
            tableSection.Add(textCell8);

            var textCell9 = new TextCell();
            textCell9.Text = "blah1";
            tableSection.Add(textCell9);

            var textCell0 = new TextCell();
            textCell0.Text = "blah1";
            tableSection.Add(textCell0);

            _tableRoot.Add(tableSection);
        }
    }
}

