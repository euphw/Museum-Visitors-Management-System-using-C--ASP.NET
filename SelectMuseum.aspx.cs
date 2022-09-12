/*******************************************************************/
/**                                                               **/
/**                                                               **/
/**    Visitor Name                :  Yuefeng Wang                **/
/**    EMail Address               :  wang0873@algonquinlive.com  **/
/**    Visitor Number              :  041050868                   **/
/**    Museum Number               :  CST 8253                    **/
/**    Lab Section Number          :  302                         **/
/**    Professor Name              :  Sanaa Issa                  **/
/**    Assignment Name/Number/Date :  Lab 8                       **/
/**    Optional Comments           :                              **/
/**                                                               **/
/**                                                               **/
/*******************************************************************/
using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project
{
    public partial class SelectMuseum : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

            if (this.IsPostBack == false)
            {


                List<Visitor> VisitorList = (List<Visitor>)Session["Visitors"];

                // Add object to dropdown list
                if (Session["Visitors"] != null)
                {
                    foreach (Visitor Visitor in VisitorList)
                    {
                        drpVisitor.Items.Add(Visitor.ToString());

                    }
                }

                foreach (Museum m in Helper.GetAvailableMuseums())
                {
                    CheckBoxList.Items.Add(new ListItem(m.Code + m.Title + " - " + String.Format("{0:C}", m.Price) , m.Code));
                }
            }
        }


        

        protected void nameChanged(Object sender, EventArgs e)
        {
            // if the selected value is not null
            if(drpVisitor.SelectedValue != "-1" )
            {

                CheckBoxList.Enabled = true;
                //clear the checkbox for the new Visitor
                CheckBoxList.ClearSelection();
                lblErrorMsg.Visible = false;
                summary.Visible = true;
                summary.Text = "Selected Visitor has picked 0 Museum(s), total price is $0";
            }
            else
            {
                CheckBoxList.ClearSelection();
                summary.Visible = false;
                CheckBoxList.Enabled = false;
            }
        }

        // when users check any items of checkbox list.
        protected void MuseumChanged(Object sender, EventArgs e)
        {
            
            // If there is no Visitor selected, an error message will be shown next to the field.
            Page.Validate();
            //int count=0;
            double selectPrice=0;
            List<Museum> selectedMuseumList = new List<Museum>();
            // If the user select a Visitor successfully.
            if (IsValid)
            {
                foreach (ListItem lstItem in CheckBoxList.Items)
                {
                    //calculate the hours and the number of selected Museums.
                    if (lstItem.Selected == true)
                    {
                        Museum selectedMuseum = Helper.GetMuseumByCode(lstItem.Value);
                        selectedMuseumList.Add(selectedMuseum);
                        selectPrice = selectPrice + selectedMuseum.Price;

                    }
                }
                List<Visitor> VisitorList = (List<Visitor>)Session["Visitors"];
                //VisitorList[drpVisitor.SelectedIndex - 1].RegisterMuseums(selectedMuseumList);
                lblErrorMsg.Visible = false;
                //A registration summary showing the number of Museums and total weekly hours
                summary.Visible = true;
                summary.Text = String.Format("Selected Visitor has picked {0} Museum(s), total price is {1}", selectedMuseumList.Count, String.Format("{0:C}", selectPrice));
            }
            

        }

        // when users click the save button
        protected void save_Click(object sender, System.EventArgs e)
        {

            summary.Visible = false;

            List<Museum> selectedMuseumList = new List<Museum>();
            foreach (ListItem lstItem in CheckBoxList.Items)
            {
                //calculate the hours and the number of selected Museums.
                if (lstItem.Selected == true)
                {
                    Museum selectedMuseum = Helper.GetMuseumByCode(lstItem.Value);
                    selectedMuseumList.Add(selectedMuseum);
                    //MuseumtHour = Convert.ToInt32(selectedMuseum.WeeklyHours);
                    //selectHours = selectHours + MuseumtHour;
                }
            }
            List<Visitor> VisitorList = (List<Visitor>)Session["Visitors"];
            //int totalHours = VisitorList[drpVisitor.SelectedIndex - 1].TotalWeeklyHours();

            try
            {
               
                VisitorList[drpVisitor.SelectedIndex-1].RegisterMuseums(selectedMuseumList);
                int totalHours = VisitorList[drpVisitor.SelectedIndex - 1].TotalPrice();
                lblErrorMsg.Visible = false;
                summary.Visible = true;
                summary.Text = String.Format("Selected Visitor has picked {0} Museum(s), total price is {1} ", selectedMuseumList.Count, String.Format("{0:C}", totalHours));
                TableRow newRow = null;
                TableCell newCell = null;
                newRow = new TableRow();
                tblMuseums.Rows.Add(newRow);

                newCell = new TableCell();
                newRow.Cells.Add(newCell);
                newCell.Text = VisitorList[drpVisitor.SelectedIndex - 1].Id;

                newCell = new TableCell();
                newRow.Cells.Add(newCell);
                newCell.Text = VisitorList[drpVisitor.SelectedIndex - 1].Name;

                string museumsInTable = "";
                foreach (Museum m in selectedMuseumList)
                {
                    //calculate the hours and the number of selected Museums.
                    museumsInTable = "<p>" + m.Title + "</p>" + museumsInTable;
                }

                newCell = new TableCell();
                newRow.Cells.Add(newCell);
                newCell.Text = museumsInTable;
            }
            catch (Exception ex)
            {
                lblErrorMsg.Visible = true;
                lblErrorMsg.Text = ex.Message;
            }


        }
    }
}