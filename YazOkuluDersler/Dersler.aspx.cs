﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class Dersler : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (Page.IsPostBack == false)
		{
			List<EntityDers> EntDers = BLLDers.BllListele();
			DropDownList1.DataSource = EntDers;
			DropDownList1.DataTextField = "DERSAD";
			DropDownList1.DataValueField = "ID";
			DropDownList1.DataBind();

			List<EntityOgrenci> EntOgrenci = BLLOgrenci.BllListele();
			DropDownList2.DataSource = EntOgrenci;
			DropDownList2.DataTextField = "AD";
			DropDownList2.DataValueField = "ID";
			DropDownList2.DataBind();

		}
	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		//TextBox1.Text = DropDownList1.SelectedValue.ToString();
		EntityBasvuruForm ent = new EntityBasvuruForm();
		ent.BASOGRID = int.Parse(DropDownList1.SelectedValue.ToString());
		ent.BASDERSID = int.Parse(DropDownList1.SelectedValue.ToString());
		BLLDers.TalepEkleBLL(ent);
	}
}