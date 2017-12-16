using MoneyMaker.Models.Database;
using MoneyMaker.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace MoneyMaker.ViewModels
{
    public class UserlineModel : DatabaseModel
    {
        private StockListitem stock;
        private Color lineColor;
        private int lineThickness;

        /// <summary>
        /// Default constructor
        /// </summary>
        public UserlineModel(StockListitem stock, Color lineColor = default(Color), int lineThickness = 1)
        { 
            this.stock = stock;
            this.lineColor = lineColor;
            this.lineThickness = lineThickness;
        }

        /// <summary>
        /// Inserts a new userline for the selected userline
        /// </summary>
        public UserLines insertUserline(DataPoint p1, DataPoint p2)
        {
            UserLines result = null;
            if (ConnectionState == true)
            {
                var newItem = new UserLines
                {
                    StocksMapID = stock.StocksMapID,
                    PricePoint1 = p1.YValues[0],
                    PricePoint2 = p2.YValues[0],
                    TimePoint1 = p1.XValue,
                    TimePoint2 = p2.XValue,
                    LineColor = ColorTranslator.ToHtml(lineColor),
                    Thickness = Convert.ToSByte(lineThickness),
                };
                db.UserLines.InsertOnSubmit(newItem);
                db.SubmitChanges();
                result = newItem;
            }
            return result;
        }

        /// <summary>
        /// Returns a list of all userlines for the selected stock
        /// </summary>
        public List<UserLines> getAllUserlines()
        {
            var result = new List<UserLines>();
            if (ConnectionState == true)
            {
                var query = (from ul in db.UserLines
                               where ul.StocksMapID == stock.StocksMapID
                               select ul);

                if (query != null && query.Any())
                {
                    result = query.ToList();
                }
            }
            return result;
        } 

        /// <summary>
        /// Removes all userlines for the stock selected
        /// </summary>
        public void deleteAllUserlines()
        {
            if (ConnectionState == true)
            {
                var sequenz = (from ul in db.UserLines
                            where ul.StocksMapID == stock.StocksMapID
                            select ul);

                db.UserLines.DeleteAllOnSubmit(sequenz);
                db.SubmitChanges();
            }
        }

        /// <summary>
        /// Updates the selected userline - NOT WORKING
        /// </summary>
        public void updateUserline(UserLines selectedLine = null)
        {
            if (ConnectionState == true && selectedLine != null)
            {
                var query = db.UserLines.Single(x => x.LineID == selectedLine.LineID);
                if(query != null)
                {
                    query.TimePoint1 = selectedLine.TimePoint1;
                    query.TimePoint2 = selectedLine.TimePoint2;
                    query.PricePoint1 = selectedLine.PricePoint1;
                    query.PricePoint2 = selectedLine.PricePoint2;
                    query.LineColor = selectedLine.LineColor;
                    query.Thickness = selectedLine.Thickness;
                    db.SubmitChanges();
                }
            }
        }

        /// <summary>
        /// Deletes the selected userline
        /// </summary>
        public void deleteUserline(UserLines selectedLine)
        {
            if (ConnectionState == true)
            {
                var query = db.UserLines.Single(x => x.LineID == selectedLine.LineID);
                db.UserLines.DeleteOnSubmit(query);
                db.SubmitChanges();
            }
        }

    }
}
