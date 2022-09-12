/*******************************************************************/
/**                                                               **/
/**                                                               **/
/**    Visitor Name                :  Yuefeng Wang                **/
/**    EMail Address               :  wang0873@algonquinlive.com  **/
/**    Visitor Number              :  041050868                   **/
/**    Course Number               :  CST 8253                    **/
/**    Lab Section Number          :  302                         **/
/**    Professor Name              :  Sanaa Issa                  **/
/**    Assignment Name/Number/Date :  Final                       **/
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
    public partial class AddVisitor : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {




            if (this.IsPostBack == false)
            { // Add a new row to tell user there is no Visitor at first.
                if (Session["Visitors"] == null)
                {
                    TableRow newRow = null;
                    TableCell newCell = null;
                    newRow = new TableRow();
                    tblVisitors.Rows.Add(newRow);

                    newCell = new TableCell();
                    newRow.Cells.Add(newCell);

                    newCell.ColumnSpan = 2;
                    newCell.ForeColor = System.Drawing.Color.Red;
                    newCell.HorizontalAlign = HorizontalAlign.Center;
                    newCell.Text = "No Visitor Yet!";
                }
                else
                {
                    VisitorList = (List<Visitor>)Session["Visitors"];
                    foreach (Visitor Visitor in VisitorList)
                    {

                        TableCell newCell = new TableCell();
                        TableRow newRow = new TableRow();
                        tblVisitors.Rows.Add(newRow);

                        newRow.Cells.Add(newCell);
                        newCell.ForeColor = System.Drawing.Color.Black;
                        newCell.HorizontalAlign = HorizontalAlign.Left;
                        newCell.ColumnSpan = 0;
                        newCell.Text = Visitor.Id;

                        newCell = new TableCell();
                        newRow.Cells.Add(newCell);
                        newCell.Text = Visitor.Name;
                    }
                }


            }
        }
        // Creat a public list to store objects.
        List<Visitor> VisitorList = new List<Visitor>();
        protected void cmdAdd_Click(object sender, System.EventArgs e)
        {
            // Abort the event if the page isn't valid.
            if (!IsValid) return;

            if (drpVisitorType.SelectedValue == "BasicPackage")
            {

                BasicPackage Visitors = new BasicPackage(name.Text);

                // store in Visitor session
                if (Session["Visitors"] == null)
                {

                    VisitorList.Add(Visitors);
                    Session["Visitors"] = VisitorList;
                    
                }
                else
                {
                    VisitorList = (List<Visitor>)Session["Visitors"];
                    VisitorList.Add(Visitors);
                    //store the updated list to session
                    Session["Visitors"] = VisitorList;                   
                }

            }
            else if (drpVisitorType.SelectedValue == "PrimePackage")
            {
                PrimePackage Visitors = new PrimePackage(name.Text);

                if (Session["Visitors"] == null)
                {

                    VisitorList.Add(Visitors);
                    Session["Visitors"] = VisitorList;
                }
                else
                {
                    VisitorList = (List<Visitor>)Session["Visitors"];
                    VisitorList.Add(Visitors);
                    Session["Visitors"] = VisitorList;
                }

             

            }
            else if (drpVisitorType.SelectedValue == "SupremePackage")
            {
                SupremePackage Visitors = new SupremePackage(name.Text);

                if (Session["Visitors"] == null)
                {

                    VisitorList.Add(Visitors);
                    Session["Visitors"] = VisitorList;
                }
                else
                {
                    VisitorList = (List<Visitor>)Session["Visitors"];
                    VisitorList.Add(Visitors);
                    Session["Visitors"] = VisitorList;
                }

             

            }

            // show every object line by line in the order of adding.
            foreach (Visitor Visitor in VisitorList)
            {
                TableCell newCell = new TableCell();
                TableRow newRow = new TableRow();
                tblVisitors.Rows.Add(newRow);

                newRow.Cells.Add(newCell);
                newCell.ForeColor = System.Drawing.Color.Black;
                newCell.HorizontalAlign = HorizontalAlign.Left;
                newCell.ColumnSpan = 0;
                newCell.Text = Visitor.Id;

                newCell = new TableCell();
                newRow.Cells.Add(newCell);
                newCell.Text = Visitor.Name;
            }

            //set the name text box and dropdown list to default.
            name.Text = null;
            drpVisitorType.SelectedValue = null;
            
        }

    }
}