using Assignment8.Models;
using System;

namespace Assignment8;
public partial class ButcheryDetails : ContentPage
{
    public ButcheryDetails(ButcheryItemView ItemView)
	{
		InitializeComponent();
        BindingContext = ItemView;
    }
}